using System;
using System.Linq;
using System.Windows.Forms;

namespace lab_act_C
{
    public partial class Form3 : Form
    {
        private Form4 form4Instance;

        public Form3()
        {
            InitializeComponent();

            this.Load += Form3_Load;
            btnNext.Click += BtnNext_Click;
            btnBack.Click += BtnBack_Click;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtQueLastBuy.Text = "When did you last buy a sportswear?";
            txtQuePurpose.Text = "Which of the followings would describe your purpose to buy sportswear?";
            txtQueLocation.Text = "Where do you usually buy your sportswear from?";

            txtQueLastBuy.ReadOnly = true;
            txtQuePurpose.ReadOnly = true;
            txtQueLocation.ReadOnly = true;

            if (!string.IsNullOrEmpty(SurveyData.LastBuy))
            {
                switch (SurveyData.LastBuy)
                {
                    case "Within 1 month":
                        rbLessMonth.Checked = true;
                        break;
                    case "Within 6 month":
                        rb1_6.Checked = true;
                        break;
                    case "Within 1 year":
                        rb6to1YearAgo.Checked = true;
                        break;
                    case "More than 1 year":
                        rbMoreYear.Checked = true;
                        break;
                     case "Not specified":
                        rbNotRemember.Checked = true;
                        break;
                }
            }

            if (!string.IsNullOrEmpty(SurveyData.PurchasePurpose))
            {
                var selectedPurposes = SurveyData.PurchasePurpose.Split(',').Select(s => s.Trim()).ToArray();
                for (int i = 0; i < clbPurpose.Items.Count; i++)
                {
                    if (selectedPurposes.Contains(clbPurpose.Items[i].ToString()))
                        clbPurpose.SetItemChecked(i, true);
                }
            }

            if (!string.IsNullOrEmpty(SurveyData.PurchaseLocation))
            {
                clbLocation.Text = SurveyData.PurchaseLocation;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (rbLessMonth.Checked)
                SurveyData.LastBuy = "Within 1 month";
            else if (rbLessMonth.Checked)
                SurveyData.LastBuy = "Within 6 months";
            else if (rb6to1YearAgo.Checked)
                SurveyData.LastBuy = "Within 1 year";
            else if (rbMoreYear.Checked)
                SurveyData.LastBuy = "More than 1 year";
            else
                SurveyData.LastBuy = "Not specified";

            var selectedPurposes = clbPurpose.CheckedItems.Cast<string>();
            SurveyData.PurchasePurpose = string.Join(", ", selectedPurposes);

            SurveyData.PurchaseLocation = clbLocation.Text.Trim();

            if (form4Instance == null || form4Instance.IsDisposed)
                form4Instance = new Form4(this);

            form4Instance.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        

        private void Form3_Load_1(object sender, EventArgs e) { }
    }
}
