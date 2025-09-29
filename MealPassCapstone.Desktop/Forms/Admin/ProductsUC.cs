using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class ProductsUC : DevExpress.XtraEditors.XtraUserControl
    {
        public ProductsUC()
        {
            InitializeComponent();
        }

        private void addproductBTN_Click(object sender, EventArgs e)
        {
            Helpers.FormHelper.DisplayForm(new AddProductForm());
        }
    }
}
