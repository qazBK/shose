namespace shose
{
    partial class Formlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///

        #region Windows Form Designer generated code
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            pbLogo = new PictureBox();
            panel1 = new Panel();
            textLogin = new TextBox();
            textPaissword = new TextBox();
            lbPaissword = new Label();
            lbLogin = new Label();
            btnGuest = new Button();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.BackgroundImage = (Image)resources.GetObject("pbLogo.BackgroundImage");
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(142, 20);
            pbLogo.Margin = new Padding(5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(textLogin);
            panel1.Controls.Add(textPaissword);
            panel1.Controls.Add(lbPaissword);
            panel1.Controls.Add(lbLogin);
            panel1.Controls.Add(btnGuest);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(21, 130);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 256);
            panel1.TabIndex = 1;
            // 
            // textLogin
            // 
            textLogin.Font = new Font("Times New Roman", 14.25F);
            textLogin.Location = new Point(3, 64);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(337, 29);
            textLogin.TabIndex = 3;
            // 
            // textPaissword
            // 
            textPaissword.Font = new Font("Times New Roman", 14.25F);
            textPaissword.Location = new Point(3, 140);
            textPaissword.Name = "textPaissword";
            textPaissword.Size = new Size(337, 29);
            textPaissword.TabIndex = 2;
            textPaissword.UseSystemPasswordChar = true;
            // 
            // lbPaissword
            // 
            lbPaissword.AutoSize = true;
            lbPaissword.Font = new Font("Times New Roman", 14.25F);
            lbPaissword.Location = new Point(134, 106);
            lbPaissword.Name = "lbPaissword";
            lbPaissword.Size = new Size(69, 21);
            lbPaissword.TabIndex = 1;
            lbPaissword.Text = "Пароль";
            lbPaissword.Click += label2_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Times New Roman", 14.25F);
            lbLogin.Location = new Point(134, 30);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(61, 21);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Логин";
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.Chartreuse;
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Font = new Font("Times New Roman", 14.25F);
            btnGuest.Location = new Point(90, 221);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 30);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSpringGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 14.25F);
            btnLogin.Location = new Point(90, 182);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 411);
            Controls.Add(pbLogo);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Formlogin";
            Text = "Авиаризация";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel panel1;
        private TextBox textLogin;
        private TextBox textPaissword;
        private Label lbPaissword;
        private Label lbLogin;
        private Button btnGuest;
        private Button btnLogin;
    }
}
