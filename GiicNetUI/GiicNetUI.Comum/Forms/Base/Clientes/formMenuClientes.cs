using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiicNetUI.Comum.Forms.Base.Clientes
{
    public partial class formMenuClientes : Form
    {
        public formMenuClientes()
        {
            InitializeComponent();
            ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Base.Clientes.formManutClientes fC = new formManutClientes();
            fC.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fMenuClientes = this.FindForm();
            formClientes fClient = fMenuClientes.Tag as formClientes;
            fClient.SwitchVisibility();
      

           
        }
    }
}