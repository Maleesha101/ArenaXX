namespace ArenaX.Forms
{
    partial class TournamentsForm
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
            flwTournamentCard = new FlowLayoutPanel();
            panel2 = new Panel();
            btnAddTeam = new Button();
            lblSub = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            flwTournamentCard.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flwTournamentCard
            // 
            flwTournamentCard.BackColor = Color.FromArgb(7, 11, 34);
            flwTournamentCard.Controls.Add(panel2);
            flwTournamentCard.Location = new Point(41, 148);
            flwTournamentCard.Name = "flwTournamentCard";
            flwTournamentCard.Size = new Size(1509, 582);
            flwTournamentCard.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Location = new Point(20, 20);
            panel2.Margin = new Padding(20);
            panel2.Name = "panel2";
            panel2.Size = new Size(641, 114);
            panel2.TabIndex = 0;
            // 
            // btnAddTeam
            // 
            btnAddTeam.BackColor = Color.FromArgb(134, 114, 255);
            btnAddTeam.FlatAppearance.BorderSize = 0;
            btnAddTeam.FlatStyle = FlatStyle.Flat;
            btnAddTeam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTeam.ForeColor = SystemColors.ControlLightLight;
            btnAddTeam.Location = new Point(1303, 28);
            btnAddTeam.Name = "btnAddTeam";
            btnAddTeam.Size = new Size(191, 47);
            btnAddTeam.TabIndex = 11;
            btnAddTeam.Text = "Add Team";
            btnAddTeam.UseVisualStyleBackColor = false;
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
            lblSub.Size = new Size(390, 23);
            lblSub.TabIndex = 15;
            lblSub.Text = "Create tournaments and auto-generate brackets";
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
            lblTitle.Size = new Size(202, 58);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Tournaments";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(7, 11, 34);
            panel1.Controls.Add(flwTournamentCard);
            panel1.Controls.Add(btnAddTeam);
            panel1.Location = new Point(12, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1558, 746);
            panel1.TabIndex = 16;
            // 
            // TournamentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 6, 23);
            ClientSize = new Size(1582, 733);
            Controls.Add(lblSub);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TournamentsForm";
            Text = "TournamentsForm";
            flwTournamentCard.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flwTournamentCard;
        private Panel panel2;
        private Button btnAddTeam;
        private Label lblSub;
        private Label lblTitle;
        private Panel panel1;
    }
}