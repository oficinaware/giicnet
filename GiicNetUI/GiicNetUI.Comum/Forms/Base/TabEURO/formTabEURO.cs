using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiicNetUI.Comum.Forms.Base.TabEURO
{
    public partial class formTabEURO : Form
    {
        GiicNetBus.Base.TabEuro busEuro = new GiicNetBus.Base.TabEuro();

        public static string sendBack;  

        public formTabEURO()
        {
            InitializeComponent();
        }

        private void formTabEURO_Load(object sender, EventArgs e)
        {
            GiicNetBus.Base.ResultList resultList = busEuro.GetAll(1, 10000);
            var Lista = new BindingList<GiicNetModels.tabeuro>((System.Collections.Generic.IList<GiicNetModels.tabeuro>)resultList.Lista);
            if (resultList.Status) gridControl1.DataSource = Lista;

            #region ColunaDataCambio
            gridView1.Columns["DTCAMBIO"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["DTCAMBIO"].DisplayFormat.FormatString = "dd-MM-yyyy";
            #endregion
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.RowHandle == GridControl.NewItemRowHandle)
            {
                //INSERT
                GiicNetBus.Base.ResultList resultList = busEuro.Insert(gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.tabeuro);
            }
            else
            {
                //UPDATE
                GiicNetBus.Base.ResultList resultList = busEuro.Update(e.Row as GiicNetModels.tabeuro);
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            DialogResult hR = MessageBox.Show("Tem a certeza que pretende remover?", "Tem a certeza que pretende remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (hR == System.Windows.Forms.DialogResult.Yes)
            {
                GiicNetBus.Base.ResultList resultList = busEuro.Delete((gridView1.GetRow(e.RowHandle) as GiicNetModels.tabeuro).MOEDA);
                gridControl1.Refresh();
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var novaLinha = gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.tabeuro;
            GiicNetBus.Base.ResultList resultList = busEuro.Valida(novaLinha);
            e.Valid = resultList.Status;
            e.ErrorText = resultList.Erros;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo info = ((GridView)sender).CalcHitInfo(((GridView)sender).GridControl.PointToClient(Control.MousePosition));
            if (info.InRow || info.InRowCell)
            {
                sendBack = (string)gridView1.GetRowCellValue(info.RowHandle, "MOEDA");
            }
        }
    }
}
