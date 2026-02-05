using System;
using System.Linq;
using System.Windows.Forms;

namespace lab_act_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Market Research Survey";
            this.StartPosition = FormStartPosition.CenterScreen;

            txtTitle.ReadOnly = true;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.TextAlign = HorizontalAlignment.Center;

            txtSubtitle.ReadOnly = true;
            txtSubtitle.BorderStyle = BorderStyle.None;
            txtSubtitle.TextAlign = HorizontalAlignment.Center;

            SetQuestionTextBox(txtQuestionGender);
            SetQuestionTextBox(txtQuestionMaritalStatus);
            SetQuestionTextBox(txtQuestionAgeRange);
            SetQuestionTextBox(txtQuestionIncomeRange);

            btnNext.Click += BtnNext_Click;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            SurveyData.Gender = GetSelected(grpGender);
            SurveyData.MaritalStatus = GetSelected(grpMaritalStatus);
            SurveyData.Age = GetSelected(grpAgeRange);
            SurveyData.Income = GetSelected(grpIncomeRange);

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void SetQuestionTextBox(TextBox txt)
        {
            txt.ReadOnly = true;
            txt.BorderStyle = BorderStyle.None;
        }

        private string GetSelected(GroupBox group)
        {
            var selected = group.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            return selected != null ? selected.Text : "Not selected";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void rbGenderFemale_CheckedChanged(object sender, EventArgs e) { }
    }
}
