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
            if (tipoLoad == "3")
            {
                var watch = Stopwatch.StartNew();
                var dTClientes = new DataTable();
                var cL= new Clientes();

                dTClientes = cL.BrowseDT();

                gridControl1.DataSource = dTClientes;

                watch.Stop();
                MessageBox.Show(watch.ElapsedMilliseconds.ToString());
            }
        }

        public List<GiicNetModels.CLIENTES_BR> get(string filtro)
        {
            Clientes busClientes = new GiicNetBus.Base.Clientes();
            OperationResult<List<CLIENTES_BR>> oP = new OperationResult<List<CLIENTES_BR>>();
            var list = new List<CLIENTES_BR>();
            oP = busClientes.Browse();
            return oP.Value;
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