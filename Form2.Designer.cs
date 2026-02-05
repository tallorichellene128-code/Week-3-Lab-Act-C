namespace lab_act_C
{
    partial class Form2
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
            txtEmploymentStatusQuestion = new TextBox();
            grpEmploymentStatus = new GroupBox();
            rbEmpPreferNo = new RadioButton();
            rbEmpHomemaker = new RadioButton();
            rbEmpUnemployed = new RadioButton();
            rbEmpPartTime = new RadioButton();
            rbEmpStudent = new RadioButton();
            rbEmpNotLooking = new RadioButton();
            rbEmpSelf = new RadioButton();
            rbEmpFullTime = new RadioButton();
            txtEducationLevelQuestion = new TextBox();
            grpEducation = new GroupBox();
            rbEduOther = new RadioButton();
            rbEduPreferNo = new RadioButton();
            rbEduMaster = new RadioButton();
            rbEduCollegeDiploma = new RadioButton();
            rbEduHighSchool = new RadioButton();
            rbEduDoctorate = new RadioButton();
            rbEduUndergrad = new RadioButton();
            rbEduSomeCollege = new RadioButton();
            rbEduLessHS = new RadioButton();
            txtExerciseFrequencyQuestion = new TextBox();
            rbExercise4 = new RadioButton();
            rbExercise5 = new RadioButton();
            rbExercise6 = new RadioButton();
            rbExercise7 = new RadioButton();
            rbExercise8 = new RadioButton();
            rbExercise9 = new RadioButton();
            rbExercise10 = new RadioButton();
            rbExercise3 = new RadioButton();
            rbExercise1 = new RadioButton();
            rbExercise2 = new RadioButton();
            grpExerciseFrequency = new GroupBox();
            txtExerciseScaleLow = new TextBox();
            txtExerciseScaleHigh = new TextBox();
            txtSportswearFrequency = new TextBox();
            grpSportswearFrequency = new GroupBox();
            rbSportswear10 = new RadioButton();
            rbSportswear2 = new RadioButton();
            rbSportswear9 = new RadioButton();
            rbSportswear1 = new RadioButton();
            rbSportswear8 = new RadioButton();
            rbSportswear3 = new RadioButton();
            rbSportswear7 = new RadioButton();
            rbSportswear4 = new RadioButton();
            rbSportswear6 = new RadioButton();
            rbSportswear5 = new RadioButton();
            txtSportswearScaleLow = new TextBox();
            txtSportswearScaleHigh = new TextBox();
            btnNext = new Button();
            btnBack = new Button();
            grpEmploymentStatus.SuspendLayout();
            grpEducation.SuspendLayout();
            grpExerciseFrequency.SuspendLayout();
            grpSportswearFrequency.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmploymentStatusQuestion
            // 
            txtEmploymentStatusQuestion.BackColor = SystemColors.Control;
            txtEmploymentStatusQuestion.BorderStyle = BorderStyle.None;
            txtEmploymentStatusQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmploymentStatusQuestion.Location = new Point(17, 20);
            txtEmploymentStatusQuestion.Margin = new Padding(4, 5, 4, 5);
            txtEmploymentStatusQuestion.Multiline = true;
            txtEmploymentStatusQuestion.Name = "txtEmploymentStatusQuestion";
            txtEmploymentStatusQuestion.Size = new Size(360, 80);
            txtEmploymentStatusQuestion.TabIndex = 0;
            txtEmploymentStatusQuestion.Text = "What is your employment status?";
            // 
            // grpEmploymentStatus
            // 
            grpEmploymentStatus.Controls.Add(rbEmpPreferNo);
            grpEmploymentStatus.Controls.Add(rbEmpHomemaker);
            grpEmploymentStatus.Controls.Add(rbEmpUnemployed);
            grpEmploymentStatus.Controls.Add(rbEmpPartTime);
            grpEmploymentStatus.Controls.Add(rbEmpStudent);
            grpEmploymentStatus.Controls.Add(rbEmpNotLooking);
            grpEmploymentStatus.Controls.Add(rbEmpSelf);
            grpEmploymentStatus.Controls.Add(rbEmpFullTime);
            grpEmploymentStatus.Location = new Point(17, 108);
            grpEmploymentStatus.Margin = new Padding(4, 5, 4, 5);
            grpEmploymentStatus.Name = "grpEmploymentStatus";
            grpEmploymentStatus.Padding = new Padding(4, 5, 4, 5);
            grpEmploymentStatus.Size = new Size(421, 208);
            grpEmploymentStatus.TabIndex = 1;
            grpEmploymentStatus.TabStop = false;
            // 
            // rbEmpPreferNo
            // 
            rbEmpPreferNo.AutoSize = true;
            rbEmpPreferNo.Location = new Point(221, 157);
            rbEmpPreferNo.Margin = new Padding(4, 5, 4, 5);
            rbEmpPreferNo.Name = "rbEmpPreferNo";
            rbEmpPreferNo.Size = new Size(197, 29);
            rbEmpPreferNo.TabIndex = 7;
            rbEmpPreferNo.TabStop = true;
            rbEmpPreferNo.Text = "Prefer not to answer";
            rbEmpPreferNo.UseVisualStyleBackColor = true;
            rbEmpPreferNo.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // rbEmpHomemaker
            // 
            rbEmpHomemaker.AutoSize = true;
            rbEmpHomemaker.Location = new Point(221, 115);
            rbEmpHomemaker.Margin = new Padding(4, 5, 4, 5);
            rbEmpHomemaker.Name = "rbEmpHomemaker";
            rbEmpHomemaker.Size = new Size(135, 29);
            rbEmpHomemaker.TabIndex = 6;
            rbEmpHomemaker.TabStop = true;
            rbEmpHomemaker.Text = "Homemaker";
            rbEmpHomemaker.UseVisualStyleBackColor = true;
            // 
            // rbEmpUnemployed
            // 
            rbEmpUnemployed.AutoSize = true;
            rbEmpUnemployed.Location = new Point(221, 73);
            rbEmpUnemployed.Margin = new Padding(4, 5, 4, 5);
            rbEmpUnemployed.Name = "rbEmpUnemployed";
            rbEmpUnemployed.Size = new Size(139, 29);
            rbEmpUnemployed.TabIndex = 5;
            rbEmpUnemployed.TabStop = true;
            rbEmpUnemployed.Text = "Unemployed";
            rbEmpUnemployed.UseVisualStyleBackColor = true;
            // 
            // rbEmpPartTime
            // 
            rbEmpPartTime.AutoSize = true;
            rbEmpPartTime.Location = new Point(221, 32);
            rbEmpPartTime.Margin = new Padding(4, 5, 4, 5);
            rbEmpPartTime.Name = "rbEmpPartTime";
            rbEmpPartTime.Size = new Size(194, 29);
            rbEmpPartTime.TabIndex = 4;
            rbEmpPartTime.TabStop = true;
            rbEmpPartTime.Text = "Employed part time";
            rbEmpPartTime.UseVisualStyleBackColor = true;
            // 
            // rbEmpStudent
            // 
            rbEmpStudent.AutoSize = true;
            rbEmpStudent.Location = new Point(4, 157);
            rbEmpStudent.Margin = new Padding(4, 5, 4, 5);
            rbEmpStudent.Name = "rbEmpStudent";
            rbEmpStudent.Size = new Size(98, 29);
            rbEmpStudent.TabIndex = 3;
            rbEmpStudent.TabStop = true;
            rbEmpStudent.Text = "Student";
            rbEmpStudent.UseVisualStyleBackColor = true;
            // 
            // rbEmpNotLooking
            // 
            rbEmpNotLooking.AutoSize = true;
            rbEmpNotLooking.Location = new Point(4, 115);
            rbEmpNotLooking.Margin = new Padding(4, 5, 4, 5);
            rbEmpNotLooking.Name = "rbEmpNotLooking";
            rbEmpNotLooking.Size = new Size(205, 29);
            rbEmpNotLooking.TabIndex = 2;
            rbEmpNotLooking.TabStop = true;
            rbEmpNotLooking.Text = "Not looking for a job";
            rbEmpNotLooking.UseVisualStyleBackColor = true;
            // 
            // rbEmpSelf
            // 
            rbEmpSelf.AutoSize = true;
            rbEmpSelf.Location = new Point(4, 73);
            rbEmpSelf.Margin = new Padding(4, 5, 4, 5);
            rbEmpSelf.Name = "rbEmpSelf";
            rbEmpSelf.Size = new Size(153, 29);
            rbEmpSelf.TabIndex = 1;
            rbEmpSelf.TabStop = true;
            rbEmpSelf.Text = "Self-employed";
            rbEmpSelf.UseVisualStyleBackColor = true;
            // 
            // rbEmpFullTime
            // 
            rbEmpFullTime.AutoSize = true;
            rbEmpFullTime.Location = new Point(4, 32);
            rbEmpFullTime.Margin = new Padding(4, 5, 4, 5);
            rbEmpFullTime.Name = "rbEmpFullTime";
            rbEmpFullTime.Size = new Size(186, 29);
            rbEmpFullTime.TabIndex = 0;
            rbEmpFullTime.TabStop = true;
            rbEmpFullTime.Text = "Employed full time";
            rbEmpFullTime.UseVisualStyleBackColor = true;
            // 
            // txtEducationLevelQuestion
            // 
            txtEducationLevelQuestion.BackColor = SystemColors.Control;
            txtEducationLevelQuestion.BorderStyle = BorderStyle.None;
            txtEducationLevelQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEducationLevelQuestion.Location = new Point(527, 20);
            txtEducationLevelQuestion.Margin = new Padding(4, 5, 4, 5);
            txtEducationLevelQuestion.Multiline = true;
            txtEducationLevelQuestion.Name = "txtEducationLevelQuestion";
            txtEducationLevelQuestion.Size = new Size(597, 78);
            txtEducationLevelQuestion.TabIndex = 2;
            txtEducationLevelQuestion.Text = "What is the highest level of education you have completed?";
            txtEducationLevelQuestion.TextChanged += textBox1_TextChanged;
            // 
            // grpEducation
            // 
            grpEducation.Controls.Add(rbEduOther);
            grpEducation.Controls.Add(rbEduPreferNo);
            grpEducation.Controls.Add(rbEduMaster);
            grpEducation.Controls.Add(rbEduCollegeDiploma);
            grpEducation.Controls.Add(rbEduHighSchool);
            grpEducation.Controls.Add(rbEduDoctorate);
            grpEducation.Controls.Add(rbEduUndergrad);
            grpEducation.Controls.Add(rbEduSomeCollege);
            grpEducation.Controls.Add(rbEduLessHS);
            grpEducation.Location = new Point(525, 108);
            grpEducation.Margin = new Padding(4, 5, 4, 5);
            grpEducation.Name = "grpEducation";
            grpEducation.Padding = new Padding(4, 5, 4, 5);
            grpEducation.Size = new Size(599, 238);
            grpEducation.TabIndex = 3;
            grpEducation.TabStop = false;
            // 
            // rbEduOther
            // 
            rbEduOther.AutoSize = true;
            rbEduOther.Location = new Point(4, 198);
            rbEduOther.Margin = new Padding(4, 5, 4, 5);
            rbEduOther.Name = "rbEduOther";
            rbEduOther.Size = new Size(82, 29);
            rbEduOther.TabIndex = 8;
            rbEduOther.TabStop = true;
            rbEduOther.Text = "Other";
            rbEduOther.UseVisualStyleBackColor = true;
            // 
            // rbEduPreferNo
            // 
            rbEduPreferNo.AutoSize = true;
            rbEduPreferNo.Location = new Point(270, 157);
            rbEduPreferNo.Margin = new Padding(4, 5, 4, 5);
            rbEduPreferNo.Name = "rbEduPreferNo";
            rbEduPreferNo.Size = new Size(197, 29);
            rbEduPreferNo.TabIndex = 7;
            rbEduPreferNo.TabStop = true;
            rbEduPreferNo.Text = "Prefer not to answer";
            rbEduPreferNo.UseVisualStyleBackColor = true;
            rbEduPreferNo.CheckedChanged += radioButton9_CheckedChanged;
            // 
            // rbEduMaster
            // 
            rbEduMaster.AutoSize = true;
            rbEduMaster.Location = new Point(270, 115);
            rbEduMaster.Margin = new Padding(4, 5, 4, 5);
            rbEduMaster.Name = "rbEduMaster";
            rbEduMaster.Size = new Size(230, 29);
            rbEduMaster.TabIndex = 6;
            rbEduMaster.TabStop = true;
            rbEduMaster.Text = "Master/Graduate degree";
            rbEduMaster.UseVisualStyleBackColor = true;
            rbEduMaster.CheckedChanged += radioButton10_CheckedChanged;
            // 
            // rbEduCollegeDiploma
            // 
            rbEduCollegeDiploma.AutoSize = true;
            rbEduCollegeDiploma.Location = new Point(270, 73);
            rbEduCollegeDiploma.Margin = new Padding(4, 5, 4, 5);
            rbEduCollegeDiploma.Name = "rbEduCollegeDiploma";
            rbEduCollegeDiploma.Size = new Size(252, 29);
            rbEduCollegeDiploma.TabIndex = 5;
            rbEduCollegeDiploma.TabStop = true;
            rbEduCollegeDiploma.Text = "College diploma/Certificate";
            rbEduCollegeDiploma.UseVisualStyleBackColor = true;
            // 
            // rbEduHighSchool
            // 
            rbEduHighSchool.AutoSize = true;
            rbEduHighSchool.Location = new Point(270, 32);
            rbEduHighSchool.Margin = new Padding(4, 5, 4, 5);
            rbEduHighSchool.Name = "rbEduHighSchool";
            rbEduHighSchool.Size = new Size(132, 29);
            rbEduHighSchool.TabIndex = 4;
            rbEduHighSchool.TabStop = true;
            rbEduHighSchool.Text = "High school";
            rbEduHighSchool.UseVisualStyleBackColor = true;
            rbEduHighSchool.CheckedChanged += radioButton12_CheckedChanged;
            // 
            // rbEduDoctorate
            // 
            rbEduDoctorate.AutoSize = true;
            rbEduDoctorate.Location = new Point(4, 157);
            rbEduDoctorate.Margin = new Padding(4, 5, 4, 5);
            rbEduDoctorate.Name = "rbEduDoctorate";
            rbEduDoctorate.Size = new Size(116, 29);
            rbEduDoctorate.TabIndex = 3;
            rbEduDoctorate.TabStop = true;
            rbEduDoctorate.Text = "Doctorate";
            rbEduDoctorate.UseVisualStyleBackColor = true;
            // 
            // rbEduUndergrad
            // 
            rbEduUndergrad.AutoSize = true;
            rbEduUndergrad.Location = new Point(4, 115);
            rbEduUndergrad.Margin = new Padding(4, 5, 4, 5);
            rbEduUndergrad.Name = "rbEduUndergrad";
            rbEduUndergrad.Size = new Size(216, 29);
            rbEduUndergrad.TabIndex = 2;
            rbEduUndergrad.TabStop = true;
            rbEduUndergrad.Text = "Undergraduate degree";
            rbEduUndergrad.UseVisualStyleBackColor = true;
            // 
            // rbEduSomeCollege
            // 
            rbEduSomeCollege.AutoSize = true;
            rbEduSomeCollege.Location = new Point(4, 73);
            rbEduSomeCollege.Margin = new Padding(4, 5, 4, 5);
            rbEduSomeCollege.Name = "rbEduSomeCollege";
            rbEduSomeCollege.Size = new Size(228, 29);
            rbEduSomeCollege.TabIndex = 1;
            rbEduSomeCollege.TabStop = true;
            rbEduSomeCollege.Text = "Some college/University";
            rbEduSomeCollege.UseVisualStyleBackColor = true;
            // 
            // rbEduLessHS
            // 
            rbEduLessHS.AutoSize = true;
            rbEduLessHS.Location = new Point(4, 32);
            rbEduLessHS.Margin = new Padding(4, 5, 4, 5);
            rbEduLessHS.Name = "rbEduLessHS";
            rbEduLessHS.Size = new Size(207, 29);
            rbEduLessHS.TabIndex = 0;
            rbEduLessHS.TabStop = true;
            rbEduLessHS.Text = "Less than high school";
            rbEduLessHS.UseVisualStyleBackColor = true;
            // 
            // txtExerciseFrequencyQuestion
            // 
            txtExerciseFrequencyQuestion.BackColor = SystemColors.Control;
            txtExerciseFrequencyQuestion.BorderStyle = BorderStyle.None;
            txtExerciseFrequencyQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExerciseFrequencyQuestion.Location = new Point(11, 345);
            txtExerciseFrequencyQuestion.Margin = new Padding(4, 5, 4, 5);
            txtExerciseFrequencyQuestion.Name = "txtExerciseFrequencyQuestion";
            txtExerciseFrequencyQuestion.Size = new Size(340, 32);
            txtExerciseFrequencyQuestion.TabIndex = 4;
            txtExerciseFrequencyQuestion.Text = "How often do you exercise?";
            // 
            // rbExercise4
            // 
            rbExercise4.AutoSize = true;
            rbExercise4.Location = new Point(241, 32);
            rbExercise4.Margin = new Padding(4, 5, 4, 5);
            rbExercise4.Name = "rbExercise4";
            rbExercise4.Size = new Size(47, 29);
            rbExercise4.TabIndex = 7;
            rbExercise4.TabStop = true;
            rbExercise4.Text = "4";
            rbExercise4.UseVisualStyleBackColor = true;
            rbExercise4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rbExercise5
            // 
            rbExercise5.AutoSize = true;
            rbExercise5.Location = new Point(339, 32);
            rbExercise5.Margin = new Padding(4, 5, 4, 5);
            rbExercise5.Name = "rbExercise5";
            rbExercise5.Size = new Size(47, 29);
            rbExercise5.TabIndex = 8;
            rbExercise5.TabStop = true;
            rbExercise5.Text = "5";
            rbExercise5.UseVisualStyleBackColor = true;
            // 
            // rbExercise6
            // 
            rbExercise6.AutoSize = true;
            rbExercise6.Location = new Point(431, 32);
            rbExercise6.Margin = new Padding(4, 5, 4, 5);
            rbExercise6.Name = "rbExercise6";
            rbExercise6.Size = new Size(47, 29);
            rbExercise6.TabIndex = 9;
            rbExercise6.TabStop = true;
            rbExercise6.Text = "6";
            rbExercise6.UseVisualStyleBackColor = true;
            // 
            // rbExercise7
            // 
            rbExercise7.AutoSize = true;
            rbExercise7.Location = new Point(533, 32);
            rbExercise7.Margin = new Padding(4, 5, 4, 5);
            rbExercise7.Name = "rbExercise7";
            rbExercise7.Size = new Size(47, 29);
            rbExercise7.TabIndex = 10;
            rbExercise7.TabStop = true;
            rbExercise7.Text = "7";
            rbExercise7.UseVisualStyleBackColor = true;
            // 
            // rbExercise8
            // 
            rbExercise8.AutoSize = true;
            rbExercise8.Location = new Point(629, 32);
            rbExercise8.Margin = new Padding(4, 5, 4, 5);
            rbExercise8.Name = "rbExercise8";
            rbExercise8.Size = new Size(47, 29);
            rbExercise8.TabIndex = 11;
            rbExercise8.TabStop = true;
            rbExercise8.Text = "8";
            rbExercise8.UseVisualStyleBackColor = true;
            // 
            // rbExercise9
            // 
            rbExercise9.AutoSize = true;
            rbExercise9.Location = new Point(726, 32);
            rbExercise9.Margin = new Padding(4, 5, 4, 5);
            rbExercise9.Name = "rbExercise9";
            rbExercise9.Size = new Size(47, 29);
            rbExercise9.TabIndex = 12;
            rbExercise9.TabStop = true;
            rbExercise9.Text = "9";
            rbExercise9.UseVisualStyleBackColor = true;
            // 
            // rbExercise10
            // 
            rbExercise10.AutoSize = true;
            rbExercise10.Location = new Point(807, 32);
            rbExercise10.Margin = new Padding(4, 5, 4, 5);
            rbExercise10.Name = "rbExercise10";
            rbExercise10.Size = new Size(57, 29);
            rbExercise10.TabIndex = 13;
            rbExercise10.TabStop = true;
            rbExercise10.Text = "10";
            rbExercise10.UseVisualStyleBackColor = true;
            rbExercise10.CheckedChanged += radioButton19_CheckedChanged;
            // 
            // rbExercise3
            // 
            rbExercise3.AutoSize = true;
            rbExercise3.Location = new Point(157, 32);
            rbExercise3.Margin = new Padding(4, 5, 4, 5);
            rbExercise3.Name = "rbExercise3";
            rbExercise3.Size = new Size(47, 29);
            rbExercise3.TabIndex = 6;
            rbExercise3.TabStop = true;
            rbExercise3.Text = "3";
            rbExercise3.UseVisualStyleBackColor = true;
            // 
            // rbExercise1
            // 
            rbExercise1.AutoSize = true;
            rbExercise1.Location = new Point(4, 32);
            rbExercise1.Margin = new Padding(4, 5, 4, 5);
            rbExercise1.Name = "rbExercise1";
            rbExercise1.Size = new Size(47, 29);
            rbExercise1.TabIndex = 0;
            rbExercise1.TabStop = true;
            rbExercise1.Text = "1";
            rbExercise1.UseVisualStyleBackColor = true;
            // 
            // rbExercise2
            // 
            rbExercise2.AutoSize = true;
            rbExercise2.Location = new Point(83, 32);
            rbExercise2.Margin = new Padding(4, 5, 4, 5);
            rbExercise2.Name = "rbExercise2";
            rbExercise2.Size = new Size(47, 29);
            rbExercise2.TabIndex = 1;
            rbExercise2.TabStop = true;
            rbExercise2.Text = "2";
            rbExercise2.UseVisualStyleBackColor = true;
            rbExercise2.CheckedChanged += rbExercise2_CheckedChanged;
            // 
            // grpExerciseFrequency
            // 
            grpExerciseFrequency.Controls.Add(rbExercise10);
            grpExerciseFrequency.Controls.Add(rbExercise2);
            grpExerciseFrequency.Controls.Add(rbExercise9);
            grpExerciseFrequency.Controls.Add(rbExercise1);
            grpExerciseFrequency.Controls.Add(rbExercise8);
            grpExerciseFrequency.Controls.Add(rbExercise3);
            grpExerciseFrequency.Controls.Add(rbExercise7);
            grpExerciseFrequency.Controls.Add(rbExercise4);
            grpExerciseFrequency.Controls.Add(rbExercise6);
            grpExerciseFrequency.Controls.Add(rbExercise5);
            grpExerciseFrequency.Location = new Point(13, 387);
            grpExerciseFrequency.Margin = new Padding(4, 5, 4, 5);
            grpExerciseFrequency.Name = "grpExerciseFrequency";
            grpExerciseFrequency.Padding = new Padding(4, 5, 4, 5);
            grpExerciseFrequency.Size = new Size(893, 80);
            grpExerciseFrequency.TabIndex = 5;
            grpExerciseFrequency.TabStop = false;
            grpExerciseFrequency.Enter += grpExerciseFrequency_Enter;
            // 
            // txtExerciseScaleLow
            // 
            txtExerciseScaleLow.BackColor = SystemColors.Control;
            txtExerciseScaleLow.BorderStyle = BorderStyle.None;
            txtExerciseScaleLow.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExerciseScaleLow.Location = new Point(13, 460);
            txtExerciseScaleLow.Margin = new Padding(4, 5, 4, 5);
            txtExerciseScaleLow.Name = "txtExerciseScaleLow";
            txtExerciseScaleLow.Size = new Size(101, 24);
            txtExerciseScaleLow.TabIndex = 6;
            txtExerciseScaleLow.Text = "Not all often";
            // 
            // txtExerciseScaleHigh
            // 
            txtExerciseScaleHigh.BackColor = SystemColors.Control;
            txtExerciseScaleHigh.BorderStyle = BorderStyle.None;
            txtExerciseScaleHigh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExerciseScaleHigh.Location = new Point(776, 460);
            txtExerciseScaleHigh.Margin = new Padding(4, 5, 4, 5);
            txtExerciseScaleHigh.Name = "txtExerciseScaleHigh";
            txtExerciseScaleHigh.Size = new Size(128, 24);
            txtExerciseScaleHigh.TabIndex = 7;
            txtExerciseScaleHigh.Text = "Extremely often";
            // 
            // txtSportswearFrequency
            // 
            txtSportswearFrequency.BackColor = SystemColors.Control;
            txtSportswearFrequency.BorderStyle = BorderStyle.None;
            txtSportswearFrequency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSportswearFrequency.Location = new Point(11, 530);
            txtSportswearFrequency.Margin = new Padding(4, 5, 4, 5);
            txtSportswearFrequency.Name = "txtSportswearFrequency";
            txtSportswearFrequency.Size = new Size(582, 32);
            txtSportswearFrequency.TabIndex = 8;
            txtSportswearFrequency.Text = "How often do you use sportswear products?";
            // 
            // grpSportswearFrequency
            // 
            grpSportswearFrequency.Controls.Add(rbSportswear10);
            grpSportswearFrequency.Controls.Add(rbSportswear2);
            grpSportswearFrequency.Controls.Add(rbSportswear9);
            grpSportswearFrequency.Controls.Add(rbSportswear1);
            grpSportswearFrequency.Controls.Add(rbSportswear8);
            grpSportswearFrequency.Controls.Add(rbSportswear3);
            grpSportswearFrequency.Controls.Add(rbSportswear7);
            grpSportswearFrequency.Controls.Add(rbSportswear4);
            grpSportswearFrequency.Controls.Add(rbSportswear6);
            grpSportswearFrequency.Controls.Add(rbSportswear5);
            grpSportswearFrequency.Location = new Point(13, 588);
            grpSportswearFrequency.Margin = new Padding(4, 5, 4, 5);
            grpSportswearFrequency.Name = "grpSportswearFrequency";
            grpSportswearFrequency.Padding = new Padding(4, 5, 4, 5);
            grpSportswearFrequency.Size = new Size(893, 80);
            grpSportswearFrequency.TabIndex = 14;
            grpSportswearFrequency.TabStop = false;
            // 
            // rbSportswear10
            // 
            rbSportswear10.AutoSize = true;
            rbSportswear10.Location = new Point(807, 32);
            rbSportswear10.Margin = new Padding(4, 5, 4, 5);
            rbSportswear10.Name = "rbSportswear10";
            rbSportswear10.Size = new Size(57, 29);
            rbSportswear10.TabIndex = 13;
            rbSportswear10.TabStop = true;
            rbSportswear10.Text = "10";
            rbSportswear10.UseVisualStyleBackColor = true;
            // 
            // rbSportswear2
            // 
            rbSportswear2.AutoSize = true;
            rbSportswear2.Location = new Point(83, 32);
            rbSportswear2.Margin = new Padding(4, 5, 4, 5);
            rbSportswear2.Name = "rbSportswear2";
            rbSportswear2.Size = new Size(47, 29);
            rbSportswear2.TabIndex = 1;
            rbSportswear2.TabStop = true;
            rbSportswear2.Text = "2";
            rbSportswear2.UseVisualStyleBackColor = true;
            rbSportswear2.CheckedChanged += rbSportswear2_CheckedChanged;
            // 
            // rbSportswear9
            // 
            rbSportswear9.AutoSize = true;
            rbSportswear9.Location = new Point(726, 32);
            rbSportswear9.Margin = new Padding(4, 5, 4, 5);
            rbSportswear9.Name = "rbSportswear9";
            rbSportswear9.Size = new Size(47, 29);
            rbSportswear9.TabIndex = 12;
            rbSportswear9.TabStop = true;
            rbSportswear9.Text = "9";
            rbSportswear9.UseVisualStyleBackColor = true;
            // 
            // rbSportswear1
            // 
            rbSportswear1.AutoSize = true;
            rbSportswear1.Location = new Point(4, 32);
            rbSportswear1.Margin = new Padding(4, 5, 4, 5);
            rbSportswear1.Name = "rbSportswear1";
            rbSportswear1.Size = new Size(47, 29);
            rbSportswear1.TabIndex = 0;
            rbSportswear1.TabStop = true;
            rbSportswear1.Text = "1";
            rbSportswear1.UseVisualStyleBackColor = true;
            // 
            // rbSportswear8
            // 
            rbSportswear8.AutoSize = true;
            rbSportswear8.Location = new Point(629, 32);
            rbSportswear8.Margin = new Padding(4, 5, 4, 5);
            rbSportswear8.Name = "rbSportswear8";
            rbSportswear8.Size = new Size(47, 29);
            rbSportswear8.TabIndex = 11;
            rbSportswear8.TabStop = true;
            rbSportswear8.Text = "8";
            rbSportswear8.UseVisualStyleBackColor = true;
            // 
            // rbSportswear3
            // 
            rbSportswear3.AutoSize = true;
            rbSportswear3.Location = new Point(157, 32);
            rbSportswear3.Margin = new Padding(4, 5, 4, 5);
            rbSportswear3.Name = "rbSportswear3";
            rbSportswear3.Size = new Size(47, 29);
            rbSportswear3.TabIndex = 6;
            rbSportswear3.TabStop = true;
            rbSportswear3.Text = "3";
            rbSportswear3.UseVisualStyleBackColor = true;
            // 
            // rbSportswear7
            // 
            rbSportswear7.AutoSize = true;
            rbSportswear7.Location = new Point(533, 32);
            rbSportswear7.Margin = new Padding(4, 5, 4, 5);
            rbSportswear7.Name = "rbSportswear7";
            rbSportswear7.Size = new Size(47, 29);
            rbSportswear7.TabIndex = 10;
            rbSportswear7.TabStop = true;
            rbSportswear7.Text = "7";
            rbSportswear7.UseVisualStyleBackColor = true;
            // 
            // rbSportswear4
            // 
            rbSportswear4.AutoSize = true;
            rbSportswear4.Location = new Point(241, 32);
            rbSportswear4.Margin = new Padding(4, 5, 4, 5);
            rbSportswear4.Name = "rbSportswear4";
            rbSportswear4.Size = new Size(47, 29);
            rbSportswear4.TabIndex = 7;
            rbSportswear4.TabStop = true;
            rbSportswear4.Text = "4";
            rbSportswear4.UseVisualStyleBackColor = true;
            // 
            // rbSportswear6
            // 
            rbSportswear6.AutoSize = true;
            rbSportswear6.Location = new Point(431, 32);
            rbSportswear6.Margin = new Padding(4, 5, 4, 5);
            rbSportswear6.Name = "rbSportswear6";
            rbSportswear6.Size = new Size(47, 29);
            rbSportswear6.TabIndex = 9;
            rbSportswear6.TabStop = true;
            rbSportswear6.Text = "6";
            rbSportswear6.UseVisualStyleBackColor = true;
            // 
            // rbSportswear5
            // 
            rbSportswear5.AutoSize = true;
            rbSportswear5.Location = new Point(339, 32);
            rbSportswear5.Margin = new Padding(4, 5, 4, 5);
            rbSportswear5.Name = "rbSportswear5";
            rbSportswear5.Size = new Size(47, 29);
            rbSportswear5.TabIndex = 8;
            rbSportswear5.TabStop = true;
            rbSportswear5.Text = "5";
            rbSportswear5.UseVisualStyleBackColor = true;
            // 
            // txtSportswearScaleLow
            // 
            txtSportswearScaleLow.BackColor = SystemColors.Control;
            txtSportswearScaleLow.BorderStyle = BorderStyle.None;
            txtSportswearScaleLow.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSportswearScaleLow.Location = new Point(13, 662);
            txtSportswearScaleLow.Margin = new Padding(4, 5, 4, 5);
            txtSportswearScaleLow.Name = "txtSportswearScaleLow";
            txtSportswearScaleLow.Size = new Size(101, 24);
            txtSportswearScaleLow.TabIndex = 15;
            txtSportswearScaleLow.Text = "Not all often";
            // 
            // txtSportswearScaleHigh
            // 
            txtSportswearScaleHigh.BackColor = SystemColors.Control;
            txtSportswearScaleHigh.BorderStyle = BorderStyle.None;
            txtSportswearScaleHigh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSportswearScaleHigh.Location = new Point(776, 662);
            txtSportswearScaleHigh.Margin = new Padding(4, 5, 4, 5);
            txtSportswearScaleHigh.Name = "txtSportswearScaleHigh";
            txtSportswearScaleHigh.Size = new Size(128, 24);
            txtSportswearScaleHigh.TabIndex = 16;
            txtSportswearScaleHigh.Text = "Extremely often";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1019, 692);
            btnNext.Margin = new Padding(4, 5, 4, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 38);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1019, 643);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 38);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(txtSportswearScaleHigh);
            Controls.Add(txtSportswearScaleLow);
            Controls.Add(grpSportswearFrequency);
            Controls.Add(txtSportswearFrequency);
            Controls.Add(txtExerciseScaleHigh);
            Controls.Add(txtExerciseScaleLow);
            Controls.Add(grpExerciseFrequency);
            Controls.Add(txtExerciseFrequencyQuestion);
            Controls.Add(grpEducation);
            Controls.Add(txtEducationLevelQuestion);
            Controls.Add(grpEmploymentStatus);
            Controls.Add(txtEmploymentStatusQuestion);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            grpEmploymentStatus.ResumeLayout(false);
            grpEmploymentStatus.PerformLayout();
            grpEducation.ResumeLayout(false);
            grpEducation.PerformLayout();
            grpExerciseFrequency.ResumeLayout(false);
            grpExerciseFrequency.PerformLayout();
            grpSportswearFrequency.ResumeLayout(false);
            grpSportswearFrequency.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmploymentStatusQuestion;
        private GroupBox grpEmploymentStatus;
        private RadioButton rbEmpPreferNo;
        private RadioButton rbEmpHomemaker;
        private RadioButton rbEmpUnemployed;
        private RadioButton rbEmpPartTime;
        private RadioButton rbEmpStudent;
        private RadioButton rbEmpNotLooking;
        private RadioButton rbEmpSelf;
        private RadioButton rbEmpFullTime;
        private TextBox txtEducationLevelQuestion;
        private GroupBox grpEducation;
        private RadioButton rbEduOther;
        private RadioButton rbEduPreferNo;
        private RadioButton rbEduMaster;
        private RadioButton rbEduCollegeDiploma;
        private RadioButton rbEduHighSchool;
        private RadioButton rbEduDoctorate;
        private RadioButton rbEduUndergrad;
        private RadioButton rbEduSomeCollege;
        private RadioButton rbEduLessHS;
        private TextBox txtExerciseFrequencyQuestion;
        private RadioButton rbExercise4;
        private RadioButton rbExercise5;
        private RadioButton rbExercise6;
        private RadioButton rbExercise7;
        private RadioButton rbExercise8;
        private RadioButton rbExercise9;
        private RadioButton rbExercise10;
        private RadioButton rbExercise3;
        private RadioButton rbExercise1;
        private RadioButton rbExercise2;
        private GroupBox grpExerciseFrequency;
        private TextBox txtExerciseScaleLow;
        private TextBox txtExerciseScaleHigh;
        private TextBox txtSportswearFrequency;
        private GroupBox grpSportswearFrequency;
        private RadioButton rbSportswear10;
        private RadioButton rbSportswear2;
        private RadioButton rbSportswear9;
        private RadioButton rbSportswear1;
        private RadioButton rbSportswear8;
        private RadioButton rbSportswear3;
        private RadioButton rbSportswear7;
        private RadioButton rbSportswear4;
        private RadioButton rbSportswear6;
        private RadioButton rbSportswear5;
        private TextBox txtSportswearScaleLow;
        private TextBox txtSportswearScaleHigh;
        private Button btnNext;
        private Button btnBack;
    }
}