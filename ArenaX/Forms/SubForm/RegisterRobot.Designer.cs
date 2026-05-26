namespace ArenaX.Forms.SubForm
{
    partial class RegisterRobot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterRobot));
            btnRegister = new Button();
            tbxSpecs = new TextBox();
            label4 = new Label();
            tbxWeight = new TextBox();
            label3 = new Label();
            tbxRobotName = new TextBox();
            label2 = new Label();
            lblName = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            cbxTeam = new ComboBox();
            cbxCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(130, 111, 255);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(42, 630);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(612, 43);
            btnRegister.TabIndex = 21;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbxSpecs
            // 
            tbxSpecs.BackColor = Color.FromArgb(3, 6, 23);
            tbxSpecs.BorderStyle = BorderStyle.FixedSingle;
            tbxSpecs.ForeColor = Color.White;
            tbxSpecs.Location = new Point(42, 520);
            tbxSpecs.Multiline = true;
            tbxSpecs.Name = "tbxSpecs";
            tbxSpecs.PlaceholderText = "   Drive , weapon, armor...";
            tbxSpecs.Size = new Size(612, 76);
            tbxSpecs.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 485);
            label4.Name = "label4";
            label4.Size = new Size(45, 22);
            label4.TabIndex = 19;
            label4.Text = "Specs";
            // 
            // tbxWeight
            // 
            tbxWeight.BackColor = Color.FromArgb(3, 6, 23);
            tbxWeight.BorderStyle = BorderStyle.FixedSingle;
            tbxWeight.ForeColor = Color.White;
            tbxWeight.Location = new Point(42, 411);
            tbxWeight.Multiline = true;
            tbxWeight.Name = "tbxWeight";
            tbxWeight.Size = new Size(612, 42);
            tbxWeight.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 272);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 17;
            label3.Text = "Category";
            // 
            // tbxRobotName
            // 
            tbxRobotName.BackColor = Color.FromArgb(3, 6, 23);
            tbxRobotName.BorderStyle = BorderStyle.FixedSingle;
            tbxRobotName.ForeColor = Color.White;
            tbxRobotName.Location = new Point(42, 210);
            tbxRobotName.Multiline = true;
            tbxRobotName.Name = "tbxRobotName";
            tbxRobotName.Size = new Size(612, 42);
            tbxRobotName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 175);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 15;
            label2.Text = "Robot name";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(42, 77);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 22);
            lblName.TabIndex = 13;
            lblName.Text = "Team";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 12;
            label1.Text = "New robot";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(629, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(42, 376);
            label5.Name = "label5";
            label5.Size = new Size(72, 22);
            label5.TabIndex = 22;
            label5.Text = "Weight(kg)";
            // 
            // cbxTeam
            // 
            cbxTeam.BackColor = Color.FromArgb(3, 6, 23);
            cbxTeam.FlatStyle = FlatStyle.Flat;
            cbxTeam.ForeColor = Color.White;
            cbxTeam.FormattingEnabled = true;
            cbxTeam.Location = new Point(42, 110);
            cbxTeam.Name = "cbxTeam";
            cbxTeam.Size = new Size(612, 28);
            cbxTeam.TabIndex = 23;
            cbxTeam.ItemHeight = 34; 
           
            cbxTeam.DrawMode = DrawMode.OwnerDrawFixed;
            cbxTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTeam.DrawItem += cbx_DrawItem;
            // 
            // cbxCategory
            // 
            cbxCategory.BackColor = Color.FromArgb(3, 6, 23);
            cbxCategory.FlatStyle = FlatStyle.Flat;
            cbxCategory.ForeColor = Color.White;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(42, 312);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(612, 28);
            cbxCategory.TabIndex = 24;
            cbxCategory.ItemHeight = 34; // Approximately 42 total height
            cbxCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.DrawItem += cbx_DrawItem;
            // 
            // RegisterRobot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 6, 23);
            ClientSize = new Size(696, 725);
            Controls.Add(cbxCategory);
            Controls.Add(cbxTeam);
            Controls.Add(label5);
            Controls.Add(btnRegister);
            Controls.Add(tbxSpecs);
            Controls.Add(label4);
            Controls.Add(tbxWeight);
            Controls.Add(label3);
            Controls.Add(tbxRobotName);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterRobot";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RegisterRobot";
            Load += RegisterRobot_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox tbxSpecs;
        private Label label4;
        private TextBox tbxWeight;
        private Label label3;
        private TextBox tbxRobotName;
        private Label label2;
        private Label lblName;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private ComboBox cbxTeam;
        private ComboBox cbxCategory;
    }
}