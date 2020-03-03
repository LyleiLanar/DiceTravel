using DiceTravel.Classes;
using DiceTravel.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiceTravel.Util
{
    static public class FormUpdater
    {
        public enum FlowType { Journey, NoFlow }
        static public FlowType ActiveFlowType { get; private set; }

        static public void SetDefaultFlowType()
        {
            ActiveFlowType = FlowType.Journey;
        }
        static public void UpdateFlow()
        {
            switch (ActiveFlowType)
            {
                case FlowType.Journey:
                    MyJourneyFlowUpdate();
                    break;

                case FlowType.NoFlow:
                    throw new System.Exception("Ez még nincs kész!");
                    
                default:
                    throw new System.Exception("Missing flow type!");
            }
        }

        static private void MyJourneyFlowUpdate()
        {
            Program.mainForm.FlowLayoutPanel.Controls.Clear();
            List<Journey> journeys = ActiveUserStore.ActiveUser.GetJourneys();

            List<JourneyControl> journeyControls = new List<JourneyControl>();

            foreach (Journey journey in journeys)
            {
                journeyControls.Add(new JourneyControl(journey));
                Program.mainForm.FlowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            }

            for (int i = 0; i < journeyControls.Count; i++)
            {
                JourneyControl control = journeyControls[i];
                control.Name = $"JourneyControl_{i}";
                control.SetContent();
                control.Visible = true;
                Program.mainForm.FlowLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                Program.mainForm.FlowLayoutPanel.Controls.Add(control, 0, i);
            }
        }

    }
}
