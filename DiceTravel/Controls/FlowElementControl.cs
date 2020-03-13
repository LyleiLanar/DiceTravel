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
        protected Color originalColor;
        protected Color highlightedColor;

        public FlowElementControl()
        {
            highlightedColor = Color.SpringGreen;
            originalColor = Color.LightGreen;
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

        //public virtual void SetContent()
        //{
        //    ;
        //}
    }
}
