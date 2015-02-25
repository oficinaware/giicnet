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

namespace GiicNetUI.Comum.Forms.Base.TabRETENCOES
{
    public partial class formTABRETENCOES : Form
    {
        GiicNetBus.Base.Tab_Retencoes busRetencoes = new GiicNetBus.Base.Tab_Retencoes();

        public static string sendBack;

        public formTABRETENCOES()
        {
            InitializeComponent();
        }

        private void formTABRETENCOES_Load(object sender, EventArgs e)
        {
            GiicNetBus.Base.ResultList resultList = busRetencoes.GetAll(1, 10000);
            var Lista = new BindingList<GiicNetModels.TAB_RETENCOES>((System.Collections.Generic.IList<GiicNetModels.TAB_RETENCOES>)resultList.Lista);
            if (resultList.Status) gridControl1.DataSource = Lista;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.RowHandle == GridControl.NewItemRowHandle)
            {
                //INSERT
                GiicNetBus.Base.ResultList resultList = busRetencoes.Insert(gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.TAB_RETENCOES);
            }
            else
            {
                //UPDATE
                GiicNetBus.Base.ResultList resultList = busRetencoes.Update(e.Row as GiicNetModels.TAB_RETENCOES);
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            DialogResult hR = MessageBox.Show("Tem a certeza que pretende remover?", "Tem a certeza que pretende remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (hR == System.Windows.Forms.DialogResult.Yes)
            {
                GiicNetBus.Base.ResultList resultList = busRetencoes.Delete((gridView1.GetRow(e.RowHandle) as GiicNetModels.TAB_RETENCOES).COD);
                gridControl1.Refresh();
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var novaLinha = gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.TAB_RETENCOES;
            GiicNetBus.Base.ResultList resultList = busRetencoes.Valida(novaLinha);
            e.Valid = resultList.Status;
            e.ErrorText = resultList.Erros;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo info = ((GridView)sender).CalcHitInfo(((GridView)sender).GridControl.PointToClient(Control.MousePosition));
            if (info.InRow || info.InRowCell)
            {
                sendBack = (string)gridView1.GetRowCellValue(info.RowHandle, "COD");
            }
        }
    }
}
