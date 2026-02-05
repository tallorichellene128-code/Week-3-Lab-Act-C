using System;
using System.Windows.Forms;

namespace lab_act_C
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Load += Form2_Load;
            btnNext.Click += BtnNext_Click;
            btnBack.Click += BtnBack_Click;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MakeTextBoxReadOnly(txtEmploymentStatusQuestion);
            MakeTextBoxReadOnly(txtEducationLevelQuestion);
            MakeTextBoxReadOnly(txtExerciseFrequencyQuestion);
            MakeTextBoxReadOnly(txtSportswearFrequency);

            MakeTextBoxReadOnly(txtExerciseScaleLow);
            MakeTextBoxReadOnly(txtExerciseScaleHigh);
            MakeTextBoxReadOnly(txtSportswearScaleLow);
            MakeTextBoxReadOnly(txtSportswearScaleHigh);
        }

        private void MakeTextBoxReadOnly(TextBox txt)
        {
            txt.ReadOnly = true;
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = this.BackColor;
            txt.TabStop = false;
        }

        private string GetSelectedRadioText(GroupBox group)
        {
            foreach (RadioButton rb in group.Controls)
            {
                if (rb.Checked)
                    return rb.Text;
            }
            return "Not selected";
        }

        private int GetSelectedRating(GroupBox group)
        {
            foreach (RadioButton rb in group.Controls)
            {
                if (rb.Checked && rb.Tag != null)
                    return int.Parse(rb.Tag.ToString());
            }
            return 0;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            SurveyData.EmploymentStatus = GetSelectedRadioText(grpEmploymentStatus);
            SurveyData.EducationLevel = GetSelectedRadioText(grpEducation);
            SurveyData.ExerciseFrequency = GetSelectedRadioText(grpExerciseFrequency);
            SurveyData.SportswearFrequency = GetSelectedRadioText(grpSportswearFrequency);

            Form3 form3 = new Form3();
            form3.Show();

            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton10_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton9_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton12_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton18_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton19_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void grpExerciseFrequency_Enter(object sender, EventArgs e)
        {

        }

        private void rbExercise2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSportswear2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
