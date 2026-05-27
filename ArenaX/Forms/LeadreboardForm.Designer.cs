namespace ArenaX.Forms
{
    partial class LeadreboardForm
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
            lblSub = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            flwLeaderboard = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
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
            lblSub.TabIndex = 17;
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
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Tournaments";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 11, 34);
            panel1.Controls.Add(flwLeaderboard);
            panel1.Location = new Point(50, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 573);
            panel1.TabIndex = 18;
            // 
            // flwLeaderboard
            // 
            flwLeaderboard.Location = new Point(39, 40);
            flwLeaderboard.Name = "flwLeaderboard";
            flwLeaderboard.Size = new Size(987, 497);
            flwLeaderboard.TabIndex = 0;
            // 
            // LeadreboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 6, 23);
            ClientSize = new Size(1173, 681);
            Controls.Add(panel1);
            Controls.Add(lblSub);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LeadreboardForm";
            Text = "LeadreboardForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSub;
        private Label lblTitle;
        private Panel panel1;
        private FlowLayoutPanel flwLeaderboard;
    }
}