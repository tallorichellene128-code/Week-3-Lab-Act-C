using System;
using System.Linq;
using System.Windows.Forms;

namespace lab_act_C
{
    public partial class Form4 : Form
    {
        private Form previousForm; 

        public Form4(Form callingForm)
        {
            InitializeComponent();
            previousForm = callingForm; 
            AttachEvents();
        }

        private void AttachEvents()
        {
            btnBack.Click += BtnBack_Click;
            btnNext.Click += BtnNext_Click;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SurveyData.BrandTrait))
            {
                var selectedDesigns = SurveyData.BrandTrait.Split(',').Select(s => s.Trim()).ToArray();
                for (int i = 0; i < clbDesign.Items.Count; i++)
                {
                    if (selectedDesigns.Contains(clbDesign.Items[i].ToString()))
                        clbDesign.SetItemChecked(i, true);
                }
            }

            if (!string.IsNullOrEmpty(SurveyData.Interest))
            {
                var selectedDecisions = SurveyData.Interest .Split(',').Select(s => s.Trim()).ToArray();
                for (int i = 0; i < clbDecision.Items.Count; i++)
                {
                    if (selectedDecisions.Contains(clbDecision.Items[i].ToString()))
                        clbDecision.SetItemChecked(i, true);
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        { 
            var selectedDesigns = clbDesign.CheckedItems.Cast<string>();
            SurveyData.BrandTrait = string.Join(", ", selectedDesigns);

            var selectedDecisions = clbDecision.CheckedItems.Cast<string>();
            SurveyData.Interest = string.Join(", ", selectedDecisions);

            Form5 form5 = new Form5(this);
            form5.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

     
    }
}
