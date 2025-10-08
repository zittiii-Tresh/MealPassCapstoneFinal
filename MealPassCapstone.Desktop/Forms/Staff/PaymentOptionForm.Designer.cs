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
            confirmBTN = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            // confirmBTN
            // 
            confirmBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(56, 107, 60);
            confirmBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            confirmBTN.Appearance.Options.UseBackColor = true;
            confirmBTN.Appearance.Options.UseFont = true;
            confirmBTN.Location = new System.Drawing.Point(33, 67);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new System.Drawing.Size(121, 31);
            confirmBTN.TabIndex = 8;
            confirmBTN.Text = "MealPass";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(56, 107, 60);
            simpleButton1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new System.Drawing.Point(196, 67);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(121, 31);
            simpleButton1.TabIndex = 9;
            simpleButton1.Text = "Cash";
            // 
            // PaymentOptionForm
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(352, 130);
            Controls.Add(simpleButton1);
            Controls.Add(confirmBTN);
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
        private DevExpress.XtraEditors.SimpleButton confirmBTN;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}