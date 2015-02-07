using GiicNetBus.Base;
using GiicNetModels;
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
    public partial class formClientes : Form
    {
        public static string idClienteSelected { get; set; }

        public formClientes()
        {
            InitializeComponent();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = get();
            }
            catch { }  
        }

        public DataTable get()
        {
            GiicNetBus.Base.Clientes busClientes = new GiicNetBus.Base.Clientes();
            DataTable dT = new DataTable();
            dT = busClientes.BrowseDT();
            return dT;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                CLIENTES_BR cL = gridView1.GetRow(e.FocusedRowHandle) as CLIENTES_BR;
                idClienteSelected = cL.CLIENTE;
            }
            catch { }
        }

        public void SwitchVisibility()
        {
            //if(panelFiltros.Visible) 
            //    panelFiltros.Visible = false;
            //else 
            //    panelFiltros.vi
            panelFiltros.Visible = !panelFiltros.Visible;


       
        }

        public void btnFiltrosServidor_Click(object sender, EventArgs e)
        {
            //foreach (Control c in this.Controls)
            //{
            //    if (c.Name == "panelFiltros" && c is Panel)
            //    {
            //        if (((Panel)c).Visible == true) ((Panel)c).Visible = false;
            //        else ((Panel)c).Visible = true;
            //    }
            //}
        }
    }
}
