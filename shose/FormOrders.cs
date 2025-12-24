using Microsoft.EntityFrameworkCore;
using shose.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace shose
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrders(User users, bool guest)
        {
            InitializeComponent();

            var colInfo = new DataGridViewTextBoxColumn();

            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            var colDeliveryDate = new DataGridViewTextBoxColumn();

            colDeliveryDate.Name = "colDeliveryDate";
            colDeliveryDate.FillWeight = 10;
            colDeliveryDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvOrders.Columns.AddRange(
                [
                    colInfo, colDeliveryDate
                ]
            );

            CurrentUser = users;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var orders = db.Orders.Include(i => i.ProductsOrders).ThenInclude(i => i.Product).
                        Include(i => i.DeliveryPoint).
                        Include(i => i.Status).
                        ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        string info = FormatOrdersInfo(order);

                        if (info != null)
                        {

                            int rowIndex = dgvOrders.Rows.Add();
                            var row = dgvOrders.Rows[rowIndex];


                            row.Cells["colInfo"].Value = info;//---------------------------------------

                            row.Cells["colDeliveryDate"].Value = order.DeliveryDate.ToString();

                            //ApplyRowStyles(row, product);
                        }
                        dgvOrders.ResumeLayout();
                        dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string FormatOrdersInfo(Order order)
        {
            string articleText = "";

            foreach (var product in order.ProductsOrders)
            {
                if (product.IdOrder == order.Id)
                {
                    articleText += product.Product.Art + ", ";

                }
                ;
            }
            if (string.IsNullOrEmpty(articleText)) { return null; }


            articleText = articleText.Remove(articleText.Length -2)+"";

            return
            $"Артикул заказа: {articleText}" + Environment.NewLine +//--------
            $"Статус заказ: {order.Status.StatusName}" + Environment.NewLine +
            $"Адрис пунка выдачи: {order.DeliveryPoint.DeliveryAddress}" + Environment.NewLine +
            $"Дата заказа: {order.OrderDate}" + Environment.NewLine;
        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {

            IsGuest = false;
            CurrentUser = null;

            // Когда MainForm закроется, закрыть и FormStart
            this.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
