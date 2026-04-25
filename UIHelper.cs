using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Text;

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
            button.BackColor = Color.FromArgb(26, 58, 92); // Default Base Color
            button.ForeColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 70, 110);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 45, 75);
        }

        // New method to toggle the "Active" highlight for the Dashboard/Navigation
        public static void SetButtonActive(Button button, bool isActive)
        {
            if (isActive)
            {
                button.BackColor = Color.FromArgb(40, 85, 135); // Active Highlight
            }
            else
            {
                button.BackColor = Color.FromArgb(26, 58, 92); // Reset to Base
            }
        }

        public static void setDateLabel(Label label)
        {
            label.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            label.Refresh();
        }
    }
}