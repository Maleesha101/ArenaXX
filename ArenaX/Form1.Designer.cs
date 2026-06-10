namespace ArenaX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            slidePanel = new Panel();
            lblDivider = new Label();
            panel10 = new Panel();
            lblBottomDivider = new Label();
            pictureBox10 = new PictureBox();
            lblUserName = new Label();
            lblSignOut = new Label();
            tblSlideBar = new TableLayoutPanel();
            panel9 = new Panel();
            pictureBox9 = new PictureBox();
            btnBrackets = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            dashbaoardBtn = new Button();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            tournamentBtn = new Button();
            panel8 = new Panel();
            pictureBox8 = new PictureBox();
            btnLeaderboard = new Button();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            robotBtn = new Button();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            matchBtn = new Button();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            btnScoreEntry = new Button();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            teamBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            slidePanel.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            tblSlideBar.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // slidePanel
            // 
            slidePanel.BackColor = Color.FromArgb(2, 3, 18);
            slidePanel.Controls.Add(lblDivider);
            slidePanel.Controls.Add(panel10);
            slidePanel.Controls.Add(tblSlideBar);
            slidePanel.Controls.Add(panel1);
            slidePanel.Dock = DockStyle.Left;
            slidePanel.Location = new Point(0, 0);
            slidePanel.Name = "slidePanel";
            slidePanel.Size = new Size(302, 1035);
            slidePanel.TabIndex = 0;
            // 
            // lblDivider
            // 
            lblDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDivider.BackColor = Color.FromArgb(64, 64, 64);
            lblDivider.BorderStyle = BorderStyle.Fixed3D;
            lblDivider.Location = new Point(12, 77);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(287, 25);
            lblDivider.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(lblBottomDivider);
            panel10.Controls.Add(pictureBox10);
            panel10.Controls.Add(lblUserName);
            panel10.Controls.Add(lblSignOut);
            panel10.Location = new Point(0, 877);
            panel10.Name = "panel10";
            panel10.Size = new Size(299, 158);
            panel10.TabIndex = 2;
            // 
            // lblBottomDivider
            // 
            lblBottomDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBottomDivider.BackColor = Color.FromArgb(64, 64, 64);
            lblBottomDivider.BorderStyle = BorderStyle.Fixed3D;
            lblBottomDivider.Location = new Point(9, 18);
            lblBottomDivider.Name = "lblBottomDivider";
            lblBottomDivider.Size = new Size(287, 25);
            lblBottomDivider.TabIndex = 4;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(38, 107);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(25, 25);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 2;
            pictureBox10.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.LightGray;
            lblUserName.Location = new Point(38, 70);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(121, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Maleesha Indunil";
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignOut.ForeColor = Color.White;
            lblSignOut.Location = new Point(69, 107);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(83, 25);
            lblSignOut.TabIndex = 0;
            lblSignOut.Text = "Sign out";
            lblSignOut.Click += lblSignOut_Click;
            // 
            // tblSlideBar
            // 
            tblSlideBar.ColumnCount = 1;
            tblSlideBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSlideBar.Controls.Add(panel9, 0, 7);
            tblSlideBar.Controls.Add(panel2, 0, 0);
            tblSlideBar.Controls.Add(panel5, 0, 1);
            tblSlideBar.Controls.Add(panel8, 0, 6);
            tblSlideBar.Controls.Add(panel4, 0, 2);
            tblSlideBar.Controls.Add(panel6, 0, 3);
            tblSlideBar.Controls.Add(panel7, 0, 5);
            tblSlideBar.Controls.Add(panel3, 0, 4);
            tblSlideBar.Location = new Point(12, 100);
            tblSlideBar.Name = "tblSlideBar";
            tblSlideBar.RowCount = 8;
            tblSlideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblSlideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblSlideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblSlideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblSlideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblSlideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblSlideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblSlideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblSlideBar.Size = new Size(290, 639);
            tblSlideBar.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(2, 3, 18);
            panel9.Controls.Add(pictureBox9);
            panel9.Controls.Add(btnBrackets);
            panel9.Location = new Point(3, 556);
            panel9.Name = "panel9";
            panel9.Size = new Size(284, 57);
            panel9.TabIndex = 7;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(23, 15);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(23, 23);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // btnBrackets
            // 
            btnBrackets.BackColor = Color.FromArgb(2, 3, 18);
            btnBrackets.FlatAppearance.BorderSize = 0;
            btnBrackets.FlatStyle = FlatStyle.Flat;
            btnBrackets.ForeColor = Color.FromArgb(237, 242, 248);
            btnBrackets.ImageAlign = ContentAlignment.BottomRight;
            btnBrackets.Location = new Point(-3, 2);
            btnBrackets.Name = "btnBrackets";
            btnBrackets.Size = new Size(250, 46);
            btnBrackets.TabIndex = 1;
            btnBrackets.Text = "             Brackets";
            btnBrackets.TextAlign = ContentAlignment.MiddleLeft;
            btnBrackets.UseVisualStyleBackColor = false;
            btnBrackets.Click += btnBrackets_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 3, 18);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(dashbaoardBtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 57);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dashbaoardBtn
            // 
            dashbaoardBtn.BackColor = Color.FromArgb(2, 3, 18);
            dashbaoardBtn.FlatAppearance.BorderSize = 0;
            dashbaoardBtn.FlatStyle = FlatStyle.Flat;
            dashbaoardBtn.ForeColor = Color.FromArgb(237, 242, 248);
            dashbaoardBtn.ImageAlign = ContentAlignment.BottomRight;
            dashbaoardBtn.Location = new Point(-3, 2);
            dashbaoardBtn.Name = "dashbaoardBtn";
            dashbaoardBtn.Size = new Size(250, 46);
            dashbaoardBtn.TabIndex = 1;
            dashbaoardBtn.Text = "             Dashboard";
            dashbaoardBtn.TextAlign = ContentAlignment.MiddleLeft;
            dashbaoardBtn.UseVisualStyleBackColor = false;
            dashbaoardBtn.Click += dashbaoardBtn_Click;
            dashbaoardBtn.MouseLeave += dashbaoardBtn_MouseLeave;
            dashbaoardBtn.MouseHover += dashbaoardBtn_MouseHover;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(2, 3, 18);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(tournamentBtn);
            panel5.Location = new Point(3, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 57);
            panel5.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(23, 15);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // tournamentBtn
            // 
            tournamentBtn.BackColor = Color.FromArgb(2, 3, 18);
            tournamentBtn.FlatAppearance.BorderSize = 0;
            tournamentBtn.FlatStyle = FlatStyle.Flat;
            tournamentBtn.ForeColor = Color.FromArgb(237, 242, 248);
            tournamentBtn.ImageAlign = ContentAlignment.BottomRight;
            tournamentBtn.Location = new Point(-3, 2);
            tournamentBtn.Name = "tournamentBtn";
            tournamentBtn.Size = new Size(250, 46);
            tournamentBtn.TabIndex = 1;
            tournamentBtn.Text = "             Tournament";
            tournamentBtn.TextAlign = ContentAlignment.MiddleLeft;
            tournamentBtn.UseVisualStyleBackColor = false;
            tournamentBtn.Click += tournamentBtn_Click;
            tournamentBtn.MouseLeave += tournamentBtn_MouseLeave;
            tournamentBtn.MouseHover += tournamentBtn_MouseHover;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(2, 3, 18);
            panel8.Controls.Add(pictureBox8);
            panel8.Controls.Add(btnLeaderboard);
            panel8.Location = new Point(3, 477);
            panel8.Name = "panel8";
            panel8.Size = new Size(284, 57);
            panel8.TabIndex = 6;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(23, 15);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(23, 23);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.BackColor = Color.FromArgb(2, 3, 18);
            btnLeaderboard.FlatAppearance.BorderSize = 0;
            btnLeaderboard.FlatStyle = FlatStyle.Flat;
            btnLeaderboard.ForeColor = Color.FromArgb(237, 242, 248);
            btnLeaderboard.ImageAlign = ContentAlignment.BottomRight;
            btnLeaderboard.Location = new Point(-3, 2);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(250, 46);
            btnLeaderboard.TabIndex = 1;
            btnLeaderboard.Text = "             Leaderboard";
            btnLeaderboard.TextAlign = ContentAlignment.MiddleLeft;
            btnLeaderboard.UseVisualStyleBackColor = false;
            btnLeaderboard.Click += btnLeaderboard_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(2, 3, 18);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(robotBtn);
            panel4.Location = new Point(3, 161);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 57);
            panel4.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // robotBtn
            // 
            robotBtn.BackColor = Color.FromArgb(2, 3, 18);
            robotBtn.FlatAppearance.BorderSize = 0;
            robotBtn.FlatStyle = FlatStyle.Flat;
            robotBtn.ForeColor = Color.FromArgb(237, 242, 248);
            robotBtn.ImageAlign = ContentAlignment.BottomRight;
            robotBtn.Location = new Point(-3, 2);
            robotBtn.Name = "robotBtn";
            robotBtn.Size = new Size(250, 46);
            robotBtn.TabIndex = 1;
            robotBtn.Text = "             Robot";
            robotBtn.TextAlign = ContentAlignment.MiddleLeft;
            robotBtn.UseVisualStyleBackColor = false;
            robotBtn.Click += robotBtn_Click;
            robotBtn.MouseLeave += robotBtn_MouseLeave;
            robotBtn.MouseHover += robotBtn_MouseHover;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(2, 3, 18);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(matchBtn);
            panel6.Location = new Point(3, 240);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 57);
            panel6.TabIndex = 3;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(23, 15);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(23, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // matchBtn
            // 
            matchBtn.BackColor = Color.FromArgb(2, 3, 18);
            matchBtn.FlatAppearance.BorderSize = 0;
            matchBtn.FlatStyle = FlatStyle.Flat;
            matchBtn.ForeColor = Color.FromArgb(237, 242, 248);
            matchBtn.ImageAlign = ContentAlignment.BottomRight;
            matchBtn.Location = new Point(-3, 2);
            matchBtn.Name = "matchBtn";
            matchBtn.Size = new Size(250, 46);
            matchBtn.TabIndex = 1;
            matchBtn.Text = "             Match Control";
            matchBtn.TextAlign = ContentAlignment.MiddleLeft;
            matchBtn.UseVisualStyleBackColor = false;
            matchBtn.Click += matchBtn_Click;
            matchBtn.MouseLeave += matchBtn_MouseLeave;
            matchBtn.MouseHover += matchBtn_MouseHover;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(2, 3, 18);
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(btnScoreEntry);
            panel7.Location = new Point(3, 398);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 57);
            panel7.TabIndex = 5;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(23, 15);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(23, 23);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // btnScoreEntry
            // 
            btnScoreEntry.BackColor = Color.FromArgb(2, 3, 18);
            btnScoreEntry.FlatAppearance.BorderSize = 0;
            btnScoreEntry.FlatStyle = FlatStyle.Flat;
            btnScoreEntry.ForeColor = Color.FromArgb(237, 242, 248);
            btnScoreEntry.ImageAlign = ContentAlignment.BottomRight;
            btnScoreEntry.Location = new Point(-3, 2);
            btnScoreEntry.Name = "btnScoreEntry";
            btnScoreEntry.Size = new Size(250, 46);
            btnScoreEntry.TabIndex = 1;
            btnScoreEntry.Text = "             Score Entry";
            btnScoreEntry.TextAlign = ContentAlignment.MiddleLeft;
            btnScoreEntry.UseVisualStyleBackColor = false;
            btnScoreEntry.Click += btnScoreEntry_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(2, 3, 18);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(teamBtn);
            panel3.Location = new Point(3, 319);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 57);
            panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // teamBtn
            // 
            teamBtn.BackColor = Color.FromArgb(2, 3, 18);
            teamBtn.FlatAppearance.BorderSize = 0;
            teamBtn.FlatStyle = FlatStyle.Flat;
            teamBtn.ForeColor = Color.FromArgb(237, 242, 248);
            teamBtn.ImageAlign = ContentAlignment.BottomRight;
            teamBtn.Location = new Point(-3, 2);
            teamBtn.Name = "teamBtn";
            teamBtn.Size = new Size(250, 46);
            teamBtn.TabIndex = 1;
            teamBtn.Text = "             Team";
            teamBtn.TextAlign = ContentAlignment.MiddleLeft;
            teamBtn.UseVisualStyleBackColor = false;
            teamBtn.Click += teamBtn_Click;
            teamBtn.MouseLeave += teamBtn_MouseLeave;
            teamBtn.MouseHover += teamBtn_MouseHover;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 72);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 11, 34);
            ClientSize = new Size(1773, 1035);
            Controls.Add(slidePanel);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Coral;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            slidePanel.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            tblSlideBar.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel slidePanel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button dashbaoardBtn;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Button teamBtn;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Button matchBtn;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Button tournamentBtn;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Button robotBtn;
        private Panel panel7;
        private PictureBox pictureBox7;
        private Button btnScoreEntry;
        private Panel panel9;
        private PictureBox pictureBox9;
        private Button btnBrackets;
        private Panel panel8;
        private PictureBox pictureBox8;
        private Button btnLeaderboard;
        private Panel panel10;
        private Label lblSignOut;
        private TableLayoutPanel tblSlideBar;
        private PictureBox pictureBox10;
        private Label lblUserName;
        private Label lblDivider;
        private Label lblBottomDivider;
    }
}
