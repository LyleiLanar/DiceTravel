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
        public FlowElementControl()
        {
            InitializeComponent();
        }

        protected virtual void FlowElementControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        protected virtual void FlowElementControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlLight;
        }
    }
}
