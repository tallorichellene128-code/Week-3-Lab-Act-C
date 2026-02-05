namespace lab_act_C
{
    partial class Form6
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
            clbBrandTrait = new CheckedListBox();
            clbInterest = new CheckedListBox();
            btnSubmit = new Button();
            btnBack = new Button();
            txtEmail = new TextBox();
            lblBrandPersonality = new Label();
            lblInterests = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // clbBrandTrait
            // 
            clbBrandTrait.FormattingEnabled = true;
            clbBrandTrait.Items.AddRange(new object[] { "Imaginative", "Colorful", "Cheerful", "Daring", "Intelligent", "Tough", "Serious", "Spirited", "Outdoorsy", "Reliable", "Honest", "Funny", "Successful", "Introverted", "Sophisticated", "Classy", "Other" });
            clbBrandTrait.Location = new Point(57, 126);
            clbBrandTrait.Margin = new Padding(4, 5, 4, 5);
            clbBrandTrait.Name = "clbBrandTrait";
            clbBrandTrait.Size = new Size(404, 480);
            clbBrandTrait.TabIndex = 1;
            // 
            // clbInterest
            // 
            clbInterest.FormattingEnabled = true;
            clbInterest.Items.AddRange(new object[] { "Arts & Entertainment", "Books & Literature", "Finance", "Hobbies & Leisure", "Jobs & Education", "Online Communities", "Real Estate", "Shopping ", "Motorsports", "Autos & vehicles", "Business & Industrial ", "Food & Drink ", "Home & Garden ", "Law & Government ", "People & Society", "Reference", "Travel ", "E- sports", "Beauty & Firness", "Computers & Electronics", "games", "Internet & Telecom", "News", "Pets & Animals", "Science", "World Localities" });
            clbInterest.Location = new Point(536, 126);
            clbInterest.Margin = new Padding(4, 5, 4, 5);
            clbInterest.Name = "clbInterest";
            clbInterest.Size = new Size(404, 480);
            clbInterest.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1008, 704);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1008, 653);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(57, 656);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(404, 31);
            txtEmail.TabIndex = 6;
            // 
            // lblBrandPersonality
            // 
            lblBrandPersonality.AutoSize = true;
            lblBrandPersonality.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandPersonality.Location = new Point(34, 47);
            lblBrandPersonality.Name = "lblBrandPersonality";
            lblBrandPersonality.Size = new Size(468, 64);
            lblBrandPersonality.TabIndex = 7;
            lblBrandPersonality.Text = "If your favorite sports brand was a person, \r\nhow would you describe it?\r\n";
            // 
            // lblInterests
            // 
            lblInterests.AutoSize = true;
            lblInterests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterests.Location = new Point(536, 47);
            lblInterests.Name = "lblInterests";
            lblInterests.Size = new Size(344, 64);
            lblInterests.TabIndex = 8;
            lblInterests.Text = "What are your other interests? \r\n(Select all that apply)\r\n";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(57, 628);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(205, 25);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Please share your email: ";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblEmail);
            Controls.Add(lblInterests);
            Controls.Add(lblBrandPersonality);
            Controls.Add(txtEmail);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(clbInterest);
            Controls.Add(clbBrandTrait);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbBrandTrait;
        private CheckedListBox clbInterest;
        private Button btnSubmit;
        private Button btnBack;
        private TextBox txtEmail;
        private Label lblBrandPersonality;
        private Label lblInterests;
        private Label lblEmail;
    }
}