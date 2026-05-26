using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaX.Forms.SubForm
{
    internal class FocusBoarder
    {

        private Color defaultBorderColor = Color.FromArgb(41, 46, 73);
        private Color focusedBorderColor = Color.FromArgb(114, 102, 255);

        public void DrawTextBoxBorder(Graphics g, TextBox txt)
        {
            Color borderColor = txt.Focused ? focusedBorderColor : defaultBorderColor;


            using (Pen pen = new Pen(borderColor, 1))
            {
                Rectangle rect = new Rectangle(
                    txt.Location.X - 1,
                    txt.Location.Y - 1,
                    txt.Width + 1,
                    txt.Height + 1);

                g.DrawRectangle(pen, rect);
            }
        }

        public void DrawComboBoxBorder(Graphics g, ComboBox cbx)
        {
            Color borderColor = cbx.Focused ? focusedBorderColor : defaultBorderColor;

            using (Pen pen = new Pen(borderColor, 1))
            {
                Rectangle rect = new Rectangle(
                    cbx.Location.X - 1,
                    cbx.Location.Y - 1,
                    cbx.Width + 1,
                    cbx.Height + 1);

                g.DrawRectangle(pen, rect);
            }
        }
    }

}
