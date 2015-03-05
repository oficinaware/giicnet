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

namespace GiicNetUI.Comum.Forms.Base.TabAGE
{
    public partial class formTABAGE : Form
    {
        GiicNetBus.Base.TabAge busAgentes = new GiicNetBus.Base.TabAge();

        public static string sendBack;

        public formTABAGE()
        {
            InitializeComponent();
            ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
        }

        private void formTABAGE_Load(object sender, EventArgs e)
        {
            GiicNetBus.Base.ResultList resultList = busAgentes.GetAll(1, 10000);
            var Lista = new BindingList<GiicNetModels.TABAGE>((System.Collections.Generic.IList<GiicNetModels.TABAGE>)resultList.Lista);
            if (resultList.Status) gridControl1.DataSource = Lista;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.RowHandle == GridControl.NewItemRowHandle)
            {
                //INSERT
                GiicNetBus.Base.ResultList resultList = busAgentes.Insert(gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.TABAGE);
            }
            else
            {
                //UPDATE
                GiicNetBus.Base.ResultList resultList = busAgentes.Update(e.Row as GiicNetModels.TABAGE);
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            DialogResult hR = MessageBox.Show("Tem a certeza que pretende remover?", "Tem a certeza que pretende remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (hR == System.Windows.Forms.DialogResult.Yes)
            {
                GiicNetBus.Base.ResultList resultList = busAgentes.Delete((gridView1.GetRow(e.RowHandle) as GiicNetModels.TABAGE).AGENTE);
                gridControl1.Refresh();
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var novaLinha = gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.TABAGE;
            GiicNetBus.Base.ResultList resultList = busAgentes.Valida(novaLinha);
            e.Valid = resultList.Status;
            e.ErrorText = resultList.Erros;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo info = ((GridView)sender).CalcHitInfo(((GridView)sender).GridControl.PointToClient(Control.MousePosition));
            if (info.InRow || info.InRowCell)
            {
                sendBack = (string)gridView1.GetRowCellValue(info.RowHandle, "AGENTE");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formManutTABAGE fmTabAge = new formManutTABAGE();
            fmTabAge.ShowDialog();
            fmTabAge.Dispose();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formManutTABAGE fmTabAge = new formManutTABAGE();
            GiicNetModels.TABAGE tA = (gridControl1.FocusedView as GridView).GetRow((gridControl1.FocusedView as GridView).FocusedRowHandle) as GiicNetModels.TABAGE;
            fmTabAge.PARAM_AGENTE = tA.AGENTE;
            fmTabAge.ShowDialog();
            fmTabAge.Dispose();
        }
    }
}