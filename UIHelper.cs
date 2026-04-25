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
    }
}