using DevExpress.XtraGrid.Columns;
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
    public partial class formManutTABAGE : Form
    {
        GiicNetBus.Base.TabAge busAgentes = new GiicNetBus.Base.TabAge();
        GiicNetBus.Base.TabIdioma busIdioma = new GiicNetBus.Base.TabIdioma();

        public static string PARAM_AGENTE;

        public formManutTABAGE()
        {
            InitializeComponent();
        }

        private void formManutTABAGE_Load(object sender, EventArgs e)
        {
            GiicNetBus.Base.ResultList resultList = busAgentes.GetAll(1, 10000);
            var ListaAgente = new BindingList<GiicNetModels.TABAGE>((System.Collections.Generic.IList<GiicNetModels.TABAGE>)resultList.Lista);                       
            AGENTEPAI.Properties.DataSource = ListaAgente;
            AGENTEPAI.Properties.DisplayMember = "NOME";
            AGENTEPAI.Properties.ValueMember = "AGENTE";

            resultList = busIdioma.GetAll(1, 10000);
            var ListaIdioma = new BindingList<GiicNetModels.TABIDIOMA>((System.Collections.Generic.IList<GiicNetModels.TABIDIOMA>)resultList.Lista);
            LINGUA.Properties.DataSource = ListaIdioma;
            LINGUA.Properties.DisplayMember = "IDIOMA";
            LINGUA.Properties.ValueMember = "DESCRICAO";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            GiicNetModels.TABAGE nAGENTE = new GiicNetModels.TABAGE();
            nAGENTE.AGENTE = AGENTE.Text;
            nAGENTE.AGENTEPAI = AGENTEPAI.Text;
            nAGENTE.NOME = NOME.Text;
            nAGENTE.MORADA1 = MORADA1.Text;
            nAGENTE.MORADA2 = MORADA2.Text;
            nAGENTE.MORADA3 = MORADA3.Text;
            nAGENTE.MORADA4 = MORADA4.Text;
            nAGENTE.TELEF = TELEF.Text;
            nAGENTE.TELM = TELEM.Text;
            nAGENTE.FAX = FAX.Text;
            nAGENTE.EMAIL = EMAIL.Text;
            nAGENTE.COMISSAO = Convert.ToDecimal(COMISSAO.Text);
            nAGENTE.FTPFOLDER = FTPFOLDER.Text;
            nAGENTE.FTPDIRREMOTO = FTPDIRREMOTO.Text;
            nAGENTE.USERNAME = USERNAME.Text;
            nAGENTE.PASSWORD = PASSWORD.Text;
            nAGENTE.LINGUA = LINGUA.Text;
            nAGENTE.PREFIXO_ENC = PREFIXO_ENC.Text;
            nAGENTE.COMISSIONISTA = COMISSIONISTA.Checked;
            nAGENTE.STAT = STAT.Checked;

            GiicNetBus.Base.ResultList resultValida = busAgentes.Valida(nAGENTE);
            if (resultValida.Status)
            {

            }
            else
            {
                
            }
        }
    }
}
