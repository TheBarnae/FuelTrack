namespace FuelTrack
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetRadius(login_btn, 20);
            SetRadius(user_txtbox, 20);
            SetRadius(pass_txtbox, 20);
        }
        private void SetRadius(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            control.Region = new System.Drawing.Region(path);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
