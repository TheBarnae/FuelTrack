namespace FuelTrack
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UIHelper.SetRadius(login_btn, 6);
            UIHelper.SetRadius(user_txtbox, 3);
            UIHelper.SetRadius(pass_txtbox, 3);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
