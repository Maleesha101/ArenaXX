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
    public partial class RobotForm : Form
    {
        // Define a simple class to hold robot data
        public class RobotData
        {
            public string Name { get; set; }
            public string TeamName { get; set; }
            public string Category { get; set; }
            public string Weight { get; set; }
            public string Description { get; set; }
            public Image Icon { get; set; }
        }

        List<RobotData> robots = new List<RobotData>
        {
            new RobotData { Name = "Testing", TeamName = "TEst2", Category = "featherweight", Weight = "1kg", Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" },
            new RobotData { Name = "Smasher", TeamName = "Alpha Squad", Category = "heavyweight", Weight = "10kg", Description = "A powerful robot designed for smashing." },
            new RobotData { Name = "Speedy", TeamName = "Beta Force", Category = "lightweight", Weight = "3kg", Description = "Very fast and agile robot." },
            new RobotData { Name = "Defender", TeamName = "Gamma Legion", Category = "middleweight", Weight = "5kg", Description = "Specializes in defense and durability." },


        };

        public RobotForm()
        {
            InitializeComponent();
            LoadRobots();
        }

        private void LoadRobots()
        {
            flwRobotCard.Controls.Clear(); // Clear the placeholder card

            foreach (var robot in robots)
            {
                Panel card = CreateRobotCard(robot);
                flwRobotCard.Controls.Add(card);
            }
        }

        private Panel CreateRobotCard(RobotData robot)
        {
            // Create the main panel based on the image layout
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(7, 11, 34);
            panel.Size = new Size(500, 200);
            panel.Margin = new Padding(20);

            // Custom border color
            panel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.FromArgb(51, 0, 72), ButtonBorderStyle.Solid);
            };

            // Image Placeholder Panel 
            Panel pnlImage = new Panel();
            pnlImage.BackColor = Color.FromArgb(7, 11, 34);
            pnlImage.Size = new Size(50, 50);
            pnlImage.Location = new Point(25, 25);


            string imagePath = @"C:\Users\hp\OneDrive - University of Kelaniya\Desktop\Projects\ArenaX\ArenaX\Assets\robotIcon.png";

            if (System.IO.File.Exists(imagePath))
            {
                Image icon = Image.FromFile(imagePath);
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.FromArgb(7, 11, 34);
                pictureBox.Image = icon;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Make sure the image scales to fit the space
                pictureBox.Height = 50;
                pictureBox.Width = 50;
                pictureBox.Location = new Point(0, 0); // Ensure it's positioned perfectly inside the panel
                pnlImage.Controls.Add(pictureBox);
            }

            panel.Controls.Add(pnlImage);

            // Robot Name Label
            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(130, 20);
            lblName.Text = robot.Name;
            panel.Controls.Add(lblName);

            // Team Name Label
            Label lblTeam = new Label();
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe UI", 9F);
            lblTeam.ForeColor = Color.FromArgb(151, 159, 181);
            lblTeam.Location = new Point(134, 60);
            lblTeam.Text = robot.TeamName;
            panel.Controls.Add(lblTeam);

            // Category Button/Badge
            Button btnCategory = new Button();
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.FlatAppearance.BorderSize = 1;
            btnCategory.FlatAppearance.BorderColor = Color.FromArgb(41, 46, 73);
            btnCategory.BackColor = Color.FromArgb(12, 17, 43);
            btnCategory.ForeColor = Color.White;
            btnCategory.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnCategory.Text = robot.Category;
            btnCategory.Size = new Size(TextRenderer.MeasureText(robot.Category, btnCategory.Font).Width + 20, 35);
            btnCategory.Location = new Point(134, 105);
            panel.Controls.Add(btnCategory);

            // Weight Button/Badge
            Button btnWeight = new Button();
            btnWeight.FlatStyle = FlatStyle.Flat;
            btnWeight.FlatAppearance.BorderSize = 0;
            btnWeight.BackColor = Color.FromArgb(31, 38, 76);
            btnWeight.ForeColor = Color.White;
            btnWeight.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnWeight.Text = robot.Weight;
            btnWeight.Size = new Size(TextRenderer.MeasureText(robot.Weight, btnWeight.Font).Width + 20, 35);
            btnWeight.Location = new Point(btnCategory.Right + 10, 105);

            panel.Controls.Add(btnWeight);

            // Description Label
            Label lblDesc = new Label();
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F);
            lblDesc.ForeColor = Color.FromArgb(125, 136, 161);
            lblDesc.Location = new Point(25, 155);
            lblDesc.Text = robot.Description;
            panel.Controls.Add(lblDesc);

            return panel;
        }

        private void btnRegisterTeam_Click(object sender, EventArgs e)
        {
            Form regiterTeam = new RegisterRobot();

            regiterTeam.ShowDialog();
        }
    }
}
