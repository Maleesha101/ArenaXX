using ArenaX.Forms;
using System.Security.Cryptography;
using System.Security.Policy;

namespace ArenaX
{


    public partial class Form1 : Form
    {

        Form dashboard = new DashboardForm();
        Form team = new TeamForm();
        Form robot = new RobotForm();
        Form tournament = new TournamentsForm();
        Form match = new MatchControlForm();
        Form score = new ScoreEntryForm();
        Form leaderborad = new LeadreboardForm();
        Form brackets = new BracketsForm();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dashboard.Dock = DockStyle.Fill;
            dashboard.TopLevel = false;
            dashboard.BringToFront();
            dashboard.Show();
            lblDivider.Height = 2;
            lblBottomDivider.Height = 1;
            lblBottomDivider.BackColor = Color.Gray;
        }
        public void onclick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Reset all button backgrounds
                dashbaoardBtn.BackColor = Color.FromArgb(2, 3, 18);
                teamBtn.BackColor = Color.FromArgb(2, 3, 18);
                robotBtn.BackColor = Color.FromArgb(2, 3, 18);
                tournamentBtn.BackColor = Color.FromArgb(2, 3, 18);
                matchBtn.BackColor = Color.FromArgb(2, 3, 18);
                btnBrackets.BackColor = Color.FromArgb(2, 3, 18);
                btnLeaderboard.BackColor = Color.FromArgb(2, 3, 18);
                btnScoreEntry.BackColor = Color.FromArgb(2, 3, 18);

                // Set active button background
                button.BackColor = Color.FromArgb(16, 19, 44);

                string buttonName = button.Name;
                switch (buttonName)
                {
                    case "dashbaoardBtn":
                        openChildForm(dashboard);
                        break;
                    case "robotBtn":
                        openChildForm(robot);
                        break;
                    case "teamBtn":
                        openChildForm(team);
                        break;
                    case "tournamentBtn":
                        openChildForm(tournament);
                        break;
                    case "matchBtn":
                        openChildForm(match);
                        break;
                    case "btnScoreEntry":
                        openChildForm(score);
                        break;
                    case "btnLeaderboard":
                        openChildForm(leaderborad);
                        break;
                    case "btnBrackets":
                        openChildForm(brackets);
                        break;

                    default:
                        break;
                }
            }

        }


        public void openChildForm(Form childForm)
        {
            // First remove any existing child forms attached to the main form (excluding the slidePanel)
            if (this.Tag != null && this.Tag is Form)
            {
                Form currentOpenForm = (Form)this.Tag;
                if (currentOpenForm != childForm)
                {
                    this.Controls.Remove(currentOpenForm);
                }
            }

            if (this.Tag != childForm)
            {
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;
                this.Controls.Add(childForm);
                this.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                childForm.BringToFront();
            }
        }

        private void dashbaoardBtn_Click(object sender, EventArgs e)
        {
            onclick(sender, e);
        }

        private void teamBtn_Click(object sender, EventArgs e)
        {
            onclick(sender, e);
        }

        private void robotBtn_Click(object sender, EventArgs e)
        {
            onclick(sender, e);
        }

        private void tournamentBtn_Click(object sender, EventArgs e)
        {
            onclick(sender, e);
        }

        private void matchBtn_Click(object sender, EventArgs e)
        {
            onclick(sender, e);
        }

        private void btnScoreEntry_Click(object sender, EventArgs e)
        {
            onclick(sender, e);
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            onclick(sender, e);
        }

        private void btnBrackets_Click(object sender, EventArgs e)
        {
            onclick(sender, e);
        }
        private void dashbaoardBtn_MouseHover(object sender, EventArgs e)
        {
            dashbaoardBtn.BackColor = Color.FromArgb(9, 11, 31);
        }

        private void teamBtn_MouseHover(object sender, EventArgs e)
        {
            teamBtn.BackColor = Color.FromArgb(9, 11, 31);
        }

        private void robotBtn_MouseHover(object sender, EventArgs e)
        {
            robotBtn.BackColor = Color.FromArgb(9, 11, 31);
        }

        private void tournamentBtn_MouseHover(object sender, EventArgs e)
        {
            tournamentBtn.BackColor = Color.FromArgb(9, 11, 31);
        }

        private void matchBtn_MouseHover(object sender, EventArgs e)
        {
            matchBtn.BackColor = Color.FromArgb(9, 11, 31);
        }

        private void dashbaoardBtn_MouseLeave(object sender, EventArgs e)
        {
            if (dashbaoardBtn.BackColor != Color.FromArgb(16, 19, 44))
            {
                dashbaoardBtn.BackColor = Color.FromArgb(2, 3, 18);
            }
        }

        private void teamBtn_MouseLeave(object sender, EventArgs e)
        {
            if (teamBtn.BackColor != Color.FromArgb(16, 19, 44))
            {
                teamBtn.BackColor = Color.FromArgb(2, 3, 18);
            }
        }

        private void robotBtn_MouseLeave(object sender, EventArgs e)
        {
            if (robotBtn.BackColor != Color.FromArgb(16, 19, 44))
            {
                robotBtn.BackColor = Color.FromArgb(2, 3, 18);
            }
        }

        private void tournamentBtn_MouseLeave(object sender, EventArgs e)
        {
            if (tournamentBtn.BackColor != Color.FromArgb(16, 19, 44))
            {
                tournamentBtn.BackColor = Color.FromArgb(2, 3, 18);
            }
        }

        private void matchBtn_MouseLeave(object sender, EventArgs e)
        {
            if (matchBtn.BackColor != Color.FromArgb(16, 19, 44))
            {
                matchBtn.BackColor = Color.FromArgb(2, 3, 18);
            }
        }

        private void btnScoreEntry_MouseHover(object sender, EventArgs e)
        {
            btnScoreEntry.BackColor = Color.FromArgb(9, 11, 31);
        }
        private void btnScoreEntry_MouseLeave(object sender, EventArgs e)
        {
            if (btnScoreEntry.BackColor != Color.FromArgb(16, 19, 44))
            {
                btnScoreEntry.BackColor = Color.FromArgb(2, 3, 18);
            }
        }
        private void btnLeaderboard_MouseHover(object sender, EventArgs e)
        {
            btnLeaderboard.BackColor = Color.FromArgb(9, 11, 31);
        }
        private void btnLeaderboard_MouseLeave(object sender, EventArgs e)
        {
            if (btnLeaderboard.BackColor != Color.FromArgb(16, 19, 44))
            {
                btnLeaderboard.BackColor = Color.FromArgb(2, 3, 18);
            }
        }
        private void btnBrackets_MouseHover(object sender, EventArgs e)
        {
            btnBrackets.BackColor = Color.FromArgb(9, 11, 31);
        }
        private void btnBrackets_MouseLeave(object sender, EventArgs e)
        {
            if (btnBrackets.BackColor != Color.FromArgb(16, 19, 44))
            {
                btnBrackets.BackColor = Color.FromArgb(2, 3, 18);
            }
        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {

        }
    }
}
