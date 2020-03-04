using DiceTravel.Classes;
using DiceTravel.Controls;
using System.Collections.Generic;

namespace DiceTravel.Util
{
    public class FlowProvider
    {
        public List<FlowElementControl> FlowElements { get; private set; }

        public FlowProvider()
        {
            FlowElements = new List<FlowElementControl>();
        }

        public void SetFlow_MyJourneys()
        {
            FlowElements.Clear();
            SetFlow_JourneysByUser(ActiveUserStore.ActiveUser.Id);
        }
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

            FlowElements.Clear();
            FlowElements.AddRange(journeyControls);
        }
        //public void SetFlow_TripsByJourney(int journeyId)
        //{
        //    List<Trip> trips = Journey.GetJourney_ById(journeyId).GetTrips();

        //    List<TripControl> tripControls = new List<TripControl>();

        //    for (int i = 0; i < trips.Count; i++)
        //    {
        //        Trip trip = trips[i];

        //        journeyControls.Add(new TripControl(trip));
        //        journeyControls[i].Name = $"JourneyControl_{i}";
        //        journeyControls[i].SetContent();
        //        journeyControls[i].Visible = true;
        //    }

        //    FlowElements.Clear();
        //    FlowElements.AddRange(journeyControls);
        //}
    }
}
