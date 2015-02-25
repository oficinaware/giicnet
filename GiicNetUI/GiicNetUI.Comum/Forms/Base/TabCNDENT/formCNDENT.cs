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

namespace GiicNetUI.Comum.Forms.Base.TabCNDENT
{
    public partial class formCNDENT : Form
    {
        GiicNetBus.Base.CondEntrega busCondEnt = new GiicNetBus.Base.CondEntrega();

        public static string sendBack;

        public formCNDENT()
        {
            InitializeComponent();
        }

        private void formCNDENT_Load(object sender, EventArgs e)
        {
            GiicNetBus.Base.ResultList resultList = busCondEnt.GetAll(1, 10000);
            var Lista = new BindingList<GiicNetModels.CNDENT>((System.Collections.Generic.IList<GiicNetModels.CNDENT>)resultList.Lista);
            if (resultList.Status) gridControl1.DataSource = Lista;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.RowHandle == GridControl.NewItemRowHandle)
            {
                //INSERT
                GiicNetBus.Base.ResultList resultList = busCondEnt.Insert(gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.CNDENT);
            }
            else
            {
                //UPDATE
                GiicNetBus.Base.ResultList resultList = busCondEnt.Update(e.Row as GiicNetModels.CNDENT);
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            DialogResult hR = MessageBox.Show("Tem a certeza que pretende remover?", "Tem a certeza que pretende remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (hR == System.Windows.Forms.DialogResult.Yes)
            {
                GiicNetBus.Base.ResultList resultList = busCondEnt.Delete((gridView1.GetRow(e.RowHandle) as GiicNetModels.CNDENT).CODIGO);
                gridControl1.Refresh();
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var novaLinha = gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.CNDENT;
            GiicNetBus.Base.ResultList resultList = busCondEnt.Valida(novaLinha);
            e.Valid = resultList.Status;
            e.ErrorText = resultList.Erros;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo info = ((GridView)sender).CalcHitInfo(((GridView)sender).GridControl.PointToClient(Control.MousePosition));
            if (info.InRow || info.InRowCell)
            {
                sendBack = (string)gridView1.GetRowCellValue(info.RowHandle, "CODIGO");
            }
        }
    }
}