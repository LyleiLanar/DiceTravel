using DiceTravel.Classes;
using DiceTravel.Controls;
using DiceTravel.EntityClasses;
using System.Collections.Generic;

namespace DiceTravel.Util
{
    public class FlowElementProvider
    {
        public enum FlowType { NoFlow, MainFlow, JourneyFlow, TripFlow, EntryFlow, StoryFlow, FriendFlow, PeopleFlow, InvitesFlow }
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
                    userLoginName = ActiveUserStore.ActiveUser.LoginName;
                    UserId = ActiveUserStore.ActiveUser.Id;
                    FlowTitle = $"JOURNEYS @{userLoginName}";

                    SetJourneyFlow(UserId);
                    break;

                case FlowType.JourneyFlow:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    FlowTitle = $"JOURNEYS @{userLoginName}";

                    SetJourneyFlow(UserId);
                    break;

                case FlowType.MainFlow:

                    FlowTitle = "Recent entries:";
                    SetMainFlow();
                    break;

                case FlowType.TripFlow:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    journeyTitle = Journey.GetJourneyById(JourneyId).Title;
                    FlowTitle = $"TRIPS @{userLoginName}/{journeyTitle}";

                    SetTripFlow(JourneyId);
                    break;

                case FlowType.EntryFlow:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    journeyTitle = Journey.GetJourneyById(JourneyId).Title;
                    tripEndLocation = Trip.GetTripById(TripId).EndLocation;
                    FlowTitle = $"ENTRIES @{userLoginName}/{journeyTitle}/{tripEndLocation}";

                    SetEntryFlow(TripId);
                    break;

                case FlowType.StoryFlow:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    FlowTitle = $"STORY @{userLoginName}";

                    SetStoryFlow(UserId);
                    break;

                case FlowType.FriendFlow:
                    FlowTitle = "FRIENDS";
                    SetFriendFlow();
                    break;

                case FlowType.InvitesFlow:
                    FlowTitle = "INVITES";
                    SetInvitesFlow();
                    break;

                case FlowType.PeopleFlow:
                    FlowTitle = $"Search results ('{LoginNameFragment}')";

                    SetPeopleFlow(LoginNameFragment);
                    break;

                default:
                    throw new MissingFlowTypeException("No flow type, cannot update the flow!");
            }
        }

        //set Flow
        public void SetMainFlow()
        {
            //setting the flowStatus
            ResetFlow();
            Type = FlowType.MainFlow;

            List<Entry> entries = ActiveUserStore.ActiveUser.GetFriendsThreeDaysEntries();

            List<EntryControl> entryControls = new List<EntryControl>();

            for (int i = 0; i < entries.Count; i++)
            {
                Entry entry = entries[i];

                entryControls.Add(new EntryControl(entry));
                entryControls[i].Name = $"EntryControl_{i}";
                entryControls[i].SetContent();
                entryControls[i].Visible = true;
            }

            if (entries.Count ==0)
            {
                FlowTitle += " NO ENTRIES!";
            }

            //setting the flowStatus            

            Type = FlowType.MainFlow;

            FlowElements.Clear();
            FlowElements.AddRange(entryControls);

        }
        public void SetPeopleFlow(string loginNameFragment)
        {
            //setting the flowStatus
            ResetFlow();
            Type = FlowType.PeopleFlow;
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
        public void SetFriendFlow()
        {
            //setting the flowStatus
            ResetFlow();
            User user = ActiveUserStore.ActiveUser;
            Type = FlowType.FriendFlow;
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
        public void SetJourneyFlow(int userId)
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
            Type = FlowType.JourneyFlow;

            //update the list
            FlowElements.Clear();
            FlowElements.AddRange(journeyControls);
        }
        public void SetTripFlow(int journeyId)
        {
            List<Trip> trips = Journey.GetJourneyById(journeyId).GetTrips();

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
            UserId = Journey.GetJourneyById(journeyId).UserId;
            JourneyId = journeyId;
            TripId = -1;
            Type = FlowType.TripFlow;

            FlowElements.Clear();
            FlowElements.AddRange(tripControls);
        }
        public void SetEntryFlow(int tripId)
        {
            List<Entry> entries = Trip.GetTripById(tripId).GetEntriesOrderedAsc();
            User user = User.GetUserById(Journey.GetJourneyById(Trip.GetTripById(tripId).JourneyId).UserId);

            List<EntryControl> entryControls = new List<EntryControl>();

            for (int i = 0; i < entries.Count; i++)
            {
                Entry entry = entries[i];
                Trip trip = Trip.GetTripById(entry.TripId);
                Journey journey = Journey.GetJourneyById(trip.JourneyId);

                entryControls.Add(new EntryControl(entry));
                entryControls[i].Name = $"EntryControl_{i}";
                entryControls[i].SetContent();

                //visibility checks
                entryControls[i].Visible = ElementIsVisible(entry.Visibility, user.Id);
                //entryControls[i].Visible = ElementIsVisible(trip.Visibility, user.Id);
                //entryControls[i].Visible = ElementIsVisible(journey.Visibility, user.Id);

            }

            //setting the flowStatus            
            JourneyId = Trip.GetTripById(tripId).JourneyId;
            UserId = Journey.GetJourneyById(JourneyId).UserId;
            TripId = tripId;
            Type = FlowType.EntryFlow;

            FlowElements.Clear();
            FlowElements.AddRange(entryControls);
        }
        public void SetStoryFlow(int userId)
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
            Type = FlowType.StoryFlow;

            FlowElements.Clear();
            FlowElements.AddRange(entryControls);
        }
        public void SetInvitesFlow()
        {
            User user = ActiveUserStore.ActiveUser;

            List<Friendship> invitations = Friendship.GetRecievedFriendshipInvitesByUserId(user.Id);
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

        internal void SetFlowStoriesOfFriends()
        {
            Program.MainForm.FlowElementProvider.SetMainFlow();
            Program.MainForm.DrawFlow();
        }
    }
}
