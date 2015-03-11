using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
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
            // novo registo
            formManutTABAGE fmTabAge = new formManutTABAGE();
            fmTabAge.PARAM_AGENTE = "";
            fmTabAge.ShowDialog();
            fmTabAge.Dispose();
            refrescar(0);
            //this.Refresh();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // editar registo
            formManutTABAGE fmTabAge = new formManutTABAGE();
            GiicNetModels.TABAGE tA = (gridControl1.FocusedView as GridView).GetRow((gridControl1.FocusedView as GridView).FocusedRowHandle) as GiicNetModels.TABAGE;
            int rowHandle = (gridControl1.FocusedView as GridView).FocusedRowHandle;
            fmTabAge.PARAM_AGENTE = tA.AGENTE;
            
            fmTabAge.ShowDialog();
            fmTabAge.Dispose();

            
            refrescar(rowHandle);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Delete Registo
            DialogResult msg = MessageBox.Show("Tem a certeza pretende remover?", "Tem a certeza pretende remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msg == System.Windows.Forms.DialogResult.No) return;

            int rowHandle = (gridControl1.FocusedView as GridView).FocusedRowHandle;
            if (rowHandle > 0)
            {
                string mAgente = gridView1.GetRowCellValue(rowHandle, "AGENTE").ToString();
                //formManutTABAGE fmTabAge = new formManutTABAGE();
                //GiicNetModels.TABAGE tA = (gridControl1.FocusedView as GridView).GetRow((gridControl1.FocusedView as GridView).FocusedRowHandle) as GiicNetModels.TABAGE;
                GiicNetBus.Base.ResultList resultList = busAgentes.Delete(mAgente);
                if (resultList.Status == true)
                {
                    refrescar(rowHandle);
                }
                else
                {
                    DialogResult msgerro = MessageBox.Show(resultList.Erros,"Erro" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            
        }

        public void refrescar(int p_rowHandle)
        {
            GiicNetBus.Base.ResultList resultList = busAgentes.GetAll(1, 10000);
            var Lista = new BindingList<GiicNetModels.TABAGE>((System.Collections.Generic.IList<GiicNetModels.TABAGE>)resultList.Lista);
            if (resultList.Status) gridControl1.DataSource = Lista;
            
            ColumnView cv = gridControl1.MainView as ColumnView;
            if (p_rowHandle > 0) cv.FocusedRowHandle = p_rowHandle;

        }
    }
}