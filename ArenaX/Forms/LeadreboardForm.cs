using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArenaX.Forms
{
    public class LeaderboardEntry
    {
        public string RobotName { get; set; }
        public string TeamName { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int Points { get; set; }
    }

    public partial class LeadreboardForm : Form
    {
        public LeadreboardForm()
        {
            InitializeComponent();
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            flwLeaderboard.Controls.Clear();
            flwLeaderboard.FlowDirection = FlowDirection.TopDown;
            flwLeaderboard.WrapContents = false;
            flwLeaderboard.AutoScroll = true;

            List<LeaderboardEntry> entries = new List<LeaderboardEntry>
            {
                new LeaderboardEntry { RobotName = "ROBO", TeamName = "Test", Wins = 0, Draws = 1, Losses = 0, Points = 1 },
                new LeaderboardEntry { RobotName = "bot", TeamName = "team02", Wins = 0, Draws = 1, Losses = 0, Points = 1 },
                new LeaderboardEntry { RobotName = "Testing", TeamName = "TEst2", Wins = 0, Draws = 0, Losses = 0, Points = 0 }
            };

            int rank = 1;
            foreach (var entry in entries)
            {
                Panel rowPanel = new Panel();
                rowPanel.Size = new Size(1000, 70);
                rowPanel.BackColor = rank == 1 ? Color.FromArgb(17, 21, 46) : Color.FromArgb(10, 12, 30);
                rowPanel.Margin = new Padding(0, 0, 0, 10);
                
                rowPanel.Paint += (s, e) =>
                {
                    ControlPaint.DrawBorder(e.Graphics, rowPanel.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
                };

                // Rank
                Label lblRank = new Label();
                lblRank.Text = rank.ToString();
                lblRank.ForeColor = Color.FromArgb(0, 191, 255); // Light Blue
                lblRank.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                lblRank.AutoSize = true;
                lblRank.Location = new Point(30, 20);

                // Icon (Crown / Trophy)
                PictureBox pbIcon = new PictureBox();
                pbIcon.Size = new Size(30, 30);
                pbIcon.Location = new Point(70, 20);
                pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
                pbIcon.ImageLocation = rank == 1 ? "C:\\Users\\hp\\OneDrive - University of Kelaniya\\Desktop\\Projects\\ArenaX\\ArenaX\\Assets\\crown.png" : "C:\\Users\\hp\\OneDrive - University of Kelaniya\\Desktop\\Projects\\ArenaX\\ArenaX\\Assets\\trophy-score.png"; 
                pbIcon.BackColor = Color.Transparent;

                // Robot Name
                Label lblRobot = new Label();
                lblRobot.Text = entry.RobotName;
                lblRobot.ForeColor = Color.White;
                lblRobot.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblRobot.AutoSize = true;
                lblRobot.Location = new Point(120, 10);

                // Team Name
                Label lblTeam = new Label();
                lblTeam.Text = entry.TeamName;
                lblTeam.ForeColor = Color.FromArgb(127, 137, 163); // Grayish
                lblTeam.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblTeam.AutoSize = true;
                lblTeam.Location = new Point(125, 40);

                // Scores positioning
                int startX = 800;
                
                Label lblWins = new Label();
                lblWins.Text = $"{entry.Wins}W";
                lblWins.ForeColor = Color.FromArgb(0, 255, 127); // Green
                lblWins.Font = new Font("Consolas", 10, FontStyle.Bold);
                lblWins.AutoSize = true;
                lblWins.Location = new Point(startX, 25);

                Label lblDraws = new Label();
                lblDraws.Text = $"{entry.Draws}D";
                lblDraws.ForeColor = Color.FromArgb(255, 200, 0); // Yellow/Orange
                lblDraws.Font = new Font("Consolas", 10, FontStyle.Bold);
                lblDraws.AutoSize = true;
                lblDraws.Location = new Point(startX + 40, 25);

                Label lblLosses = new Label();
                lblLosses.Text = $"{entry.Losses}L";
                lblLosses.ForeColor = Color.FromArgb(255, 50, 50); // Red
                lblLosses.Font = new Font("Consolas", 10, FontStyle.Bold);
                lblLosses.AutoSize = true;
                lblLosses.Location = new Point(startX + 80, 25);

                Label lblPoints = new Label();
                lblPoints.Text = $"{entry.Points} pts";
                lblPoints.ForeColor = Color.FromArgb(0, 191, 255); // Light Blue
                lblPoints.Font = new Font("Consolas", 12, FontStyle.Bold);
                lblPoints.AutoSize = true;
                lblPoints.Location = new Point(startX + 130, 25);

                rowPanel.Controls.Add(lblRank);
                rowPanel.Controls.Add(pbIcon);
                rowPanel.Controls.Add(lblRobot);
                rowPanel.Controls.Add(lblTeam);
                rowPanel.Controls.Add(lblWins);
                rowPanel.Controls.Add(lblDraws);
                rowPanel.Controls.Add(lblLosses);
                rowPanel.Controls.Add(lblPoints);

                flwLeaderboard.Controls.Add(rowPanel);
                rank++;
            }
        }
    }
}
