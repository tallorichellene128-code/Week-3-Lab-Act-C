using System;
using System.Windows.Forms;

namespace lab_act_C
{
    public partial class Form5 : Form
    {
        private Form previousForm; 

        public Form5(Form callingForm)
        {
            InitializeComponent();
            previousForm = callingForm;
            AttachEvents();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void AttachEvents()
        {
            btnBack.Click += BtnBack_Click;
            btnNext.Click += BtnNext_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
            previousForm.Show(); 
            this.Hide();         
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
           
            Form6 form6 = new Form6();
            form6.Show();

            this.Close(); 
        }
    }
}
