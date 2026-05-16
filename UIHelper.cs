using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


/*THIS CLASS IS USED TO STORE ALL THE DESIGN RELATED METHODS AND PROPERTIES 
FOR THE APPLICATION, SUCH AS COLOR SCHEMES, FONTS, AND OTHER UI ELEMENTS. 
THIS HELPS IN MAINTAINING A CONSISTENT LOOK AND FEEL THROUGHOUT THE APPLICATION 
AND MAKES IT EASIER TO UPDATE THE DESIGN IN THE FUTURE IF NEEDED.*/

namespace FuelTrack
{
    public static class UIHelper
    {
        public static void SetRadius(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(control.Width - d, 0, d, d, 270, 90);
            path.AddArc(control.Width - d, control.Height - d, d, d, 0, 90);
            path.AddArc(0, control.Height - d, d, d, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        // Updated to apply your specific hover/click scheme and remove borders
        public static void SetButtonColors(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(128, 0, 0); // Default Base Color
            button.ForeColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 0, 0);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 0, 0);
        }

        // New method to toggle the "Active" highlight for the Dashboard/Navigation
        public static void SetButtonActive(Button button, bool isActive)
        {
            if (isActive)
            {
                button.BackColor = Color.FromArgb(162, 72, 87); // Active Highlight
            }
            else
            {
                button.BackColor = Color.FromArgb(128, 0, 0); // Reset to Base
            }
        }

        public static void setDateLabel(Label label)
        {
            label.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            label.Refresh();
        }
        // Method to disable the close button on a form
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        private static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        private const uint SC_CLOSE = 0xF060;
        private const uint MF_GRAYED = 0x1;

        public static void DisableCloseButton(Form form)
        {
            IntPtr hMenu = GetSystemMenu(form.Handle, false);
            EnableMenuItem(hMenu, SC_CLOSE, MF_GRAYED);
        }
        public static void MakeCircular(PictureBox pic)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pic.Width, pic.Height);
            pic.Region = new Region(path);
        }

        public static void StyleFuelTrackTitle(RichTextBox rtb)
        {
            rtb.Text = "FuelTrack";
            rtb.Select(0, 4);
            rtb.SelectionColor = Color.FromArgb(245, 87, 51);
            rtb.Select(4, 5);
            rtb.SelectionColor = Color.White;
            rtb.Select(0, 0);
            rtb.BorderStyle = BorderStyle.None;
            rtb.ReadOnly = true;
        }
        public static void LoadForm(Panel panel, Form childForm)
        {
            panel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel.Controls.Add(childForm);
            panel.Tag = childForm;

            childForm.Show();
        }

        public static void SetProfileInitials(PictureBox pic, string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return;

            // Extract Initials
            string[] names = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string initials = names.Length > 1
                ? (names[0][0].ToString() + names[names.Length - 1][0].ToString()).ToUpper()
                : names[0][0].ToString().ToUpper();

            // Create Bitmap
            Bitmap bmp = new Bitmap(pic.Width, pic.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Background Color (Matching your sidebar theme)
                g.Clear(Color.FromArgb(162, 72, 87));

                // Text Formatting
                Font font = new Font("Segoe UI", 12, FontStyle.Bold);
                Brush brush = new SolidBrush(Color.White);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                g.DrawString(initials, font, brush, new Rectangle(0, 0, pic.Width, pic.Height), sf);
            }

            pic.Image = bmp;
        }


    }
}

