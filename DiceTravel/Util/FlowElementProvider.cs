using DiceTravel.Classes;
using DiceTravel.Controls;
using DiceTravel.EntityClasses;
using System;
using System.Collections.Generic;

namespace DiceTravel.Util
{
    public class FlowElementProvider
    {
        public enum FlowType { NoFlow, JourneyFlowByUser, MainFlowByUser, TripFlowByJourney, EntryFlowByTrip, StoryFlowByUser, Friends, PeopleByLoginName, InvitesFlow }
        public FlowType Type { get; private set; }
        public int UserId { get; private set; }
        public int JourneyId { get; private set; }
        public int TripId { get; private set; }
        public string FlowTitle { get; private set; }
        public string LoginNameFragment { get; private set; }
        public List<FlowElementControl> FlowElements { get; private set; }

        public FlowElementProvider()
        {
            ResetFlow();
            //FriendName = "";
            //Type = FlowType.NoFlow;
            //UserId = -1;
            //JourneyId = -1;
            //TripId = -1;
            //FlowElements = new List<FlowElementControl>();
        }
        public void ResetFlow()
        {
            LoginNameFragment = "";
            Type = FlowType.NoFlow;
            UserId = -1;
            JourneyId = -1;
            TripId = -1;
            FlowElements = new List<FlowElementControl>();
        }

        //refresh Flow based on settings, set previously
        public void UpdateFlow()
        {
            string userLoginName;
            string journeyTitle;
            string tripEndLocation;

            switch (Type)
            {
                case FlowType.NoFlow:
                    User activeUser = ActiveUserStore.ActiveUser;
                    userLoginName = activeUser.LoginName;
                    UserId = activeUser.Id;
                    FlowTitle = $"{userLoginName}'s journeys:";

                    SetFlowJourneyFlowByUser(UserId);
                    break;


                case FlowType.JourneyFlowByUser:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    FlowTitle = $"{userLoginName}'s journeys:";

                    SetFlowJourneyFlowByUser(UserId);
                    break;

                case FlowType.MainFlowByUser:
                    throw new NotImplementedException();

                case FlowType.TripFlowByJourney:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    journeyTitle = Journey.GetJourney_ById(JourneyId).Title;
                    FlowTitle = $"{userLoginName}'s {journeyTitle} trips:";

                    SetFlowTripFlowByJourney(JourneyId);
                    break;

                case FlowType.EntryFlowByTrip:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    journeyTitle = Journey.GetJourney_ById(JourneyId).Title;
                    tripEndLocation = Trip.GetTripById(TripId).EndLocation;
                    FlowTitle = $"{userLoginName}'s {journeyTitle}: {tripEndLocation} entries:";

                    SetFlowEntryFlowByTrip(TripId);
                    break;

                case FlowType.StoryFlowByUser:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    FlowTitle = $"{userLoginName}'s story:";

                    SetFlowStoryFlowByUser(UserId);
                    break;

                case FlowType.Friends:
                    FlowTitle = "My friends";
                    SetFlowPeopleFlowByUserFriends();
                    break;

                case FlowType.InvitesFlow:
                    FlowTitle = "My recieved invites:";
                    SetFlowInvitesFlow();
                    break;

                case FlowType.PeopleByLoginName:
                    FlowTitle = $"Search results for '{LoginNameFragment}'";

                    SetFlowPeopleFlowByLoginNameFragment(LoginNameFragment);
                    break;

                default:
                    throw new MissingFlowTypeException("No flow type, cannot update the flow!");
            }
        }

        //set Flow
        public void SetFlowPeopleFlowByLoginNameFragment(string loginNameFragment)
        {
            //setting the flowStatus
            ResetFlow();
            Type = FlowType.PeopleByLoginName;
            LoginNameFragment = loginNameFragment;

            List<User> people = User.SearchForUsersByLoginNameFragment(loginNameFragment);

            List<PersonControl> personControls = new List<PersonControl>();


            for (int i = 0; i < people.Count; i++)
            {
                User person = people[i];

                personControls.Add(new PersonControl(person));
                personControls[i].Name = $"PersonControl_{i}";
                personControls[i].SetContent();
                personControls[i].Visible = true;
            }

            //update the list
            FlowElements.Clear();
            FlowElements.AddRange(personControls);
        }
        public void SetFlowPeopleFlowByUserFriends()
        {
            //setting the flowStatus
            ResetFlow();
            User user = ActiveUserStore.ActiveUser;
            Type = FlowType.Friends;
            UserId = user.Id;

            List<User> friends = user.GetFriends();

            List<PersonControl> personControls = new List<PersonControl>();


            for (int i = 0; i < friends.Count; i++)
            {
                User person = friends[i];

                personControls.Add(new PersonControl(person));
                personControls[i].Name = $"PersonControl_{i}";
                personControls[i].SetContent();
                personControls[i].Visible = true;
            }

            //update the list
            FlowElements.Clear();
            FlowElements.AddRange(personControls);
        }
        public void SetFlowJourneyFlowByUser(int userId)
        {
            List<Journey> journeys = User.GetUserById(userId).GetJourneys();

            List<JourneyControl> journeyControls = new List<JourneyControl>();

            for (int i = 0; i < journeys.Count; i++)
            {
                Journey journey = journeys[i];

                journeyControls.Add(new JourneyControl(journey));
                journeyControls[i].Name = $"JourneyControl_{i}";
                journeyControls[i].SetContent();
                journeyControls[i].Visible = true;
            }

            //setting the flowStatus
            UserId = userId;
            JourneyId = -1;
            TripId = -1;
            Type = FlowType.JourneyFlowByUser;

            //update the list
            FlowElements.Clear();
            FlowElements.AddRange(journeyControls);
        }
        public void SetFlowTripFlowByJourney(int journeyId)
        {
            List<Trip> trips = Journey.GetJourney_ById(journeyId).GetTrips();

            List<TripControl> tripControls = new List<TripControl>();

            for (int i = 0; i < trips.Count; i++)
            {
                Trip trip = trips[i];

                tripControls.Add(new TripControl(trip));
                tripControls[i].Name = $"TripControl_{i}";
                tripControls[i].SetContent();
                tripControls[i].Visible = true;
            }

            //setting the flowStatus
            UserId = Journey.GetJourney_ById(journeyId).UserId;
            JourneyId = journeyId;
            TripId = -1;
            Type = FlowType.TripFlowByJourney;

            FlowElements.Clear();
            FlowElements.AddRange(tripControls);
        }
        public void SetFlowEntryFlowByTrip(int tripId)
        {
            List<Entry> entries = Trip.GetTripById(tripId).GetEntries();
            User user = User.GetUserById(Journey.GetJourney_ById(Trip.GetTripById(tripId).JourneyId).UserId);

            List<EntryControl> entryControls = new List<EntryControl>();

            for (int i = 0; i < entries.Count; i++)
            {
                Entry entry = entries[i];

                entryControls.Add(new EntryControl(entry));
                entryControls[i].Name = $"EntryControl_{i}";
                entryControls[i].SetContent();
                entryControls[i].Visible = ElementIsVisible(entry.Visibility, user.Id);
            }

            //setting the flowStatus            
            JourneyId = Trip.GetTripById(tripId).JourneyId;
            UserId = Journey.GetJourney_ById(JourneyId).UserId;
            TripId = tripId;
            Type = FlowType.EntryFlowByTrip;

            FlowElements.Clear();
            FlowElements.AddRange(entryControls);
        }
        public void SetFlowStoryFlowByUser(int userId)
        {
            User user = User.GetUserById(userId);
            List<Entry> entries = user.GetAllEntries();

            List<EntryControl> entryControls = new List<EntryControl>();

            for (int i = 0; i < entries.Count; i++)
            {
                int entryControlsCount = -1;
                if (ElementIsVisible(entries[i].Visibility, user.Id))
                {
                    entryControls.Add(new EntryControl(entries[i]));
                    entryControlsCount++;
                    entryControls[entryControlsCount].Name = $"EntryControl_{i}";
                    entryControls[entryControlsCount].SetContent();
                    entryControls[entryControlsCount].Visible = true;
                }
            }

            //setting the flowStatus            
            JourneyId = -1;
            UserId = userId;
            TripId = -1;
            Type = FlowType.StoryFlowByUser;

            FlowElements.Clear();
            FlowElements.AddRange(entryControls);
        }
        public void SetFlowMainFlowByUser()
        {
            throw new NotImplementedException();
        }
        public void SetFlowInvitesFlow()
        {
            User user = ActiveUserStore.ActiveUser;

            List<Friendship> invitations = Friendship.GetUserRecievedInvitesByUserId(user.Id);
            List<PersonControl> personControls = new List<PersonControl>();

            for (int i = 0; i < invitations.Count; i++)
            {
                User actUser = User.GetUserById(invitations[i].SenderId);

                personControls.Add(new PersonControl(actUser));
                personControls[i].Name = $"PersonControl_{i}";
                personControls[i].SetContent();
                personControls[i].Visible = true;
            }

            //setting the flowStatus            
            JourneyId = -1;
            UserId = user.Id;
            TripId = -1;
            Type = FlowType.InvitesFlow;

            FlowElements.Clear();
            FlowElements.AddRange(personControls);

        }

        //misc
        public bool IsUserIdSet()
        {
            if (UserId == -1)
            {
                return false;
            }
            return true;
        }
        private bool ElementIsVisible(int visibility, int userId)
        {
            Friendship friendship = Friendship.GetFriendshipByIds(ActiveUserStore.ActiveUser.Id, userId);

            if (ActiveUserStore.ActiveUser.Id == userId)
            {
                return true;
            }
            else
            {
                switch (visibility)
                {
                    case 0: //private 
                        return false;

                    case 1: //friends
                        if (friendship == null)
                        {
                            return false;
                        }

                        switch (friendship.Accepted)
                        {
                            case 1:
                                return true;

                            default:
                                return false;
                        }

                    case 2: //public
                        return true;

                    default:
                        return false;
                }
            }
        }
    }
}
