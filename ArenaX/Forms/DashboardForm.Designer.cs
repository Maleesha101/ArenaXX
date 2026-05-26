namespace ArenaX.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            lblTitle = new Label();
            lblSub = new Label();
            tblTop = new TableLayoutPanel();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnRunMatch = new Button();
            btnManageTeam = new Button();
            panel6 = new Panel();
            tblQuickAction = new TableLayoutPanel();
            btnQcViewBracket = new Button();
            btnQcCreateTournament = new Button();
            btnQcRegRobot = new Button();
            btnQcAddTeam = new Button();
            label11 = new Label();
            tblTop.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            tblQuickAction.SuspendLayout();
            SuspendLayout();
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
            lblTitle.Size = new Size(233, 58);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mission Control";
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
            lblSub.Size = new Size(260, 23);
            lblSub.TabIndex = 1;
            lblSub.Text = "Real-time tournament overview";
            // 
            // tblTop
            // 
            tblTop.AutoSize = true;
            tblTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblTop.ColumnCount = 5;
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTop.Controls.Add(panel5, 4, 0);
            tblTop.Controls.Add(panel4, 3, 0);
            tblTop.Controls.Add(panel3, 2, 0);
            tblTop.Controls.Add(panel2, 1, 0);
            tblTop.Controls.Add(panel1, 0, 0);
            tblTop.Location = new Point(44, 106);
            tblTop.Name = "tblTop";
            tblTop.Padding = new Padding(0, 0, 10, 0);
            tblTop.RowCount = 1;
            tblTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTop.Size = new Size(1270, 129);
            tblTop.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(10, 14, 41);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(1011, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 123);
            panel5.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(160, 43);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(74, 128, 195);
            label9.Location = new Point(39, 43);
            label9.Name = "label9";
            label9.Size = new Size(50, 59);
            label9.TabIndex = 1;
            label9.Text = "2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(39, 18);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 0;
            label10.Text = "Teams";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(10, 14, 41);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(759, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 123);
            panel4.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(160, 43);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(74, 128, 195);
            label7.Location = new Point(39, 43);
            label7.Name = "label7";
            label7.Size = new Size(50, 59);
            label7.TabIndex = 1;
            label7.Text = "2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(39, 18);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 0;
            label8.Text = "Teams";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(10, 14, 41);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(507, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 123);
            panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(160, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(74, 128, 195);
            label5.Location = new Point(39, 43);
            label5.Name = "label5";
            label5.Size = new Size(50, 59);
            label5.TabIndex = 1;
            label5.Text = "2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(39, 18);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 0;
            label6.Text = "Teams";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(10, 14, 41);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(255, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 123);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(160, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(74, 128, 195);
            label3.Location = new Point(39, 43);
            label3.Name = "label3";
            label3.Size = new Size(50, 59);
            label3.TabIndex = 1;
            label3.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(39, 18);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 0;
            label4.Text = "Teams";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 14, 41);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(3, 3, 13, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 123);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(74, 128, 195);
            label2.Location = new Point(39, 43);
            label2.Name = "label2";
            label2.Size = new Size(50, 59);
            label2.TabIndex = 1;
            label2.Text = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(39, 18);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Teams";
            // 
            // btnRunMatch
            // 
            btnRunMatch.BackColor = Color.FromArgb(134, 114, 255);
            btnRunMatch.FlatAppearance.BorderSize = 0;
            btnRunMatch.FlatStyle = FlatStyle.Flat;
            btnRunMatch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRunMatch.ForeColor = SystemColors.ControlLightLight;
            btnRunMatch.Location = new Point(1153, 44);
            btnRunMatch.Name = "btnRunMatch";
            btnRunMatch.Size = new Size(136, 45);
            btnRunMatch.TabIndex = 4;
            btnRunMatch.Text = "Run Matches";
            btnRunMatch.UseVisualStyleBackColor = false;
            // 
            // btnManageTeam
            // 
            btnManageTeam.BackColor = Color.FromArgb(3, 6, 23);
            btnManageTeam.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnManageTeam.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 195, 201);
            btnManageTeam.FlatStyle = FlatStyle.Flat;
            btnManageTeam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageTeam.ForeColor = Color.White;
            btnManageTeam.Location = new Point(999, 46);
            btnManageTeam.Name = "btnManageTeam";
            btnManageTeam.Size = new Size(136, 45);
            btnManageTeam.TabIndex = 5;
            btnManageTeam.Text = "Manage Teams";
            btnManageTeam.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 11, 34);
            panel6.Controls.Add(tblQuickAction);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(44, 261);
            panel6.Name = "panel6";
            panel6.Size = new Size(1245, 228);
            panel6.TabIndex = 6;
            // 
            // tblQuickAction
            // 
            tblQuickAction.ColumnCount = 4;
            tblQuickAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblQuickAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblQuickAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblQuickAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblQuickAction.Controls.Add(btnQcViewBracket, 3, 0);
            tblQuickAction.Controls.Add(btnQcCreateTournament, 2, 0);
            tblQuickAction.Controls.Add(btnQcRegRobot, 1, 0);
            tblQuickAction.Controls.Add(btnQcAddTeam, 0, 0);
            tblQuickAction.Location = new Point(27, 90);
            tblQuickAction.Name = "tblQuickAction";
            tblQuickAction.RowCount = 1;
            tblQuickAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblQuickAction.Size = new Size(1192, 59);
            tblQuickAction.TabIndex = 1;
            // 
            // btnQcViewBracket
            // 
            btnQcViewBracket.BackColor = Color.FromArgb(7, 11, 34);
            btnQcViewBracket.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnQcViewBracket.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 23, 56);
            btnQcViewBracket.FlatStyle = FlatStyle.Flat;
            btnQcViewBracket.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQcViewBracket.ForeColor = Color.White;
            btnQcViewBracket.Location = new Point(897, 3);
            btnQcViewBracket.Name = "btnQcViewBracket";
            btnQcViewBracket.Padding = new Padding(10, 0, 0, 0);
            btnQcViewBracket.Size = new Size(251, 53);
            btnQcViewBracket.TabIndex = 4;
            btnQcViewBracket.Text = "Vie bracket";
            btnQcViewBracket.TextAlign = ContentAlignment.MiddleLeft;
            btnQcViewBracket.UseVisualStyleBackColor = false;
            // 
            // btnQcCreateTournament
            // 
            btnQcCreateTournament.BackColor = Color.FromArgb(7, 11, 34);
            btnQcCreateTournament.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnQcCreateTournament.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 23, 56);
            btnQcCreateTournament.FlatStyle = FlatStyle.Flat;
            btnQcCreateTournament.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQcCreateTournament.ForeColor = Color.White;
            btnQcCreateTournament.Location = new Point(599, 3);
            btnQcCreateTournament.Name = "btnQcCreateTournament";
            btnQcCreateTournament.Padding = new Padding(10, 0, 0, 0);
            btnQcCreateTournament.Size = new Size(251, 53);
            btnQcCreateTournament.TabIndex = 3;
            btnQcCreateTournament.Text = "Create tournament";
            btnQcCreateTournament.TextAlign = ContentAlignment.MiddleLeft;
            btnQcCreateTournament.UseVisualStyleBackColor = false;
            // 
            // btnQcRegRobot
            // 
            btnQcRegRobot.BackColor = Color.FromArgb(7, 11, 34);
            btnQcRegRobot.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnQcRegRobot.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 23, 56);
            btnQcRegRobot.FlatStyle = FlatStyle.Flat;
            btnQcRegRobot.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQcRegRobot.ForeColor = Color.White;
            btnQcRegRobot.Location = new Point(301, 3);
            btnQcRegRobot.Name = "btnQcRegRobot";
            btnQcRegRobot.Padding = new Padding(10, 0, 0, 0);
            btnQcRegRobot.Size = new Size(251, 53);
            btnQcRegRobot.TabIndex = 2;
            btnQcRegRobot.Text = "Register robot";
            btnQcRegRobot.TextAlign = ContentAlignment.MiddleLeft;
            btnQcRegRobot.UseVisualStyleBackColor = false;
            // 
            // btnQcAddTeam
            // 
            btnQcAddTeam.BackColor = Color.FromArgb(7, 11, 34);
            btnQcAddTeam.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnQcAddTeam.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 23, 56);
            btnQcAddTeam.FlatStyle = FlatStyle.Flat;
            btnQcAddTeam.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQcAddTeam.ForeColor = Color.White;
            btnQcAddTeam.Location = new Point(3, 3);
            btnQcAddTeam.Name = "btnQcAddTeam";
            btnQcAddTeam.Padding = new Padding(10, 0, 0, 0);
            btnQcAddTeam.Size = new Size(251, 53);
            btnQcAddTeam.TabIndex = 1;
            btnQcAddTeam.Text = "Add Team";
            btnQcAddTeam.TextAlign = ContentAlignment.MiddleLeft;
            btnQcAddTeam.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(27, 21);
            label11.Name = "label11";
            label11.Size = new Size(141, 34);
            label11.TabIndex = 0;
            label11.Text = "Quick actions";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 6, 23);
            ClientSize = new Size(1320, 523);
            ControlBox = false;
            Controls.Add(panel6);
            Controls.Add(btnManageTeam);
            Controls.Add(btnRunMatch);
            Controls.Add(tblTop);
            Controls.Add(lblSub);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            tblTop.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tblQuickAction.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSub;
        private TableLayoutPanel tblTop;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label9;
        private Label label10;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnRunMatch;
        private Button btnManageTeam;
        private Panel panel6;
        private TableLayoutPanel tblQuickAction;
        private Label label11;
        private Button btnQcAddTeam;
        private Button btnQcViewBracket;
        private Button btnQcCreateTournament;
        private Button btnQcRegRobot;
    }
}