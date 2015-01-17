using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinGiicNet.PastaMenus
{
    public partial class formMenu1 : Form
    {
        public formMenu1()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            manutCliente nC = new manutCliente();
            nC.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idCliente = PastaGrids.formGridClientes.idClienteSelected;
            manutCliente mC = new manutCliente();
            manutCliente.idCliente = idCliente;
            mC.ShowDialog();
        }
    }
}