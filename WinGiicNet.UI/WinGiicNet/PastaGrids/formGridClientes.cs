using GiicNetBus.Base;
using GiicNetModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinGiicNet.PastaGrids
{
    public partial class formGridClientes : Form
    {
        public formGridClientes()
        {
            InitializeComponent();
        }

        public List<CLIENTES_BR> lClientesBR = new List<CLIENTES_BR>();

        public static string idClienteSelected { get; set; }

        private void formGridClientes_Load(object sender, EventArgs e)
        {
            try
            {
                lClientesBR = get("");
                gridControl1.DataSource = lClientesBR;
            }
            catch { }
        }

        public List<GiicNetModels.CLIENTES_BR> get(string filtro)
        {
            GiicNetBus.Base.Clientes busClientes = new GiicNetBus.Base.Clientes();
            var list = new List<CLIENTES_BR>();
            list = busClientes.Browse();
            return list;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CLIENTES_BR cL = gridView1.GetRow(e.FocusedRowHandle) as CLIENTES_BR;
            idClienteSelected = cL.CLIENTE;
        }
    }
}