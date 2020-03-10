using DiceTravel.Classes;
using DiceTravel.Controls;
using System;
using System.Collections.Generic;

namespace DiceTravel.Util
{
    public class FlowElementProvider
    {
        public enum FlowType { NoFlow, JourneyFlow_ByUser, MainFlow_ByUser, TripFlow_ByJourney, EntryFlow_ByTrip, StoryFlow_ByUser }
        public FlowType Type { get; private set; }
        public int UserId { get; private set; }
        public int JourneyId { get; private set; }
        public int TripId { get; private set; }
        public string FlowTitle { get; private set; }
        public List<FlowElementControl> FlowElements { get; private set; }


        public FlowElementProvider()
        {
            Type = FlowType.NoFlow;
            UserId = -1;
            JourneyId = -1;
            TripId = -1;
            FlowElements = new List<FlowElementControl>();
        }

        //refresh Flow based on settings
        public void UpdateFlow()
        {
            string userLoginName;
            string journeyTitle;
            string tripEndLocation;

            switch (Type)
            {
                case FlowType.NoFlow:
                    throw new MissingFlowTypeException("No flow type, cannot update the flow!");

                case FlowType.JourneyFlow_ByUser:
                    userLoginName = User.GetUser_ById(UserId).LoginName;
                    FlowTitle = $"{userLoginName}'s journeys:";

                    SetFlow_JourneyFlow_ByUser(UserId);
                    break;

                case FlowType.MainFlow_ByUser:
                    throw new NotImplementedException();

                case FlowType.TripFlow_ByJourney:
                    userLoginName = User.GetUser_ById(UserId).LoginName;
                    journeyTitle = Journey.GetJourney_ById(JourneyId).Title;
                    FlowTitle = $"{userLoginName}'s {journeyTitle} trips:";

                    SetFlow_TripFlow_ByJourney(JourneyId);
                    break;

                case FlowType.EntryFlow_ByTrip:
                    userLoginName = User.GetUser_ById(UserId).LoginName;
                    journeyTitle = Journey.GetJourney_ById(JourneyId).Title;
                    tripEndLocation = Trip.GetTrip_ById(TripId).EndLocation;
                    FlowTitle = $"{userLoginName}'s {journeyTitle}: {tripEndLocation} entries:";

                    SetFlow_EntryFlow_ByTrip(TripId);
                    break;

                case FlowType.StoryFlow_ByUser:
                    userLoginName = User.GetUser_ById(UserId).LoginName;
                    FlowTitle = $"{userLoginName}'s story:";

                    SetFlow_StoryFlow_ByUser(UserId);
                    break;

                default:
                    throw new MissingFlowTypeException("No flow type, cannot update the flow!");
            }
        }

        //set Flow
        public void SetFlow_JourneyFlow_ByUser(int userId)
        {
            List<Journey> journeys = User.GetUser_ById(userId).GetJourneys();

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
        public void SetFlow_TripFlow_ByJourney(int journeyId)
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
        public void SetFlow_EntryFlow_ByTrip(int tripId)
        {
            List<Entry> entries = Trip.GetTrip_ById(tripId).GetEntries();

            List<EntryControl> entryControls = new List<EntryControl>();

            for (int i = 0; i < entries.Count; i++)
            {
                Entry entry = entries[i];

                entryControls.Add(new EntryControl(entry));
                entryControls[i].Name = $"EntryControl_{i}";
                entryControls[i].SetContent();
                entryControls[i].Visible = true;
            }

            //setting the flowStatus            
            JourneyId = Trip.GetTrip_ById(tripId).JourneyId;
            UserId = Journey.GetJourney_ById(JourneyId).UserId;
            TripId = tripId;
            Type = FlowType.EntryFlow_ByTrip;

            FlowElements.Clear();
            FlowElements.AddRange(entryControls);
        }
        public void SetFlow_StoryFlow_ByUser(int userId)
        {
            List<Entry> entries = User.GetUser_ById(userId).GetAllEntries();

            List<EntryControl> entryControls = new List<EntryControl>();

            for (int i = 0; i < entries.Count; i++)
            {
                Entry entry = entries[i];

                entryControls.Add(new EntryControl(entry));
                entryControls[i].Name = $"EntryControl_{i}";
                entryControls[i].SetContent();
                entryControls[i].Visible = true;
            }

            //setting the flowStatus            
            JourneyId = -1;
            UserId = userId;
            TripId = -1;
            Type = FlowType.StoryFlow_ByUser;

            FlowElements.Clear();
            FlowElements.AddRange(entryControls);
        }
    }
}
