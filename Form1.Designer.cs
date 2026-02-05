namespace lab_act_C
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
            txtQuestionGender = new TextBox();
            grpGender = new GroupBox();
            rbGenderPreferNotSay = new RadioButton();
            rbGenderMale = new RadioButton();
            rbGenderNonBinary = new RadioButton();
            rbGenderFemale = new RadioButton();
            txtTitle = new TextBox();
            txtSubtitle = new TextBox();
            txtQuestionAgeRange = new TextBox();
            grpAgeRange = new GroupBox();
            rbAge55_64 = new RadioButton();
            rbAge65Plus = new RadioButton();
            rbAge45_54 = new RadioButton();
            rbAge35_44 = new RadioButton();
            rbAge18_24 = new RadioButton();
            rbAge25_34 = new RadioButton();
            rbAge0_17 = new RadioButton();
            txtQuestionMaritalStatus = new TextBox();
            grpMaritalStatus = new GroupBox();
            rbMaritalPreferNotSay = new RadioButton();
            rbMartialWidowed = new RadioButton();
            rbMaritalmarried = new RadioButton();
            rbMaritalDivorced = new RadioButton();
            rbMaritalSingle = new RadioButton();
            txtQuestionIncomeRange = new TextBox();
            grpIncomeRange = new GroupBox();
            rbIncome100kPlus = new RadioButton();
            rbIncomePreferNotAnswer = new RadioButton();
            rbIncome75k_99k = new RadioButton();
            rbIncome50k_74k = new RadioButton();
            rbIncome10k_24k = new RadioButton();
            rbIncome25k_49k = new RadioButton();
            rbIncomeLow = new RadioButton();
            btnNext = new Button();
            grpGender.SuspendLayout();
            grpAgeRange.SuspendLayout();
            grpMaritalStatus.SuspendLayout();
            grpIncomeRange.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuestionGender
            // 
            txtQuestionGender.BackColor = SystemColors.Control;
            txtQuestionGender.BorderStyle = BorderStyle.None;
            txtQuestionGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestionGender.Location = new Point(17, 163);
            txtQuestionGender.Margin = new Padding(4, 5, 4, 5);
            txtQuestionGender.Name = "txtQuestionGender";
            txtQuestionGender.Size = new Size(238, 32);
            txtQuestionGender.TabIndex = 0;
            txtQuestionGender.Text = "What is your gender?";
            txtQuestionGender.TextChanged += textBox1_TextChanged;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbGenderPreferNotSay);
            grpGender.Controls.Add(rbGenderMale);
            grpGender.Controls.Add(rbGenderNonBinary);
            grpGender.Controls.Add(rbGenderFemale);
            grpGender.Location = new Point(17, 202);
            grpGender.Margin = new Padding(4, 5, 4, 5);
            grpGender.Name = "grpGender";
            grpGender.Padding = new Padding(4, 5, 4, 5);
            grpGender.Size = new Size(380, 127);
            grpGender.TabIndex = 1;
            grpGender.TabStop = false;
            grpGender.Enter += groupBox1_Enter;
            // 
            // rbGenderPreferNotSay
            // 
            rbGenderPreferNotSay.AutoSize = true;
            rbGenderPreferNotSay.Location = new Point(167, 78);
            rbGenderPreferNotSay.Margin = new Padding(4, 5, 4, 5);
            rbGenderPreferNotSay.Name = "rbGenderPreferNotSay";
            rbGenderPreferNotSay.Size = new Size(168, 29);
            rbGenderPreferNotSay.TabIndex = 3;
            rbGenderPreferNotSay.TabStop = true;
            rbGenderPreferNotSay.Text = "Prefer not to say";
            rbGenderPreferNotSay.UseVisualStyleBackColor = true;
            // 
            // rbGenderMale
            // 
            rbGenderMale.AutoSize = true;
            rbGenderMale.Location = new Point(167, 37);
            rbGenderMale.Margin = new Padding(4, 5, 4, 5);
            rbGenderMale.Name = "rbGenderMale";
            rbGenderMale.Size = new Size(75, 29);
            rbGenderMale.TabIndex = 2;
            rbGenderMale.TabStop = true;
            rbGenderMale.Text = "Male";
            rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbGenderNonBinary
            // 
            rbGenderNonBinary.AutoSize = true;
            rbGenderNonBinary.Location = new Point(9, 78);
            rbGenderNonBinary.Margin = new Padding(4, 5, 4, 5);
            rbGenderNonBinary.Name = "rbGenderNonBinary";
            rbGenderNonBinary.Size = new Size(126, 29);
            rbGenderNonBinary.TabIndex = 1;
            rbGenderNonBinary.TabStop = true;
            rbGenderNonBinary.Text = "Non-Binary";
            rbGenderNonBinary.UseVisualStyleBackColor = true;
            // 
            // rbGenderFemale
            // 
            rbGenderFemale.AutoSize = true;
            rbGenderFemale.Location = new Point(9, 37);
            rbGenderFemale.Margin = new Padding(4, 5, 4, 5);
            rbGenderFemale.Name = "rbGenderFemale";
            rbGenderFemale.Size = new Size(93, 29);
            rbGenderFemale.TabIndex = 0;
            rbGenderFemale.TabStop = true;
            rbGenderFemale.Text = "Female";
            rbGenderFemale.UseVisualStyleBackColor = true;
            rbGenderFemale.CheckedChanged += rbGenderFemale_CheckedChanged;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Control;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(350, 5);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(433, 48);
            txtTitle.TabIndex = 2;
            txtTitle.Text = "Market Research Survey";
            // 
            // txtSubtitle
            // 
            txtSubtitle.BackColor = SystemColors.Control;
            txtSubtitle.BorderStyle = BorderStyle.None;
            txtSubtitle.Location = new Point(289, 63);
            txtSubtitle.Margin = new Padding(4, 5, 4, 5);
            txtSubtitle.Name = "txtSubtitle";
            txtSubtitle.Size = new Size(602, 24);
            txtSubtitle.TabIndex = 3;
            txtSubtitle.Text = "Please take a few minutes to tell us more about you and your preferences";
            // 
            // txtQuestionAgeRange
            // 
            txtQuestionAgeRange.BackColor = SystemColors.Control;
            txtQuestionAgeRange.BorderStyle = BorderStyle.None;
            txtQuestionAgeRange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestionAgeRange.Location = new Point(17, 399);
            txtQuestionAgeRange.Margin = new Padding(4, 5, 4, 5);
            txtQuestionAgeRange.Name = "txtQuestionAgeRange";
            txtQuestionAgeRange.Size = new Size(300, 32);
            txtQuestionAgeRange.TabIndex = 4;
            txtQuestionAgeRange.Text = "What is your age range?";
            // 
            // grpAgeRange
            // 
            grpAgeRange.Controls.Add(rbAge55_64);
            grpAgeRange.Controls.Add(rbAge65Plus);
            grpAgeRange.Controls.Add(rbAge45_54);
            grpAgeRange.Controls.Add(rbAge35_44);
            grpAgeRange.Controls.Add(rbAge18_24);
            grpAgeRange.Controls.Add(rbAge25_34);
            grpAgeRange.Controls.Add(rbAge0_17);
            grpAgeRange.Location = new Point(17, 432);
            grpAgeRange.Margin = new Padding(4, 5, 4, 5);
            grpAgeRange.Name = "grpAgeRange";
            grpAgeRange.Padding = new Padding(4, 5, 4, 5);
            grpAgeRange.Size = new Size(380, 213);
            grpAgeRange.TabIndex = 4;
            grpAgeRange.TabStop = false;
            // 
            // rbAge55_64
            // 
            rbAge55_64.AutoSize = true;
            rbAge55_64.Location = new Point(167, 120);
            rbAge55_64.Margin = new Padding(4, 5, 4, 5);
            rbAge55_64.Name = "rbAge55_64";
            rbAge55_64.Size = new Size(84, 29);
            rbAge55_64.TabIndex = 6;
            rbAge55_64.TabStop = true;
            rbAge55_64.Text = "55-64";
            rbAge55_64.UseVisualStyleBackColor = true;
            // 
            // rbAge65Plus
            // 
            rbAge65Plus.AutoSize = true;
            rbAge65Plus.Location = new Point(9, 162);
            rbAge65Plus.Margin = new Padding(4, 5, 4, 5);
            rbAge65Plus.Name = "rbAge65Plus";
            rbAge65Plus.Size = new Size(69, 29);
            rbAge65Plus.TabIndex = 5;
            rbAge65Plus.TabStop = true;
            rbAge65Plus.Text = "65+";
            rbAge65Plus.UseVisualStyleBackColor = true;
            // 
            // rbAge45_54
            // 
            rbAge45_54.AutoSize = true;
            rbAge45_54.Location = new Point(9, 120);
            rbAge45_54.Margin = new Padding(4, 5, 4, 5);
            rbAge45_54.Name = "rbAge45_54";
            rbAge45_54.Size = new Size(84, 29);
            rbAge45_54.TabIndex = 4;
            rbAge45_54.TabStop = true;
            rbAge45_54.Text = "45-54";
            rbAge45_54.UseVisualStyleBackColor = true;
            // 
            // rbAge35_44
            // 
            rbAge35_44.AutoSize = true;
            rbAge35_44.Location = new Point(167, 78);
            rbAge35_44.Margin = new Padding(4, 5, 4, 5);
            rbAge35_44.Name = "rbAge35_44";
            rbAge35_44.Size = new Size(84, 29);
            rbAge35_44.TabIndex = 3;
            rbAge35_44.TabStop = true;
            rbAge35_44.Text = "35-44";
            rbAge35_44.UseVisualStyleBackColor = true;
            // 
            // rbAge18_24
            // 
            rbAge18_24.AutoSize = true;
            rbAge18_24.Location = new Point(167, 37);
            rbAge18_24.Margin = new Padding(4, 5, 4, 5);
            rbAge18_24.Name = "rbAge18_24";
            rbAge18_24.Size = new Size(84, 29);
            rbAge18_24.TabIndex = 2;
            rbAge18_24.TabStop = true;
            rbAge18_24.Text = "18-24";
            rbAge18_24.UseVisualStyleBackColor = true;
            // 
            // rbAge25_34
            // 
            rbAge25_34.AutoSize = true;
            rbAge25_34.Location = new Point(9, 78);
            rbAge25_34.Margin = new Padding(4, 5, 4, 5);
            rbAge25_34.Name = "rbAge25_34";
            rbAge25_34.Size = new Size(84, 29);
            rbAge25_34.TabIndex = 1;
            rbAge25_34.TabStop = true;
            rbAge25_34.Text = "25-34";
            rbAge25_34.UseVisualStyleBackColor = true;
            // 
            // rbAge0_17
            // 
            rbAge0_17.AutoSize = true;
            rbAge0_17.Location = new Point(9, 37);
            rbAge0_17.Margin = new Padding(4, 5, 4, 5);
            rbAge0_17.Name = "rbAge0_17";
            rbAge0_17.Size = new Size(74, 29);
            rbAge0_17.TabIndex = 0;
            rbAge0_17.TabStop = true;
            rbAge0_17.Text = "0-17";
            rbAge0_17.UseVisualStyleBackColor = true;
            // 
            // txtQuestionMaritalStatus
            // 
            txtQuestionMaritalStatus.BackColor = SystemColors.Control;
            txtQuestionMaritalStatus.BorderStyle = BorderStyle.None;
            txtQuestionMaritalStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestionMaritalStatus.Location = new Point(559, 163);
            txtQuestionMaritalStatus.Margin = new Padding(4, 5, 4, 5);
            txtQuestionMaritalStatus.Name = "txtQuestionMaritalStatus";
            txtQuestionMaritalStatus.Size = new Size(300, 32);
            txtQuestionMaritalStatus.TabIndex = 5;
            txtQuestionMaritalStatus.Text = "What is your marital status?";
            // 
            // grpMaritalStatus
            // 
            grpMaritalStatus.Controls.Add(rbMaritalPreferNotSay);
            grpMaritalStatus.Controls.Add(rbMartialWidowed);
            grpMaritalStatus.Controls.Add(rbMaritalmarried);
            grpMaritalStatus.Controls.Add(rbMaritalDivorced);
            grpMaritalStatus.Controls.Add(rbMaritalSingle);
            grpMaritalStatus.Location = new Point(559, 205);
            grpMaritalStatus.Margin = new Padding(4, 5, 4, 5);
            grpMaritalStatus.Name = "grpMaritalStatus";
            grpMaritalStatus.Padding = new Padding(4, 5, 4, 5);
            grpMaritalStatus.Size = new Size(380, 173);
            grpMaritalStatus.TabIndex = 4;
            grpMaritalStatus.TabStop = false;
            grpMaritalStatus.Enter += groupBox2_Enter;
            // 
            // rbMaritalPreferNotSay
            // 
            rbMaritalPreferNotSay.AutoSize = true;
            rbMaritalPreferNotSay.Location = new Point(9, 120);
            rbMaritalPreferNotSay.Margin = new Padding(4, 5, 4, 5);
            rbMaritalPreferNotSay.Name = "rbMaritalPreferNotSay";
            rbMaritalPreferNotSay.Size = new Size(168, 29);
            rbMaritalPreferNotSay.TabIndex = 4;
            rbMaritalPreferNotSay.TabStop = true;
            rbMaritalPreferNotSay.Text = "Prefer not to say";
            rbMaritalPreferNotSay.UseVisualStyleBackColor = true;
            // 
            // rbMartialWidowed
            // 
            rbMartialWidowed.AutoSize = true;
            rbMartialWidowed.Location = new Point(167, 78);
            rbMartialWidowed.Margin = new Padding(4, 5, 4, 5);
            rbMartialWidowed.Name = "rbMartialWidowed";
            rbMartialWidowed.Size = new Size(113, 29);
            rbMartialWidowed.TabIndex = 3;
            rbMartialWidowed.TabStop = true;
            rbMartialWidowed.Text = "Widowed";
            rbMartialWidowed.UseVisualStyleBackColor = true;
            // 
            // rbMaritalmarried
            // 
            rbMaritalmarried.AutoSize = true;
            rbMaritalmarried.Location = new Point(167, 37);
            rbMaritalmarried.Margin = new Padding(4, 5, 4, 5);
            rbMaritalmarried.Name = "rbMaritalmarried";
            rbMaritalmarried.Size = new Size(98, 29);
            rbMaritalmarried.TabIndex = 2;
            rbMaritalmarried.TabStop = true;
            rbMaritalmarried.Text = "Married";
            rbMaritalmarried.UseVisualStyleBackColor = true;
            // 
            // rbMaritalDivorced
            // 
            rbMaritalDivorced.AutoSize = true;
            rbMaritalDivorced.Location = new Point(9, 78);
            rbMaritalDivorced.Margin = new Padding(4, 5, 4, 5);
            rbMaritalDivorced.Name = "rbMaritalDivorced";
            rbMaritalDivorced.Size = new Size(108, 29);
            rbMaritalDivorced.TabIndex = 1;
            rbMaritalDivorced.TabStop = true;
            rbMaritalDivorced.Text = "Divorced";
            rbMaritalDivorced.UseVisualStyleBackColor = true;
            // 
            // rbMaritalSingle
            // 
            rbMaritalSingle.AutoSize = true;
            rbMaritalSingle.Location = new Point(9, 37);
            rbMaritalSingle.Margin = new Padding(4, 5, 4, 5);
            rbMaritalSingle.Name = "rbMaritalSingle";
            rbMaritalSingle.Size = new Size(85, 29);
            rbMaritalSingle.TabIndex = 0;
            rbMaritalSingle.TabStop = true;
            rbMaritalSingle.Text = "Single";
            rbMaritalSingle.UseVisualStyleBackColor = true;
            // 
            // txtQuestionIncomeRange
            // 
            txtQuestionIncomeRange.BackColor = SystemColors.Control;
            txtQuestionIncomeRange.BorderStyle = BorderStyle.None;
            txtQuestionIncomeRange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestionIncomeRange.Location = new Point(559, 434);
            txtQuestionIncomeRange.Margin = new Padding(4, 5, 4, 5);
            txtQuestionIncomeRange.Name = "txtQuestionIncomeRange";
            txtQuestionIncomeRange.Size = new Size(425, 32);
            txtQuestionIncomeRange.TabIndex = 6;
            txtQuestionIncomeRange.Text = "What is your annual income range?";
            // 
            // grpIncomeRange
            // 
            grpIncomeRange.Controls.Add(rbIncome100kPlus);
            grpIncomeRange.Controls.Add(rbIncomePreferNotAnswer);
            grpIncomeRange.Controls.Add(rbIncome75k_99k);
            grpIncomeRange.Controls.Add(rbIncome50k_74k);
            grpIncomeRange.Controls.Add(rbIncome10k_24k);
            grpIncomeRange.Controls.Add(rbIncome25k_49k);
            grpIncomeRange.Controls.Add(rbIncomeLow);
            grpIncomeRange.Location = new Point(559, 469);
            grpIncomeRange.Margin = new Padding(4, 5, 4, 5);
            grpIncomeRange.Name = "grpIncomeRange";
            grpIncomeRange.Padding = new Padding(4, 5, 4, 5);
            grpIncomeRange.Size = new Size(425, 213);
            grpIncomeRange.TabIndex = 7;
            grpIncomeRange.TabStop = false;
            // 
            // rbIncome100kPlus
            // 
            rbIncome100kPlus.AutoSize = true;
            rbIncome100kPlus.Location = new Point(200, 120);
            rbIncome100kPlus.Margin = new Padding(4, 5, 4, 5);
            rbIncome100kPlus.Name = "rbIncome100kPlus";
            rbIncome100kPlus.Size = new Size(180, 29);
            rbIncome100kPlus.TabIndex = 6;
            rbIncome100kPlus.TabStop = true;
            rbIncome100kPlus.Text = "$100,000 or more";
            rbIncome100kPlus.UseVisualStyleBackColor = true;
            // 
            // rbIncomePreferNotAnswer
            // 
            rbIncomePreferNotAnswer.AutoSize = true;
            rbIncomePreferNotAnswer.Location = new Point(9, 162);
            rbIncomePreferNotAnswer.Margin = new Padding(4, 5, 4, 5);
            rbIncomePreferNotAnswer.Name = "rbIncomePreferNotAnswer";
            rbIncomePreferNotAnswer.Size = new Size(197, 29);
            rbIncomePreferNotAnswer.TabIndex = 5;
            rbIncomePreferNotAnswer.TabStop = true;
            rbIncomePreferNotAnswer.Text = "Prefer not to answer";
            rbIncomePreferNotAnswer.UseVisualStyleBackColor = true;
            // 
            // rbIncome75k_99k
            // 
            rbIncome75k_99k.AutoSize = true;
            rbIncome75k_99k.Location = new Point(9, 120);
            rbIncome75k_99k.Margin = new Padding(4, 5, 4, 5);
            rbIncome75k_99k.Name = "rbIncome75k_99k";
            rbIncome75k_99k.Size = new Size(172, 29);
            rbIncome75k_99k.TabIndex = 4;
            rbIncome75k_99k.TabStop = true;
            rbIncome75k_99k.Text = "$75,000-$99,999";
            rbIncome75k_99k.UseVisualStyleBackColor = true;
            // 
            // rbIncome50k_74k
            // 
            rbIncome50k_74k.AutoSize = true;
            rbIncome50k_74k.Location = new Point(200, 78);
            rbIncome50k_74k.Margin = new Padding(4, 5, 4, 5);
            rbIncome50k_74k.Name = "rbIncome50k_74k";
            rbIncome50k_74k.Size = new Size(172, 29);
            rbIncome50k_74k.TabIndex = 3;
            rbIncome50k_74k.TabStop = true;
            rbIncome50k_74k.Text = "$50,000-$74,999";
            rbIncome50k_74k.UseVisualStyleBackColor = true;
            rbIncome50k_74k.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rbIncome10k_24k
            // 
            rbIncome10k_24k.AutoSize = true;
            rbIncome10k_24k.Location = new Point(200, 37);
            rbIncome10k_24k.Margin = new Padding(4, 5, 4, 5);
            rbIncome10k_24k.Name = "rbIncome10k_24k";
            rbIncome10k_24k.Size = new Size(152, 29);
            rbIncome10k_24k.TabIndex = 2;
            rbIncome10k_24k.TabStop = true;
            rbIncome10k_24k.Text = "$10,00-$24,99";
            rbIncome10k_24k.UseVisualStyleBackColor = true;
            // 
            // rbIncome25k_49k
            // 
            rbIncome25k_49k.AutoSize = true;
            rbIncome25k_49k.Location = new Point(9, 78);
            rbIncome25k_49k.Margin = new Padding(4, 5, 4, 5);
            rbIncome25k_49k.Name = "rbIncome25k_49k";
            rbIncome25k_49k.Size = new Size(172, 29);
            rbIncome25k_49k.TabIndex = 1;
            rbIncome25k_49k.TabStop = true;
            rbIncome25k_49k.Text = "$25,000-$49,999";
            rbIncome25k_49k.UseVisualStyleBackColor = true;
            // 
            // rbIncomeLow
            // 
            rbIncomeLow.AutoSize = true;
            rbIncomeLow.Location = new Point(9, 37);
            rbIncomeLow.Margin = new Padding(4, 5, 4, 5);
            rbIncomeLow.Name = "rbIncomeLow";
            rbIncomeLow.Size = new Size(147, 29);
            rbIncomeLow.TabIndex = 0;
            rbIncomeLow.TabStop = true;
            rbIncomeLow.Text = "$9,999 or less";
            rbIncomeLow.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1019, 692);
            btnNext.Margin = new Padding(4, 5, 4, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 38);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnNext);
            Controls.Add(grpIncomeRange);
            Controls.Add(txtQuestionIncomeRange);
            Controls.Add(grpMaritalStatus);
            Controls.Add(txtQuestionMaritalStatus);
            Controls.Add(grpAgeRange);
            Controls.Add(txtQuestionAgeRange);
            Controls.Add(txtSubtitle);
            Controls.Add(txtTitle);
            Controls.Add(grpGender);
            Controls.Add(txtQuestionGender);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            grpAgeRange.ResumeLayout(false);
            grpAgeRange.PerformLayout();
            grpMaritalStatus.ResumeLayout(false);
            grpMaritalStatus.PerformLayout();
            grpIncomeRange.ResumeLayout(false);
            grpIncomeRange.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestionGender;
        private GroupBox grpGender;
        private RadioButton rbGenderFemale;
        private TextBox txtTitle;
        private TextBox txtSubtitle;
        private RadioButton rbGenderPreferNotSay;
        private RadioButton rbGenderMale;
        private RadioButton rbGenderNonBinary;
        private TextBox txtQuestionAgeRange;
        private GroupBox grpAgeRange;
        private RadioButton rbAge55_64;
        private RadioButton rbAge65Plus;
        private RadioButton rbAge45_54;
        private RadioButton rbAge35_44;
        private RadioButton rbAge18_24;
        private RadioButton rbAge25_34;
        private RadioButton rbAge0_17;
        private TextBox txtQuestionMaritalStatus;
        private GroupBox grpMaritalStatus;
        private RadioButton rbMartialWidowed;
        private RadioButton rbMaritalmarried;
        private RadioButton rbMaritalDivorced;
        private RadioButton rbMaritalSingle;
        private RadioButton rbMaritalPreferNotSay;
        private TextBox txtQuestionIncomeRange;
        private GroupBox grpIncomeRange;
        private RadioButton rbIncome100kPlus;
        private RadioButton rbIncomePreferNotAnswer;
        private RadioButton rbIncome75k_99k;
        private RadioButton rbIncome50k_74k;
        private RadioButton rbIncome10k_24k;
        private RadioButton rbIncome25k_49k;
        private RadioButton rbIncomeLow;
        private Button btnNext;
    }
}
