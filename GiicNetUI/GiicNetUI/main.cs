using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiicNetUI.Forms.Testes;

namespace GiicNetUI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            teste_pivot TesteGrid = new teste_pivot();
            TesteGrid.Show();
        }
    }
}
