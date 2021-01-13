using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coppel
{
    class Ocultar
    {
        public static void ocultar(Control a)
        {
            foreach (Control c in a.Controls)
            {
                if (c is TextBox)
                {
                    c.Visible = false;
                }
                if (c is Label)
                {
                    c.Visible = false;
                }
            }
        }
    }
}
