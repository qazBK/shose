namespace shose
{
    partial class FormMenu
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
            lblUserName = new Label();
            btnLogut = new Button();
            panelTop = new Panel();
            buttonBack = new Button();
            panel1 = new Panel();
            btnProducts = new Button();
            btnOrders = new Button();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(529, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogut
            // 
            btnLogut.BackColor = Color.MediumSpringGreen;
            btnLogut.Dock = DockStyle.Right;
            btnLogut.FlatAppearance.BorderSize = 0;
            btnLogut.FlatStyle = FlatStyle.Flat;
            btnLogut.Font = new Font("Times New Roman", 14.25F);
            btnLogut.Location = new Point(574, 0);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(150, 30);
            btnLogut.TabIndex = 5;
            btnLogut.Text = "Выход";
            btnLogut.UseVisualStyleBackColor = false;
            btnLogut.Click += BtnLogut_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonBack);
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btnLogut);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(5, 5);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(724, 40);
            panelTop.TabIndex = 2;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.MediumSpringGreen;
            buttonBack.Dock = DockStyle.Left;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Times New Roman", 14.25F);
            buttonBack.Location = new Point(0, 0);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(150, 30);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnOrders);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 311);
            panel1.TabIndex = 3;
            // 
            // btnProducts
            // 
            btnProducts.Anchor = AnchorStyles.None;
            btnProducts.BackColor = Color.Chartreuse;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Times New Roman", 14.25F);
            btnProducts.Location = new Point(130, 168);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(460, 30);
            btnProducts.TabIndex = 7;
            btnProducts.Text = "Товары";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += BtnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Anchor = AnchorStyles.None;
            btnOrders.BackColor = Color.MediumSpringGreen;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Times New Roman", 14.25F);
            btnOrders.Location = new Point(130, 132);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(460, 30);
            btnOrders.TabIndex = 6;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += BtnOrders_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 361);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMenu";
            Padding = new Padding(5);
            Text = "Меню работника";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblUserName;
        private Button btnLogut;
        private Panel panelTop;
        private Panel panel1;
        private Button btnProducts;
        private Button btnOrders;
        private Button buttonBack;
    }
}