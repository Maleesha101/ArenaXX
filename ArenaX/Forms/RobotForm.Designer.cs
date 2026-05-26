namespace ArenaX.Forms
{
    partial class RobotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotForm));
            btnRegisterTeam = new Button();
            lblSub = new Label();
            lblTitle = new Label();
            flwRobotCard = new FlowLayoutPanel();
            panel2 = new Panel();
            roboIcon = new PictureBox();
            panel1 = new Panel();
            flwRobotCard.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roboIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterTeam
            // 
            btnRegisterTeam.BackColor = Color.FromArgb(134, 114, 255);
            btnRegisterTeam.FlatAppearance.BorderSize = 0;
            btnRegisterTeam.FlatStyle = FlatStyle.Flat;
            btnRegisterTeam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterTeam.ForeColor = SystemColors.ControlLightLight;
            btnRegisterTeam.Location = new Point(1225, 29);
            btnRegisterTeam.Name = "btnRegisterTeam";
            btnRegisterTeam.Size = new Size(191, 47);
            btnRegisterTeam.TabIndex = 11;
            btnRegisterTeam.Text = "Register robot";
            btnRegisterTeam.UseVisualStyleBackColor = false;
            btnRegisterTeam.Click += btnRegisterTeam_Click;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Dock = DockStyle.Top;
            lblSub.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSub.ForeColor = Color.FromArgb(125, 136, 161);
            lblSub.Location = new Point(0, 58);
            lblSub.Name = "lblSub";
            lblSub.Padding = new Padding(10, 0, 0, 0);
            lblSub.Size = new Size(325, 23);
            lblSub.TabIndex = 10;
            lblSub.Text = "Register and manage competitor robots";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(151, 129, 255);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 10, 0, 0);
            lblTitle.Size = new Size(118, 58);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Robots";
            // 
            // flwRobotCard
            // 
            flwRobotCard.BackColor = Color.FromArgb(7, 11, 34);
            flwRobotCard.Controls.Add(panel2);
            flwRobotCard.Location = new Point(36, 133);
            flwRobotCard.Name = "flwRobotCard";
            flwRobotCard.Size = new Size(1420, 485);
            flwRobotCard.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(roboIcon);
            panel2.Location = new Point(20, 20);
            panel2.Margin = new Padding(20);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 178);
            panel2.TabIndex = 0;
            // 
            // roboIcon
            // 
            roboIcon.Image = (Image)resources.GetObject("roboIcon.Image");
            roboIcon.Location = new Point(31, 28);
            roboIcon.Name = "roboIcon";
            roboIcon.Size = new Size(47, 51);
            roboIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            roboIcon.TabIndex = 0;
            roboIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 11, 34);
            panel1.Controls.Add(flwRobotCard);
            panel1.Controls.Add(btnRegisterTeam);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1491, 649);
            panel1.TabIndex = 13;
            // 
            // RobotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 6, 23);
            ClientSize = new Size(1491, 730);
            Controls.Add(panel1);
            Controls.Add(lblSub);
            Controls.Add(lblTitle);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RobotForm";
            Text = "RobotForm";
            flwRobotCard.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roboIcon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterTeam;
        private Label lblSub;
        private Label lblTitle;
        private FlowLayoutPanel flwRobotCard;
        private Panel panel1;
        private Panel panel2;
        private PictureBox roboIcon;
    }
}