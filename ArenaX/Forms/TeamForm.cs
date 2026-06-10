using ArenaX.Forms.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArenaX.Forms
{
    public partial class TeamForm : Form
    {

        Form newTeam = new AddTeamForm();
        public class TeamData
        {
            public string Name { get; set; }
            public string CaptainName { get; set; }
            public string Email { get; set; }
            public string Description { get; set; }
        }

        List<TeamData> teams = new List<TeamData>
        {
            new TeamData { Name = "Alpha Squad", CaptainName = "John Doe", Email = "john@alpha.com", Description = "Balanced overall play style." },
            new TeamData { Name = "Beta Force", CaptainName = "Jane Smith", Email = "jane@beta.org", Description = "Aggressive attackers." },
            new TeamData { Name = "Gamma Legion", CaptainName = "Mike Johnson", Email = "mike@gamma.net", Description = "Defensive specialists." },
            new TeamData { Name = "Alpha Squad", CaptainName = "John Doe", Email = "john@alpha.com", Description = "Balanced overall play style." },
        };

        public TeamForm()
        {
            InitializeComponent();
            btnStatus.Visible = false;
            LoadTeams();
        }

        private void LoadTeams()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            flowLayoutPanel1.Controls.Clear(); // Clear the placeholder card

            foreach (var team in teams)
            {
                Panel card = CreateTeamCard(team);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private Panel CreateTeamCard(TeamData team)
        {
            // Create the main panel
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(8, 12, 37);
            panel.BorderStyle = BorderStyle.None; // Set to none to draw custom border
            panel.Size = new Size(516, 261);
            panel.Margin = new Padding(20);

            // Custom border color
            
            panel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
            };

            // Team Name Label
            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(24, 17);
            lblName.Text = team.Name;
            panel.Controls.Add(lblName);

            // Captain Label Header
            Label lblCapHeader = new Label();
            lblCapHeader.AutoSize = true;
            lblCapHeader.ForeColor = Color.White;
            lblCapHeader.Location = new Point(33, 59);
            lblCapHeader.Text = "Captain:";
            panel.Controls.Add(lblCapHeader);

            // Captain Name Value Label
            Label lblCapName = new Label();
            lblCapName.AutoSize = true;
            lblCapName.ForeColor = Color.WhiteSmoke;
            lblCapName.Location = new Point(103, 59);
            lblCapName.Text = team.CaptainName;
            panel.Controls.Add(lblCapName);

            // Email Label
            Label lblTeamEmail = new Label();
            lblTeamEmail.AutoSize = true;
            lblTeamEmail.ForeColor = Color.White;
            lblTeamEmail.Location = new Point(33, 92);
            lblTeamEmail.Text = team.Email;
            panel.Controls.Add(lblTeamEmail);

            // Description Label
            Label lblDesc = new Label();
            lblDesc.AutoSize = true;
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(33, 124);
            lblDesc.Text = team.Description;
            panel.Controls.Add(lblDesc);

            // Status Button (Hidden by default)
            Button btnTeamStatus = new Button();
            btnTeamStatus.BackColor = Color.Black;
            btnTeamStatus.FlatAppearance.BorderSize = 0;
            btnTeamStatus.FlatStyle = FlatStyle.Flat;
            btnTeamStatus.ForeColor = Color.White;
            btnTeamStatus.Location = new Point(390, 19);
            btnTeamStatus.Size = new Size(94, 29);
            btnTeamStatus.Visible = false;
            panel.Controls.Add(btnTeamStatus);

            // Approve Button
            Button btnApproveTeam = new Button();
            Button btnRejectTeam = new Button();

            btnApproveTeam.BackColor = Color.FromArgb(0, 183, 100);
            btnApproveTeam.FlatAppearance.BorderSize = 0;
            btnApproveTeam.FlatStyle = FlatStyle.Flat;
            btnApproveTeam.ForeColor = Color.White;
            btnApproveTeam.Location = new Point(24, 195);
            btnApproveTeam.Size = new Size(134, 41);
            btnApproveTeam.Text = "Approve";
            btnApproveTeam.Click += (s, e) =>
            {

                btnApproveTeam.Visible = false;
                btnRejectTeam.Visible = false;
                btnTeamStatus.Visible = true;
                btnTeamStatus.Text = "Approved";
                btnTeamStatus.BackColor = Color.FromArgb(114, 102, 255);
            };
            panel.Controls.Add(btnApproveTeam);

            // Reject Button
            btnRejectTeam.BackColor = Color.FromArgb(3, 6, 23);
            btnRejectTeam.FlatAppearance.BorderColor = Color.DimGray;
            btnRejectTeam.FlatStyle = FlatStyle.Flat;
            btnRejectTeam.ForeColor = Color.White;
            btnRejectTeam.Location = new Point(172, 195);
            btnRejectTeam.Size = new Size(134, 41);
            btnRejectTeam.Text = "Reject";
            btnRejectTeam.Click += (s, e) =>
            {
                btnApproveTeam.Visible = false;
                btnRejectTeam.Visible = false;
                btnTeamStatus.Visible = true;
                btnTeamStatus.Text = "Rejected";
                btnTeamStatus.BackColor = Color.FromArgb(249, 5, 43);
            };
            panel.Controls.Add(btnRejectTeam);

            return panel;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddTeam_Click(object sender, EventArgs e) {

            newTeam.ShowDialog();

        }
    }
}
