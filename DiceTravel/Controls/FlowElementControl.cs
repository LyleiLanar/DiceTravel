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
        protected System.Drawing.Color originalColor;
        protected System.Drawing.Color highlightedColor;

        public FlowElementControl()
        {
            highlightedColor = SystemColors.ControlLight;
            originalColor = SystemColors.Control;
            InitializeComponent();
        }

        protected virtual void FlowElementControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = originalColor;
        }

        protected virtual void FlowElementControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = highlightedColor;
        }
    }
}
