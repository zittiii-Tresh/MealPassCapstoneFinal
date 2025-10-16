﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MealPass.Data.Repositories;
using MealPassCapstone.Desktop.Helpers;

namespace MealPassCapstone.Desktop.Forms.Staff
{
    public partial class PosUC : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ProductRepository _productRepo = new ProductRepository();
        public PosUC()
        {
            InitializeComponent();
            Cancel.ColumnEdit = repositoryItemCancelBTN; // <-- important
            this.Load += PosUC_LoadAsync;
        }
        private async void PosUC_LoadAsync(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }
        private async Task LoadProductsAsync()
        {
            var dataTable = await _productRepo.LoadProductsAsync();
            productsGC.DataSource = dataTable;
        }

        private void addtocartBTN_Click(object sender, EventArgs e)
        {
            int selectedRow = productsGV.FocusedRowHandle;
            if (selectedRow < 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            string productID = productsGV.GetRowCellValue(selectedRow, "ProductID")?.ToString();
            string productName = productsGV.GetRowCellValue(selectedRow, "ProductName")?.ToString();
            string priceStr = productsGV.GetRowCellValue(selectedRow, "Price")?.ToString();
            decimal price = decimal.TryParse(priceStr, out decimal p) ? p : 0;
            int quantity = 1;
            decimal total = price * quantity;

            // ✅ Ensure your cart table schema matches your grid field names
            DataTable cartTable = cartGC.DataSource as DataTable;
            if (cartTable == null)
            {
                cartTable = new DataTable();
                cartTable.Columns.Add("ID");
                cartTable.Columns.Add("ProductName");
                cartTable.Columns.Add("Quantity", typeof(int));
                cartTable.Columns.Add("Price", typeof(decimal));
                cartTable.Columns.Add("Total", typeof(decimal));
                cartGC.DataSource = cartTable;
            }

            // ✅ Add new item
            DataRow newRow = cartTable.NewRow();
            newRow["ID"] = productID;
            newRow["ProductName"] = productName;
            newRow["Quantity"] = quantity;
            newRow["Price"] = price;
            newRow["Total"] = total;
            cartTable.Rows.Add(newRow);

            UpdateTotalAmount(cartTable);
        }

        private void UpdateTotalAmount(DataTable cartTable)
        {
            decimal sum = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                if (decimal.TryParse(row["Total"]?.ToString(), out decimal total))
                {
                    sum += total;
                }
            }
            grandtotalLBL.Text = sum.ToString("N2");
        }

        private void cartGV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Quantity" || e.Column.FieldName == "Price")
            {
                int rowHandle = e.RowHandle;
                object quantityObj = cartGV.GetRowCellValue(rowHandle, "Quantity");
                object priceObj = cartGV.GetRowCellValue(rowHandle, "Price");

                if (int.TryParse(quantityObj?.ToString(), out int quantity) &&
                    decimal.TryParse(priceObj?.ToString(), out decimal price))
                {
                    decimal total = quantity * price;
                    cartGV.SetRowCellValue(rowHandle, "Total", total);

                    if (cartGC.DataSource is DataTable cartTable)
                    {
                        UpdateTotalAmount(cartTable);
                    }
                }
            }
        }

        private void repositoryItemCancelBTN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var editor = sender as DevExpress.XtraEditors.ButtonEdit;
            if (editor == null) return;

            var view = cartGV;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle < 0) return;

            string id = view.GetRowCellValue(rowHandle, "ID")?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            if (cartGC.DataSource is DataTable cartTable)
            {
              
                var rowsToRemove = cartTable.AsEnumerable()
                    .Where(r => r["ID"].ToString() == id)
                    .ToList();

                int deletedCount = rowsToRemove.Count;

                foreach (var row in rowsToRemove)
                    cartTable.Rows.Remove(row);

                UpdateTotalAmount(cartTable);
                view.RefreshData();
            }
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.PaymentOptionForm());
        }
    }
}
