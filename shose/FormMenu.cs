using shose.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shose
{
    public partial class FormMenu : Form
    {

        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormMenu(User users, bool guest)
        {
            InitializeComponent();

            CurrentUser = users;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;
        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            FormOrders form = new FormOrders(CurrentUser, IsGuest);
            if (this.WindowState == FormWindowState.Maximized)
            { form.WindowState = FormWindowState.Maximized; }

            form.Show();

            this.Hide();

            // Когда MainForm закроется, закрыть и FormStart
            form.FormClosed += (s, args) => {
                if (form.CurrentUser != null || IsGuest)
                {
                    this.Show();

                }
                else
                {
                    this.Close();
                }
            };
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {


            FormProducts form = new FormProducts(CurrentUser, IsGuest);
            if (this.WindowState == FormWindowState.Maximized)
            { form.WindowState = FormWindowState.Maximized; }

            form.Show();

            this.Hide();

            // Когда MainForm закроется, закрыть и FormStart
            form.FormClosed += (s, args) => {
                if (form.CurrentUser != null)
                {
                    this.Show();

                }
                else
                {
                    this.Close();
                }
            };


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
