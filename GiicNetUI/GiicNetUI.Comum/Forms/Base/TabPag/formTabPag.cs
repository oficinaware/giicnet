using DevExpress.XtraEditors.Repository;
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

namespace GiicNetUI.Comum.Forms.Base.TabPag
{
    public partial class formTabPag : Form
    {
        GiicNetBus.Base.TabPag busPag = new GiicNetBus.Base.TabPag();

        public static string sendBack;        

        public formTabPag()
        {
            InitializeComponent();
        }

        private void formTabPag_Load(object sender, EventArgs e)
        {
            GiicNetBus.Base.ResultList resultList = busPag.GetAll(1, 10000);
            var Lista = new BindingList<GiicNetModels.TABPAG>((System.Collections.Generic.IList<GiicNetModels.TABPAG>)resultList.Lista);
            if (resultList.Status) gridControl1.DataSource = Lista;

            #region ColunaSentido
            DevExpress.XtraEditors.Repository.RepositoryItemComboBox colunaSentido = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            gridView1.Columns["SENTIDO"].ColumnEdit = colunaSentido;
            colunaSentido.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            colunaSentido.Items.Clear();
            colunaSentido.Items.Add("+");
            colunaSentido.Items.Add("-");
            #endregion
                                   
            #region ColunaDiaInicio
            RepositoryItemGridLookUpEdit colunaLUE;
            colunaLUE = new RepositoryItemGridLookUpEdit();
            colunaLUE.ValueMember = "Key";
            colunaLUE.DisplayMember = "Key";

            Dictionary<int, string> tipoDIAINI = new Dictionary<int, string>() { { 1, "Data documento" }, { 2, "Dia 1 do próximo mês" } };
            colunaLUE.DataSource = (from d in tipoDIAINI orderby d.Value select new { d.Key, d.Value }).ToList();           

            colunaLUE.PopulateViewColumns();
            colunaLUE.View.Columns[0].Caption = "Tipo";
            colunaLUE.View.Columns[0].Width = 50;
            colunaLUE.View.Columns[1].Caption = "Descrição";

            gridControl1.RepositoryItems.Add(colunaLUE); 
            gridView1.Columns["DIAINI"].ColumnEdit = colunaLUE;
            #endregion

            #region ColunaDiaFixo
            DevExpress.XtraEditors.Repository.RepositoryItemComboBox colunaDiaFixo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            gridView1.Columns["DIAPAG"].ColumnEdit = colunaDiaFixo;
            colunaDiaFixo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            colunaDiaFixo.Items.Clear();
            for (int i = 0; i < 32; i++)
            {
                colunaDiaFixo.Items.Add(i);
            }
            #endregion
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.RowHandle == GridControl.NewItemRowHandle)
            {
                //INSERT
                GiicNetBus.Base.ResultList resultList = busPag.Insert(gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.TABPAG);
            }
            else
            {
                //UPDATE
                GiicNetBus.Base.ResultList resultList = busPag.Update(e.Row as GiicNetModels.TABPAG);
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            DialogResult hR = MessageBox.Show("Tem a certeza que pretende remover?", "Tem a certeza que pretende remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (hR == System.Windows.Forms.DialogResult.Yes)
            {
                GiicNetBus.Base.ResultList resultList = busPag.Delete((gridView1.GetRow(e.RowHandle) as GiicNetModels.TABPAG).CNDPAG);
                gridControl1.Refresh();
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var novaLinha = gridView1.GetRow((sender as GridView).FocusedRowHandle) as GiicNetModels.TABPAG;
            GiicNetBus.Base.ResultList resultList = busPag.Valida(novaLinha);
            e.Valid = resultList.Status;
            e.ErrorText = resultList.Erros;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo info = ((GridView)sender).CalcHitInfo(((GridView)sender).GridControl.PointToClient(Control.MousePosition));
            if (info.InRow || info.InRowCell)
            {
                sendBack = (string)gridView1.GetRowCellValue(info.RowHandle, "CNDPAG");
            }
        }
    }
}