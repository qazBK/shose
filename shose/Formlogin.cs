using shose.Models;

namespace shose
{
    public partial class Formlogin : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest {  get; private set; }

        public Formlogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            IsGuest = true;
            CurrentUser = null;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textLogin.Text) || string.IsNullOrWhiteSpace(textPaissword.Text))
            {
                MessageBox.Show("Введите логин и пароль","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new ShopDbContext())
            {
                var user = db.Users.
                    Where(w => w.Login == textLogin.Text && w.Pass == textPaissword.Text).FirstOrDefault();

                if (user != null)
                {
                    CurrentUser = user;

                    IsGuest = false;

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
