using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiicNetUI.Comum.Forms.Base.TabPais
{
    public partial class formTabPais : Form
    {
        GiicNetBus.Base.TabPais busPais = new GiicNetBus.Base.TabPais();

        public static string sendBack;   

        public formTabPais()
        {
            InitializeComponent();
        }

        private void formTabPais_Load(object sender, EventArgs e)
        {
            GiicNetBus.Base.ResultList resultList = busPais.GetAll(1, 10000);
            var Lista = new BindingList<GiicNetModels.TABPAIS>((System.Collections.Generic.IList<GiicNetModels.TABPAIS>)resultList.Lista);
            if (resultList.Status) gridControl1.DataSource = Lista;

            #region ColunaCatalogo
            RepositoryItemGridLookUpEdit colunaLUE;
            colunaLUE = new RepositoryItemGridLookUpEdit();
            colunaLUE.ValueMember = "Key";
            colunaLUE.DisplayMember = "Key";

            Dictionary<int, string> dicioCatalogo = new Dictionary<int, string>() { { 1, "Data documento" }, { 2, "Dia 1 do próximo mês" } };
            colunaLUE.DataSource = (from d in dicioCatalogo orderby d.Value select new { d.Key, d.Value }).ToList();

            colunaLUE.PopulateViewColumns();
            colunaLUE.View.Columns[0].Caption = "Tipo";
            colunaLUE.View.Columns[0].Width = 50;
            colunaLUE.View.Columns[1].Caption = "Descrição";

            gridControl1.RepositoryItems.Add(colunaLUE);
            gridView1.Columns["DIAINI"].ColumnEdit = colunaLUE;
            #endregion
        }
    }
}
