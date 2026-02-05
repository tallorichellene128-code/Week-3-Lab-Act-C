using System;
using System.Text;
using System.Windows.Forms;

namespace lab_act_C
{
    public partial class Form6 : Form
    {
        private Form previousForm;

        public Form6()
        {
            InitializeComponent();
            AttachEvents();
        }

        public Form6(Form callingForm) : this()
        {
            previousForm = callingForm;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void AttachEvents()
        {
            btnBack.Click += BtnBack_Click;
            btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();
                this.Close();
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            SurveyData.BrandTrait = GetCheckedItems(clbBrandTrait);
            SurveyData.Interest = GetCheckedItems(clbInterest);
            SurveyData.Email = txtEmail.Text;

            StringBuilder result = new StringBuilder();

            result.AppendLine("===== SURVEY RESULTS =====\n");

            result.AppendLine("FORM 1");
            result.AppendLine($"Gender: {SurveyData.Gender}");
            result.AppendLine($"Age: {SurveyData.Age}");
            result.AppendLine($"Marital Status: {SurveyData.MaritalStatus}");
            result.AppendLine($"Income: {SurveyData.Income}\n");

            result.AppendLine("FORM 2");
            result.AppendLine($"Employment Status: {SurveyData.EmploymentStatus}");
            result.AppendLine($"Education Level: {SurveyData.EducationLevel}");
            result.AppendLine($"Exercise Frequency: {SurveyData.ExerciseFrequency}");
            result.AppendLine($"Sportswear Purchase Frequency: {SurveyData.SportswearFrequency}\n");

            result.AppendLine("FORM 3");
            result.AppendLine($"Last Purchase: {SurveyData.LastBuy}");
            result.AppendLine($"Purchase Purpose: {SurveyData.PurchasePurpose}");
            result.AppendLine($"Purchase Location: {SurveyData.PurchaseLocation}\n");

            result.AppendLine("FORM 4");
            result.AppendLine($"Preferred Design: {SurveyData.BrandTraits}");
            result.AppendLine($"Brand Influence: {SurveyData.Interests}\n");

            result.AppendLine("FORM 5 (Material Ratings)");
            result.AppendLine($"Water Resistance: {SurveyData.WaterResistance}");
            result.AppendLine($"Cooling: {SurveyData.Cooling}");
            result.AppendLine($"Anti-Bacterial: {SurveyData.AntiBacterial}");
            result.AppendLine($"Soft & Smooth: {SurveyData.SoftSmooth}");
            result.AppendLine($"Endurance: {SurveyData.Endurance}");
            result.AppendLine($"Anti-Odour: {SurveyData.AntiOdour}");
            result.AppendLine($"Elasticity: {SurveyData.Elasticity}\n");

            result.AppendLine("FORM 6");
            result.AppendLine($"Brand Personality: {SurveyData.BrandTrait}");
            result.AppendLine($"Other Interests: {SurveyData.Interest}");
            result.AppendLine($"Email: {SurveyData.Email}");

            MessageBox.Show(
                result.ToString(),
                "Survey Results",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Application.Exit();
        }

        private string GetCheckedItems(CheckedListBox clb)
        {
            if (clb.CheckedItems.Count == 0)
                return "None";

            StringBuilder sb = new StringBuilder();
            foreach (var item in clb.CheckedItems)
            {
                sb.Append(item.ToString() + ", ");
            }

            return sb.ToString().TrimEnd(',', ' ');
        }
    }
}
