using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArenaX.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            panel1.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
            };
            panel2.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
            };
            panel3.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
            };
            panel4.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel4.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
            };
            panel5.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel5.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
            };
        }
    }
}
