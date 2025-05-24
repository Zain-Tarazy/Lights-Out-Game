using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace Lights_Out
{
    public class AddingComponents
    {

        //In these methods the order of calling is important due to using the clear feature 
        public static void Add_Comp(Panel panel, string str,string place,Font appFont,string clearOrNot)
        {
            if (clearOrNot== "clear")
                panel.Controls.Clear();
            Label label = new Label();
            label.AutoSize = true;

            label.Text = str;
            label.ForeColor = AppColors.Text;
            label.Font=appFont;

            panel.Controls.Add(label);


            int x, y;
            if (place == "center")
            {
                x = (panel.ClientSize.Width-label.ClientSize.Width) / 2;
                y = (panel.ClientSize.Height-label.ClientSize.Height) / 2; 
            }
            else
            {
                x = panel.Width / 2;
                y = panel.Height/ 2;
            }

            label.Location = new Point(x, y);
        }

        public static void Add_Comp(Panel panel, string str, string place, Font appFont)
        {
            Label label = new Label();
            label.AutoSize = true;

            label.Text = str;
            label.ForeColor = AppColors.Text;
            label.Font = appFont;

            panel.Controls.Add(label);


            int x, y;
            if (place == "center")
            {
                x = (panel.ClientSize.Width - label.ClientSize.Width) / 2;
                y = (panel.ClientSize.Height - label.ClientSize.Height) / 2;
            }
            else
            {
                x = panel.Width / 2;
                y = panel.Height / 2;
            }

            label.Location = new Point(x, y);
        }

        public static void Add_Comp(Panel panel, string str, int x, int y, Font appFont,string clearOrNot)
        {
            if (clearOrNot == "clear")
                panel.Controls.Clear();
            Label label = new Label();
            label.AutoSize = true;

            label.Text = str;
            label.ForeColor = AppColors.Text;
            label.Font = appFont;

            panel.Controls.Add(label);
            Point point = new Point(x, y);
            label.Location = point;


        }

        public static void Add_Comp(Panel panel, string str, int x, int y, Font appFont)
        {
            Label label = new Label();
            label.AutoSize = true;

            label.Text = str;
            label.ForeColor = AppColors.Text;
            label.Font = appFont;

            panel.Controls.Add(label);
            Point point = new Point(x, y);
            label.Location = point;


        }
    }
}
