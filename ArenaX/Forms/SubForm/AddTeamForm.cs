using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArenaX.Forms.SubForm
{
    public partial class AddTeamForm : Form
    {
        FocusBoarder focusBoarder = new FocusBoarder();
        public AddTeamForm()
        {
            InitializeComponent();
            AttachFocusEvents();
        }

        private void AttachFocusEvents()
        {
           
            this.Paint += AddTeamForm_Paint;

            tbxName.Enter += TextBox_StateChange;
            tbxName.Leave += TextBox_StateChange;
            
            tbxCaptain.Enter += TextBox_StateChange;
            tbxCaptain.Leave += TextBox_StateChange;
            
            tbxContact.Enter += TextBox_StateChange;
            tbxContact.Leave += TextBox_StateChange;
            
            tbxDescription.Enter += TextBox_StateChange;
            tbxDescription.Leave += TextBox_StateChange;
        }

        private void TextBox_StateChange(object sender, EventArgs e)
        {
      
            this.Invalidate();
        }

        private void AddTeamForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            focusBoarder.DrawTextBoxBorder(g, tbxName);
            focusBoarder.DrawTextBoxBorder(g, tbxCaptain);
            focusBoarder.DrawTextBoxBorder(g, tbxContact);
            focusBoarder.DrawTextBoxBorder(g, tbxDescription);
        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxName_MouseClick(object sender, MouseEventArgs e)
        {
            tbxName.Focus();

        }

        private void tbxCaptain_MouseClick(object sender, MouseEventArgs e)
        {

        }

    }
}
