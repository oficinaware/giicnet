using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

namespace GiicNetUI.Comum.Forms.Base.Artigos
{
    public partial class formArtigos : Form
    {
        public static string idArtigoSelected { get; set; }

        public formArtigos()
        {
            InitializeComponent();
        }

        private void formArtigos_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = get();
            }
            catch { }  
        }

        public DataTable get()
        {
            var context = new DataGiicNetEntities();

            GiicNetBus.Base.Clientes busArtigos = new GiicNetBus.Base.Clientes(context);
            DataTable dT = new DataTable();
            dT = busArtigos.BrowseDT();
            return dT;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                CLIENTES_BR cL = gridView1.GetRow(e.FocusedRowHandle) as CLIENTES_BR;
                idArtigoSelected = cL.CLIENTE;
            }
            catch { }
        }
    }
}