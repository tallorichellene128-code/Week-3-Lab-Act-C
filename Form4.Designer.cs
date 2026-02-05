namespace lab_act_C
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

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
            txtDesignQuestion = new TextBox();
            clbDesign = new CheckedListBox();
            txtDecisionQuestion = new TextBox();
            clbDecision = new CheckedListBox();
            btnNext = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtDesignQuestion
            // 
            txtDesignQuestion.BackColor = SystemColors.Control;
            txtDesignQuestion.BorderStyle = BorderStyle.None;
            txtDesignQuestion.Font = new Font("Segoe UI", 12F);
            txtDesignQuestion.Location = new Point(17, 25);
            txtDesignQuestion.Name = "txtDesignQuestion";
            txtDesignQuestion.ReadOnly = true;
            txtDesignQuestion.Size = new Size(572, 32);
            txtDesignQuestion.TabIndex = 0;
            txtDesignQuestion.Text = "What is your preferred design for sportswear?";
            // 
            // clbDesign
            // 
            clbDesign.Font = new Font("Segoe UI", 12F);
            clbDesign.FormattingEnabled = true;
            clbDesign.Items.AddRange(new object[] { "Minimalist (with 1 or 2 colors)", "With slogans and pictures on", "Bold colors and design (e.g. neon colors)", "Other" });
            clbDesign.Location = new Point(17, 75);
            clbDesign.Name = "clbDesign";
            clbDesign.Size = new Size(473, 148);
            clbDesign.TabIndex = 1;
            // 
            // txtDecisionQuestion
            // 
            txtDecisionQuestion.BackColor = SystemColors.Control;
            txtDecisionQuestion.BorderStyle = BorderStyle.None;
            txtDecisionQuestion.Font = new Font("Segoe UI", 12F);
            txtDecisionQuestion.Location = new Point(17, 230);
            txtDecisionQuestion.Name = "txtDecisionQuestion";
            txtDecisionQuestion.ReadOnly = true;
            txtDecisionQuestion.Size = new Size(911, 32);
            txtDecisionQuestion.TabIndex = 2;
            txtDecisionQuestion.Text = "Which of the following would influence your decision to buy a certain brand?";
            // 
            // clbDecision
            // 
            clbDecision.Font = new Font("Segoe UI", 12F);
            clbDecision.FormattingEnabled = true;
            clbDecision.Items.AddRange(new object[] { "Price", "Value", "Quality", "Brand", "Other" });
            clbDecision.Location = new Point(17, 280);
            clbDecision.Name = "clbDecision";
            clbDecision.Size = new Size(473, 184);
            clbDecision.TabIndex = 3;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(764, 480);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 38);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(764, 436);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 38);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 542);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(clbDecision);
            Controls.Add(txtDecisionQuestion);
            Controls.Add(clbDesign);
            Controls.Add(txtDesignQuestion);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDesignQuestion;
        private System.Windows.Forms.CheckedListBox clbDesign;
        private System.Windows.Forms.TextBox txtDecisionQuestion;
        private System.Windows.Forms.CheckedListBox clbDecision;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
    }
}
