namespace lab_act_C
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtQueLastBuy = new TextBox();
            grpLastPurchase = new GroupBox();
            rbMoreYear = new RadioButton();
            rb1_6 = new RadioButton();
            rbNotRemember = new RadioButton();
            rb6to1YearAgo = new RadioButton();
            rbLessMonth = new RadioButton();
            txtQuePurpose = new TextBox();
            clbPurpose = new CheckedListBox();
            txtQueLocation = new TextBox();
            clbLocation = new CheckedListBox();
            btnNext = new Button();
            btnBack = new Button();
            grpLastPurchase.SuspendLayout();
            SuspendLayout();
            // 
            // txtQueLastBuy
            // 
            txtQueLastBuy.BackColor = SystemColors.Control;
            txtQueLastBuy.BorderStyle = BorderStyle.None;
            txtQueLastBuy.Font = new Font("Segoe UI", 12F);
            txtQueLastBuy.Location = new Point(17, 20);
            txtQueLastBuy.Name = "txtQueLastBuy";
            txtQueLastBuy.ReadOnly = true;
            txtQueLastBuy.Size = new Size(440, 32);
            txtQueLastBuy.TabIndex = 0;
            txtQueLastBuy.Text = "When did you last buy a sportswear?";
            // 
            // grpLastPurchase
            // 
            grpLastPurchase.Controls.Add(rbMoreYear);
            grpLastPurchase.Controls.Add(rb1_6);
            grpLastPurchase.Controls.Add(rbNotRemember);
            grpLastPurchase.Controls.Add(rb6to1YearAgo);
            grpLastPurchase.Controls.Add(rbLessMonth);
            grpLastPurchase.Location = new Point(17, 69);
            grpLastPurchase.Name = "grpLastPurchase";
            grpLastPurchase.Size = new Size(618, 167);
            grpLastPurchase.TabIndex = 1;
            grpLastPurchase.TabStop = false;
            // 
            // rbMoreYear
            // 
            rbMoreYear.AutoSize = true;
            rbMoreYear.Location = new Point(320, 71);
            rbMoreYear.Name = "rbMoreYear";
            rbMoreYear.Size = new Size(208, 29);
            rbMoreYear.TabIndex = 4;
            rbMoreYear.TabStop = true;
            rbMoreYear.Text = "More than 1 year ago";
            rbMoreYear.UseVisualStyleBackColor = true;
            // 
            // rb1_6
            // 
            rb1_6.AutoSize = true;
            rb1_6.Location = new Point(320, 32);
            rb1_6.Name = "rb1_6";
            rb1_6.Size = new Size(270, 29);
            rb1_6.TabIndex = 3;
            rb1_6.TabStop = true;
            rb1_6.Text = "Between 1 and 6 months ago";
            rb1_6.UseVisualStyleBackColor = true;
            // 
            // rbNotRemember
            // 
            rbNotRemember.AutoSize = true;
            rbNotRemember.Location = new Point(4, 115);
            rbNotRemember.Name = "rbNotRemember";
            rbNotRemember.Size = new Size(188, 29);
            rbNotRemember.TabIndex = 2;
            rbNotRemember.TabStop = true;
            rbNotRemember.Text = "I do not remember";
            rbNotRemember.UseVisualStyleBackColor = true;
            // 
            // rb6to1YearAgo
            // 
            rb6to1YearAgo.AutoSize = true;
            rb6to1YearAgo.Location = new Point(4, 73);
            rb6to1YearAgo.Name = "rb6to1YearAgo";
            rb6to1YearAgo.Size = new Size(308, 29);
            rb6to1YearAgo.TabIndex = 1;
            rb6to1YearAgo.TabStop = true;
            rb6to1YearAgo.Text = "Between 6 months and 1 year ago";
            rb6to1YearAgo.UseVisualStyleBackColor = true;
            // 
            // rbLessMonth
            // 
            rbLessMonth.AutoSize = true;
            rbLessMonth.Location = new Point(4, 32);
            rbLessMonth.Name = "rbLessMonth";
            rbLessMonth.Size = new Size(233, 29);
            rbLessMonth.TabIndex = 0;
            rbLessMonth.TabStop = true;
            rbLessMonth.Text = "Less than a 1 month ago";
            rbLessMonth.UseVisualStyleBackColor = true;
            // 
            // txtQuePurpose
            // 
            txtQuePurpose.BorderStyle = BorderStyle.None;
            txtQuePurpose.Font = new Font("Segoe UI", 12F);
            txtQuePurpose.Location = new Point(17, 255);
            txtQuePurpose.Multiline = true;
            txtQuePurpose.Name = "txtQuePurpose";
            txtQuePurpose.ReadOnly = true;
            txtQuePurpose.Size = new Size(823, 52);
            txtQuePurpose.TabIndex = 2;
            txtQuePurpose.Text = "Which of the followings would describe your purpose to buy sportswear?";
            // 
            // clbPurpose
            // 
            clbPurpose.FormattingEnabled = true;
            clbPurpose.Items.AddRange(new object[] { "Gym/fitness", "hiking", "Sports(basketball, swimming, etc.)", "Running", "Outdoor fashion", "Other" });
            clbPurpose.Location = new Point(21, 313);
            clbPurpose.Name = "clbPurpose";
            clbPurpose.Size = new Size(483, 172);
            clbPurpose.TabIndex = 3;
            // 
            // txtQueLocation
            // 
            txtQueLocation.BorderStyle = BorderStyle.None;
            txtQueLocation.Font = new Font("Segoe UI", 12F);
            txtQueLocation.Location = new Point(17, 515);
            txtQueLocation.Name = "txtQueLocation";
            txtQueLocation.ReadOnly = true;
            txtQueLocation.Size = new Size(583, 32);
            txtQueLocation.TabIndex = 4;
            txtQueLocation.Text = "Where do you usually buy your sportswear from?";
            // 
            // clbLocation
            // 
            clbLocation.FormattingEnabled = true;
            clbLocation.Items.AddRange(new object[] { "Retail store", "Multi brand retail", "Departmental store", "Online", "Other" });
            clbLocation.Location = new Point(17, 573);
            clbLocation.Name = "clbLocation";
            clbLocation.Size = new Size(483, 144);
            clbLocation.TabIndex = 5;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1019, 692);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 38);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1019, 643);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 38);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(clbLocation);
            Controls.Add(txtQueLocation);
            Controls.Add(clbPurpose);
            Controls.Add(txtQuePurpose);
            Controls.Add(grpLastPurchase);
            Controls.Add(txtQueLastBuy);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load_1;
            grpLastPurchase.ResumeLayout(false);
            grpLastPurchase.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtQueLastBuy;
        private System.Windows.Forms.GroupBox grpLastPurchase;
        private System.Windows.Forms.RadioButton rbLessMonth;
        private System.Windows.Forms.RadioButton rb6to1YearAgo;
        private System.Windows.Forms.RadioButton rb1_6;
        private System.Windows.Forms.RadioButton rbMoreYear;
        private System.Windows.Forms.RadioButton rbNotRemember;
        private System.Windows.Forms.TextBox txtQuePurpose;
        private System.Windows.Forms.CheckedListBox clbPurpose;
        private System.Windows.Forms.TextBox txtQueLocation;
        private System.Windows.Forms.CheckedListBox clbLocation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
    }
}
