using GiicNetBus.Base;
using GiicNetModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public string tipoLoad = "";

        public List<CLIENTES_BR> lClientesBR = new List<CLIENTES_BR>();

        public static string idClienteSelected { get; set; }

        private void formGridClientes_Load(object sender, EventArgs e)
        {
            if (tipoLoad == "1")
            {
                try
                {
                    var watch = Stopwatch.StartNew();                   

                    lClientesBR = get("");
                    gridControl1.DataSource = lClientesBR;

                    watch.Stop();
                    MessageBox.Show(watch.ElapsedMilliseconds.ToString());
                }
                catch { }
            }
            

            if(tipoLoad == "2")
            {
                var watch = Stopwatch.StartNew(); 

                SqlConnection sX = new SqlConnection("Data Source=server\\sql2008dev;Initial Catalog=DataGiicNet;Persist Security Info=True;User ID=sa;Password=sa;MultipleActiveResultSets=true");
                if (sX.State == ConnectionState.Closed) sX.Open();

                SqlCommand sCmd = new SqlCommand("SELECT * FROM CLIENTES_BR", sX);
                SqlDataReader sDr = sCmd.ExecuteReader();
                DataTable dT = new DataTable();
                dT.Load(sDr);
                sDr.Close();
                sDr.Dispose();
                gridControl1.DataSource = dT;

                watch.Stop();
                MessageBox.Show(watch.ElapsedMilliseconds.ToString());
            }
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
            //CLIENTES_BR cL = gridView1.GetRow(e.FocusedRowHandle) as CLIENTES_BR;
            //idClienteSelected = cL.CLIENTE;

            try
            {
                idClienteSelected = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, gridView1.Columns["CLIENTE"]);
            }
            catch { }
            

        }
    }
}