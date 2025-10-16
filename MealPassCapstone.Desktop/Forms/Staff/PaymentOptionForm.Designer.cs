namespace MealPassCapstone.Desktop.Forms.Staff
{
    partial class PaymentOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOptionForm));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            mealpassBTN = new DevExpress.XtraEditors.SimpleButton();
            cashBTN = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(86, 28);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(179, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "How would you like to pay?";
            // 
            // mealpassBTN
            // 
            mealpassBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(56, 107, 60);
            mealpassBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            mealpassBTN.Appearance.Options.UseBackColor = true;
            mealpassBTN.Appearance.Options.UseFont = true;
            mealpassBTN.Location = new System.Drawing.Point(33, 67);
            mealpassBTN.Name = "mealpassBTN";
            mealpassBTN.Size = new System.Drawing.Size(121, 31);
            mealpassBTN.TabIndex = 8;
            mealpassBTN.Text = "MealPass";
            mealpassBTN.Click += mealpassBTN_Click;
            // 
            // cashBTN
            // 
            cashBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(56, 107, 60);
            cashBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cashBTN.Appearance.Options.UseBackColor = true;
            cashBTN.Appearance.Options.UseFont = true;
            cashBTN.Location = new System.Drawing.Point(196, 67);
            cashBTN.Name = "cashBTN";
            cashBTN.Size = new System.Drawing.Size(121, 31);
            cashBTN.TabIndex = 9;
            cashBTN.Text = "Cash";
            cashBTN.Click += cashBTN_Click;
            // 
            // PaymentOptionForm
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(352, 128);
            Controls.Add(cashBTN);
            Controls.Add(mealpassBTN);
            Controls.Add(labelControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("PaymentOptionForm.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentOptionForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Payment Option";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton mealpassBTN;
        private DevExpress.XtraEditors.SimpleButton cashBTN;
    }
}