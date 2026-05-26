namespace ArenaX.Forms
{
    partial class ScoreEntryForm
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
            flxScoreEntry = new FlowLayoutPanel();
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
            lblSub.Size = new Size(447, 23);
            lblSub.TabIndex = 12;
            lblSub.Text = "Judges submit per-match scores; winners auto-calculate";
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
            lblTitle.Size = new Size(185, 58);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Score Entry";
            // 
            // flxScoreEntry
            // 
            flxScoreEntry.BackColor = Color.FromArgb(7, 11, 34);
            flxScoreEntry.Location = new Point(45, 103);
            flxScoreEntry.Name = "flxScoreEntry";
            flxScoreEntry.Size = new Size(1232, 614);
            flxScoreEntry.TabIndex = 13;
            // 
            // ScoreEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 6, 23);
            ClientSize = new Size(1326, 713);
            Controls.Add(flxScoreEntry);
            Controls.Add(lblSub);
            Controls.Add(lblTitle);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScoreEntryForm";
            Text = "ScoreEntryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSub;
        private Label lblTitle;
        private FlowLayoutPanel flxScoreEntry;
    }
}