namespace ArenaX.Forms
{
    partial class MatchControlForm
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
            panel1 = new Panel();
            flwMatchCard = new FlowLayoutPanel();
            lblSub = new Label();
            lblTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(7, 11, 34);
            panel1.Controls.Add(flwMatchCard);
            panel1.Location = new Point(12, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(1405, 649);
            panel1.TabIndex = 19;
            // 
            // flwMatchCard
            // 
            flwMatchCard.AutoSize = true;
            flwMatchCard.BackColor = Color.FromArgb(7, 11, 34);
            flwMatchCard.FlowDirection = FlowDirection.TopDown;
            flwMatchCard.Location = new Point(19, 33);
            flwMatchCard.Margin = new Padding(33);
            flwMatchCard.Name = "flwMatchCard";
            flwMatchCard.Padding = new Padding(33);
            flwMatchCard.Size = new Size(1387, 669);
            flwMatchCard.TabIndex = 12;
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
            lblSub.Size = new Size(246, 23);
            lblSub.TabIndex = 18;
            lblSub.Text = "Start, pause and end matches";
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
            lblTitle.Size = new Size(216, 58);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Match Control";
            // 
            // MatchControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 6, 23);
            ClientSize = new Size(1429, 744);
            Controls.Add(panel1);
            Controls.Add(lblSub);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MatchControlForm";
            Text = "MatchControlForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flwMatchCard;
        private Label lblSub;
        private Label lblTitle;
    }
}