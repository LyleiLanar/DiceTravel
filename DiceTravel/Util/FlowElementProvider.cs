using DiceTravel.Classes;
using DiceTravel.Controls;
using DiceTravel.EntityClasses;
using System;
using System.Collections.Generic;

namespace DiceTravel.Util
{
    public class FlowElementProvider
    {
        public enum FlowType { NoFlow, JourneyFlow_ByUser, MainFlow_ByUser, TripFlow_ByJourney, EntryFlow_ByTrip, StoryFlow_ByUser, Friends, PeopleByLoginName }
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


                case FlowType.JourneyFlow_ByUser:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    FlowTitle = $"{userLoginName}'s journeys:";

                    SetFlowJourneyFlowByUser(UserId);
                    break;

                case FlowType.MainFlow_ByUser:
                    throw new NotImplementedException();

                case FlowType.TripFlow_ByJourney:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    journeyTitle = Journey.GetJourney_ById(JourneyId).Title;
                    FlowTitle = $"{userLoginName}'s {journeyTitle} trips:";

                    SetFlowTripFlowByJourney(JourneyId);
                    break;

                case FlowType.EntryFlow_ByTrip:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    journeyTitle = Journey.GetJourney_ById(JourneyId).Title;
                    tripEndLocation = Trip.GetTripById(TripId).EndLocation;
                    FlowTitle = $"{userLoginName}'s {journeyTitle}: {tripEndLocation} entries:";

                    SetFlowEntryFlowByTrip(TripId);
                    break;

                case FlowType.StoryFlow_ByUser:
                    userLoginName = User.GetUserById(UserId).LoginName;
                    FlowTitle = $"{userLoginName}'s story:";

                    SetFlowStoryFlowByUser(UserId);
                    break;

                case FlowType.Friends:
                    throw new NotImplementedException();
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
            Type = FlowType.JourneyFlow_ByUser;

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
            Type = FlowType.TripFlow_ByJourney;

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
                entryControls[i].Visible = ElementIsVisible(entry.Visibility,user.Id);
            }

            //setting the flowStatus            
            JourneyId = Trip.GetTripById(tripId).JourneyId;
            UserId = Journey.GetJourney_ById(JourneyId).UserId;
            TripId = tripId;
            Type = FlowType.EntryFlow_ByTrip;

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
            Type = FlowType.StoryFlow_ByUser;

            FlowElements.Clear();
            FlowElements.AddRange(entryControls);
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

        public void SetFlowMainFlowByUser()
        {

        }

    }
}
