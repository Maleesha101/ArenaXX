namespace ArenaX.Forms
{
    partial class TeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamForm));
            btnAddTeam = new Button();
            lblSub = new Label();
            lblTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlTeamCard = new Panel();
            btnApprove = new Button();
            btnReject = new Button();
            pictureBox1 = new PictureBox();
            btnStatus = new Button();
            lblDescription = new Label();
            lblEmail = new Label();
            lblCaptainName = new Label();
            lblCaptain = new Label();
            lblTeamName = new Label();
            flowLayoutPanel1.SuspendLayout();
            pnlTeamCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddTeam
            // 
            btnAddTeam.BackColor = Color.FromArgb(134, 114, 255);
            btnAddTeam.FlatAppearance.BorderSize = 0;
            btnAddTeam.FlatStyle = FlatStyle.Flat;
            btnAddTeam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTeam.ForeColor = SystemColors.ControlLightLight;
            btnAddTeam.Location = new Point(1386, 28);
            btnAddTeam.Name = "btnAddTeam";
            btnAddTeam.Size = new Size(154, 47);
            btnAddTeam.TabIndex = 8;
            btnAddTeam.Text = "Add Team";
            btnAddTeam.UseVisualStyleBackColor = false;
            btnAddTeam.Click += btnAddTeam_Click;
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
            lblSub.TabIndex = 7;
            lblSub.Text = "Real-time tournament overview";
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
            lblTitle.Size = new Size(113, 58);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Teams";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(7, 11, 34);
            flowLayoutPanel1.Controls.Add(pnlTeamCard);
            flowLayoutPanel1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(12, 102);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1543, 587);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pnlTeamCard
            // 
            pnlTeamCard.BackColor = Color.FromArgb(8, 12, 37);
            pnlTeamCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTeamCard.Controls.Add(btnApprove);
            pnlTeamCard.Controls.Add(btnReject);
            pnlTeamCard.Controls.Add(pictureBox1);
            pnlTeamCard.Controls.Add(btnStatus);
            pnlTeamCard.Controls.Add(lblDescription);
            pnlTeamCard.Controls.Add(lblEmail);
            pnlTeamCard.Controls.Add(lblCaptainName);
            pnlTeamCard.Controls.Add(lblCaptain);
            pnlTeamCard.Controls.Add(lblTeamName);
            pnlTeamCard.ForeColor = SystemColors.ControlDarkDark;
            pnlTeamCard.Location = new Point(20, 20);
            pnlTeamCard.Margin = new Padding(20);
            pnlTeamCard.Name = "pnlTeamCard";
            pnlTeamCard.Padding = new Padding(10);
            pnlTeamCard.Size = new Size(516, 261);
            pnlTeamCard.TabIndex = 0;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(0, 183, 100);
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.ForeColor = SystemColors.Desktop;
            btnApprove.Location = new Point(24, 205);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(134, 41);
            btnApprove.TabIndex = 8;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(3, 6, 23);
            btnReject.FlatAppearance.BorderColor = Color.DimGray;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(172, 205);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(134, 41);
            btnReject.TabIndex = 7;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.Black;
            btnStatus.FlatAppearance.BorderSize = 0;
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(407, 19);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(94, 29);
            btnStatus.TabIndex = 6;
            btnStatus.Text = "button1";
            btnStatus.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(33, 124);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 17);
            lblDescription.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(33, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 17);
            lblEmail.TabIndex = 3;
            // 
            // lblCaptainName
            // 
            lblCaptainName.AutoSize = true;
            lblCaptainName.ForeColor = Color.WhiteSmoke;
            lblCaptainName.Location = new Point(103, 59);
            lblCaptainName.Name = "lblCaptainName";
            lblCaptainName.Size = new Size(0, 17);
            lblCaptainName.TabIndex = 2;
            // 
            // lblCaptain
            // 
            lblCaptain.AutoSize = true;
            lblCaptain.ForeColor = Color.White;
            lblCaptain.Location = new Point(33, 59);
            lblCaptain.Name = "lblCaptain";
            lblCaptain.Size = new Size(55, 17);
            lblCaptain.TabIndex = 1;
            lblCaptain.Text = "Captain:";
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeamName.ForeColor = Color.White;
            lblTeamName.Location = new Point(24, 17);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(85, 28);
            lblTeamName.TabIndex = 0;
            lblTeamName.Text = "Team01";
            // 
            // TeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 6, 23);
            ClientSize = new Size(1567, 689);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAddTeam);
            Controls.Add(lblSub);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeamForm";
            Text = "TeamForm";
            flowLayoutPanel1.ResumeLayout(false);
            pnlTeamCard.ResumeLayout(false);
            pnlTeamCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddTeam;
        private Label lblSub;
        private Label lblTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlTeamCard;
        private Label lblDescription;
        private Label lblEmail;
        private Label lblCaptainName;
        private Label lblCaptain;
        private Label lblTeamName;
        private Button btnApprove;
        private Button btnReject;
        private PictureBox pictureBox1;
        private Button btnStatus;
    }
}