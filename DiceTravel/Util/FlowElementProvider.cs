using DiceTravel.Classes;
using DiceTravel.Controls;
using System.Collections.Generic;

namespace DiceTravel.Util
{
    public class FlowElementProvider
    {
        public enum FlowType { NoFlow, JourneyFlow, MainFlow, TripFlow }
        public FlowType Type { get; private set; }
        public int UserId { get; private set; }
        public int JourneyId { get; private set; }
        public int TripId { get; private set; }

        public List<FlowElementControl> FlowElements { get; private set; }
        public string FlowTitle
        {
            get
            {
                string userLoginName;
                string journeyTitle;

                switch (Type)
                {
                    case FlowType.NoFlow:
                        return "NoFlow!";

                    case FlowType.JourneyFlow:
                        if (UserId != ActiveUserStore.ActiveUser.Id)
                        {
                            userLoginName = User.GetUser_ById(UserId).LoginName;
                            return $"{userLoginName} Journeys";
                        }
                        return "My Journeys";

                    case FlowType.TripFlow:

                        userLoginName = User.GetUser_ById(UserId).LoginName;
                        journeyTitle = Journey.GetJourney_ById(JourneyId).Title;
                        return $"{userLoginName} -> {journeyTitle} Trips";

                    case FlowType.MainFlow:
                        throw new MissingFlowTypeException("Missing flowType");

                    default:
                        throw new MissingFlowTypeException("Missing flowType");

                }
            }
        }

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
            switch (Type)
            {
                case FlowType.NoFlow:
                    throw new MissingFlowTypeException("No flow type, cannot update the flow!");

                case FlowType.JourneyFlow:
                    SetFlow_JourneysByUser(UserId);
                    break;

                case FlowType.MainFlow:
                    break;

                case FlowType.TripFlow:
                    SetFlow_TripsByJourney(JourneyId);
                    break;

                default:
                    throw new MissingFlowTypeException("No flow type, cannot update the flow!");
            }
        }

        //set Flow
        public void SetFlow_JourneysByUser(int userId)
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
            Type = FlowType.JourneyFlow;

            //update the list
            FlowElements.Clear();
            FlowElements.AddRange(journeyControls);
        }
        public void SetFlow_TripsByJourney(int journeyId)
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
            Type = FlowType.TripFlow;


            JourneyId = journeyId;
            FlowElements.Clear();
            FlowElements.AddRange(tripControls);
        }

    }
}
