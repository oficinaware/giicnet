using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiicNetUI.Comum.Helpers
{
    public static class PanelHelper
    {
        public static void Clear(Panel pnl)
        {
            pnl.Controls.Clear();
            foreach (Control ctrl in pnl.Controls)
            {
                ctrl.Dispose();
            }
        }
    }
}