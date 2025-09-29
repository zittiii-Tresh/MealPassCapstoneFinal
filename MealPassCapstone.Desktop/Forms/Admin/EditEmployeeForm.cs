using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MealPassCapstone.Desktop.Helpers;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class EditEmployeeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string username;
        public EditEmployeeForm(string selectedUsername)
        {
            InitializeComponent();
            username = selectedUsername;
        }

        private void changepasswordHLBL_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Admin.EditPasswordForm());
        }
    }
}