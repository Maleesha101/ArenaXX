using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArenaX.Forms
{
    public partial class ScoreEntryForm : Form
    {
        public class MatchScoreData
        {
            public string MatchId { get; set; }
            public string Bot1Name { get; set; }
            public string Bot2Name { get; set; }
        }

        private List<MatchScoreData> recentMatches = new List<MatchScoreData>
        {
            new MatchScoreData { MatchId = "R1 • #0", Bot1Name = "bot", Bot2Name = "ROBO" }
        };

        public ScoreEntryForm()
        {
            InitializeComponent();
            LoadScorePanels();
        }

        private void LoadScorePanels()
        {
            flxScoreEntry.Controls.Clear();
            
            foreach (var match in recentMatches)
            {
                Panel card = CreateScoreEntryCard(match);
                flxScoreEntry.Controls.Add(card);
            }
        }

        private Panel CreateScoreEntryCard(MatchScoreData match)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(7, 11, 34);
            panel.Size = new Size(600, 390);
            panel.Margin = new Padding(20);

            // Custom border color
            panel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
            };

            // Match Title 
            Label lblMatchNum = new Label();
            lblMatchNum.AutoSize = true;
            lblMatchNum.Font = new Font("Consolas", 10F, FontStyle.Regular);
            lblMatchNum.ForeColor = Color.FromArgb(127, 137, 163);
            lblMatchNum.Location = new Point(20, 20);
            lblMatchNum.Text = match.MatchId;
            panel.Controls.Add(lblMatchNum);

            // Bot 1 Label & Score 
            Label lblBot1 = new Label { 
                Text = $"{match.Bot1Name} score",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(20, 60),
                AutoSize = true };

            TextBox txtBot1Score = new TextBox {
                Text = "0", BackColor = Color.FromArgb(3, 6, 23),
                ForeColor = Color.White, Font = new Font("Segoe UI", 12),
                Location = new Point(20, 90), Size = new Size(270, 35),
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle };

            panel.Controls.Add(lblBot1);
            panel.Controls.Add(txtBot1Score);

            // Bot 2 Label & Score 
            Label lblBot2 = new Label { 
                Text = $"{match.Bot2Name} score",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(310, 60), AutoSize = true };

            TextBox txtBot2Score = new TextBox {
                Text = "0", BackColor = Color.FromArgb(3, 6, 23),
                ForeColor = Color.White, Font = new Font("Segoe UI", 12),
                Location = new Point(310, 90),
                Size = new Size(270, 35),
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle };

            panel.Controls.Add(lblBot2);
            panel.Controls.Add(txtBot2Score);

            // Penalty A Label & NumericUpDown
            Label lblPenaltyA = new Label {
                Text = "Penalty A", ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(20, 140),
                AutoSize = true };

            NumericUpDown numPenaltyA = new NumericUpDown {
                Value = 1,
                BackColor = Color.FromArgb(3, 6, 23),
                ForeColor = Color.White, Font = new Font("Segoe UI", 12),
                Location = new Point(20, 170), Size = new Size(270, 35),
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle };

            panel.Controls.Add(lblPenaltyA);
            panel.Controls.Add(numPenaltyA);

            // Penalty B Label & TextBox (Or NumericUpDown)
            Label lblPenaltyB = new Label { 
                Text = "Penalty B", ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(310, 140),
                AutoSize = true };

            NumericUpDown numPenaltyB = new NumericUpDown { Value = 0,
                BackColor = Color.FromArgb(3, 6, 23),
                ForeColor = Color.White, Font = new Font("Segoe UI", 12),
                Location = new Point(310, 170), Size = new Size(270, 35),
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle };

            panel.Controls.Add(lblPenaltyB);
            panel.Controls.Add(numPenaltyB);

            // Notes TextBox
            TextBox txtNotes = new TextBox {
                PlaceholderText = "Notes (optional)",
                BackColor = Color.FromArgb(3, 6, 23),
                ForeColor = Color.White, Font = new Font("Segoe UI", 12),
                Location = new Point(20, 221),
                Size = new Size(560, 35),
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle };

            panel.Controls.Add(txtNotes);

            // Submit Button
            Button btnSubmit = new Button {
                Text = "Submit score",
                BackColor = Color.FromArgb(130, 111, 255),
                ForeColor = Color.White, Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(20, 310),
                Size = new Size(560, 40),
                FlatStyle = FlatStyle.Flat };


            btnSubmit.FlatAppearance.BorderSize = 0;
            panel.Controls.Add(btnSubmit);

            // Apply focus 
            numPenaltyA.Enter += (s, e) => { numPenaltyA.BackColor = Color.FromArgb(10, 12, 35); };
            numPenaltyA.Leave += (s, e) => { numPenaltyA.BackColor = Color.FromArgb(3, 6, 23); };

            return panel;
        }
    }
}
