using DiceTravel.Classes;
using DiceTravel.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiceTravel.Util
{
    public class MainFormUpdater
    {
        public enum FlowType { Journey, NoFlow }

        private MainForm MainForm { get; }
        public FlowType ActiveFlowType { get; private set; }
        public MainFormUpdater(MainForm mainForm)
        {
            MainForm = mainForm;
        }

        public void SetDefaultFlowType()
        {
            ActiveFlowType = FlowType.Journey;
        }
        public void Update()
        {
            UserDataUpdate();
            ActiveJourneyDataUpdate();
            TripDataUpdate();
            FlowUpdate();
        }

        private void UserDataUpdate()
        {

        }
        private void ActiveJourneyDataUpdate()
        {

        }
        private void TripDataUpdate()
        {

        }
        private void FlowUpdate()
        {
            switch (ActiveFlowType)
            {
                case FlowType.Journey:
                    FlowUpdate_MyJourney();
                    break;

                case FlowType.NoFlow:
                    throw new System.Exception("Ez még nincs kész!");

                default:
                    throw new MissingFlowTypeException("Missing flow type!");
            }
        }
        private void FlowUpdate_MyJourney()
        {
            MainForm.FlowLayoutPanel.Controls.Clear();
            List<Journey> journeys = ActiveUserStore.ActiveUser.GetJourneys();

            List<JourneyControl> journeyControls = new List<JourneyControl>();

            foreach (Journey journey in journeys)
            {
                journeyControls.Add(new JourneyControl(journey));
                MainForm.FlowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            }

            for (int i = 0; i < journeyControls.Count; i++)
            {
                JourneyControl control = journeyControls[i];
                control.Name = $"JourneyControl_{i}";
                control.SetContent();
                control.Visible = true;
                MainForm.FlowLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                MainForm.FlowLayoutPanel.Controls.Add(control, 0, i);
            }
        }
    }
}
