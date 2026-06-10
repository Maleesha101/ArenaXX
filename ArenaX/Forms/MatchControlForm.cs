using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArenaX.Forms
{
    public partial class MatchControlForm : Form
    {

        private Panel currentMatchPanel;
        private System.Windows.Forms.Timer matchTimer;
        private int remainingSeconds;
        private Label lblTimerCountdown;
        private Button btnStatusBadge;
        private PictureBox btnPlayPause;
        private PictureBox btnStop;

        // Define a list of available robots
        private List<string> availableRobots = new List<string> { "ROBO", "bot", "Smasher", "Defender" };

        public MatchControlForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

        }
        private void InitializeCustomComponents()
        {
            // Setup Timer
            matchTimer = new System.Windows.Forms.Timer();
            matchTimer.Interval = 1000; // 1 second
            matchTimer.Tick += MatchTimer_Tick;

            // Fetch robots from the list
            string bot1 = availableRobots.Count > 0 ? availableRobots[0] : "Bot 1";
            string bot2 = availableRobots.Count > 1 ? availableRobots[1] : "Bot 2";

            // Create initial scheduled card
            CreateScheduledMatchCard(bot1, bot2);
        }

        private void CreateScheduledMatchCard(string bot1Name, string bot2Name)
        {
            currentMatchPanel = new Panel();
            currentMatchPanel.Size = new Size(1100, 60);
            currentMatchPanel.BackColor = Color.FromArgb(17, 21, 46);
            currentMatchPanel.Location = new Point(20, 20);
            currentMatchPanel.Padding = new Padding(10);

            currentMatchPanel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, currentMatchPanel.ClientRectangle, Color.FromArgb(41, 46, 73), ButtonBorderStyle.Solid);
            };


            // Match Info
            Label lblMatchNum = new Label { Text = "R1 #0", ForeColor = Color.FromArgb(127, 137, 163), Font = new Font("Consolas", 10), Location = new Point(20, 20), AutoSize = true };

            Label lblBot1 = new Label { Text = bot1Name, ForeColor = Color.White, Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(350, 18), AutoSize = true };
            Label lblScore = new Label { Text = "0 - 0", ForeColor = Color.White, BackColor = Color.FromArgb(12, 16, 41), Font = new Font("Consolas", 11, FontStyle.Bold), Location = new Point(460, 18), AutoSize = true };
            Label lblBot2 = new Label { Text = bot2Name, ForeColor = Color.White, Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(570, 18), AutoSize = true };

            // Timer Icon & Text
            Label lblTimerIcon = new Label { Text = "⏱", ForeColor = Color.FromArgb(127, 137, 163), Font = new Font("Segoe UI", 12), Location = new Point(800, 18), AutoSize = true };
            lblTimerCountdown = new Label { Text = "3:00", ForeColor = Color.White, Font = new Font("Consolas", 14), Location = new Point(830, 16), AutoSize = true };

            // Status Badge (Scheduled initially)
            btnStatusBadge = new Button();
            btnStatusBadge.Text = "scheduled";
            btnStatusBadge.FlatStyle = FlatStyle.Flat;
            btnStatusBadge.FlatAppearance.BorderSize = 0;
            btnStatusBadge.BackColor = Color.FromArgb(24, 28, 56);
            btnStatusBadge.ForeColor = Color.White;
            btnStatusBadge.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            btnStatusBadge.Size = new Size(80, 28);
            btnStatusBadge.Location = new Point(900, 16);

            // Play Button Image (Simulated with a colored panel for now since we don't have the icon path)
            btnPlayPause = new PictureBox();
            btnPlayPause.BackColor = Color.FromArgb(114, 98, 255);
            btnPlayPause.Size = new Size(35, 35);
            btnPlayPause.Location = new Point(1000, 12);
            btnPlayPause.Cursor = Cursors.Hand;
            btnPlayPause.Click += StartMatch_Click;
            // Optionally draw a play triangle inside
            btnPlayPause.Paint += (s, e) =>
            {
                if (btnPlayPause.Tag == null || btnPlayPause.Tag.ToString() == "Play")
                {
                    Point[] triangle = new Point[] { new Point(12, 10), new Point(12, 25), new Point(25, 17) };
                    e.Graphics.FillPolygon(Brushes.White, triangle);
                }
                else // Pause icon
                {
                    e.Graphics.FillRectangle(Brushes.White, 10, 10, 5, 15);
                    e.Graphics.FillRectangle(Brushes.White, 20, 10, 5, 15);
                }
            };

            currentMatchPanel.Controls.AddRange(new Control[] { lblMatchNum, lblBot1, lblScore, lblBot2, lblTimerIcon, lblTimerCountdown, btnStatusBadge, btnPlayPause });
            
      
            flwMatchCard.Controls.Add(currentMatchPanel);
        }

        private void StartMatch_Click(object sender, EventArgs e)
        {
            if (btnPlayPause.Tag == null || btnPlayPause.Tag.ToString() == "Play")
            {
                // Transition to In Progress
                remainingSeconds = 180; // 3 minutes
                lblTimerCountdown.ForeColor = Color.FromArgb(0, 212, 255); // Cyan color

                btnStatusBadge.Text = "in_progress";
                btnStatusBadge.BackColor = Color.FromArgb(114, 98, 255); // Purple
                btnStatusBadge.Size = new Size(90, 28);

                // Change Play to Pause
                btnPlayPause.Tag = "Pause";
                btnPlayPause.BackColor = Color.FromArgb(17, 21, 46);
                btnPlayPause.BorderStyle = BorderStyle.FixedSingle;
                btnPlayPause.Invalidate(); // Redraw icon

                // Add Stop button if not exists
                if (btnStop == null)
                {
                    btnStop = new PictureBox();
                    btnStop.BackColor = Color.FromArgb(255, 15, 63); // Red
                    btnStop.Size = new Size(35, 35);
                    btnStop.Location = new Point(1045, 12);
                    btnStop.Cursor = Cursors.Hand;
                    btnStop.Click += StopMatch_Click;
                    btnStop.Paint += (s, pe) =>
                    {
                        pe.Graphics.DrawRectangle(new Pen(Color.White, 2), 12, 12, 11, 11);
                    };
                    currentMatchPanel.Controls.Add(btnStop);
                }
                btnStop.Visible = true;

                matchTimer.Start();
            }
            else
            {
                // Pause logic
                matchTimer.Stop();
                btnPlayPause.Tag = "Play";
                btnPlayPause.BackColor = Color.FromArgb(114, 98, 255);
                btnPlayPause.BorderStyle = BorderStyle.None;
                btnPlayPause.Invalidate();
            }
        }

        private void StopMatch_Click(object sender, EventArgs e)
        {
            // Cancel / Complete logic
            matchTimer.Stop();
            lblTimerCountdown.ForeColor = Color.White;

            btnStatusBadge.Text = "completed";
            btnStatusBadge.BackColor = Color.FromArgb(24, 28, 56);
            btnStatusBadge.ForeColor = Color.White;

            btnPlayPause.Visible = false;
            btnStop.Visible = false;
        }

        private void MatchTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
                lblTimerCountdown.Text = string.Format("{0}:{1:D2}", time.Minutes, time.Seconds);
            }
            else
            {
                StopMatch_Click(this, EventArgs.Empty);
            }
        }
    }
}
