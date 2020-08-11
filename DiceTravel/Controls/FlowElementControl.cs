using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceTravel.Controls
{
    public partial class FlowElementControl : UserControl
    {
        protected virtual Color OriginalColor { get; set; }
        protected virtual Color HighlightedColor { get; set; }

        public FlowElementControl()
        {
            HighlightedColor = SystemColors.Control;
            OriginalColor = SystemColors.ControlLight;
            InitializeComponent();
        }

        protected virtual void FlowElementControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = OriginalColor;
        }

        protected virtual void FlowElementControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = HighlightedColor;
        }
    }
}
