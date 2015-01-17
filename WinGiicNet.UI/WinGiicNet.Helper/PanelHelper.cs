using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinGiicNet.Helper
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
