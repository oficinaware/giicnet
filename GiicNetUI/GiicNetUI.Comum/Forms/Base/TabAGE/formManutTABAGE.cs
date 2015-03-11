using System.Globalization;
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
using GiicNetModels;
using GiicNetUI.Comum.Helpers;

namespace GiicNetUI.Comum.Forms.Base.TabAGE
{
    public partial class formManutTABAGE : Form
    {
        GiicNetBus.Base.TabAge busAgentes = new GiicNetBus.Base.TabAge();
        GiicNetBus.Base.TabIdioma busIdioma = new GiicNetBus.Base.TabIdioma();

        public string PARAM_AGENTE { get; set; }

        public int binditem = 0;

        public GiicNetModels.TABAGE uAgente { get; set; }

        public formManutTABAGE()
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-PT");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-PT");
            InitializeComponent();
            COMISSAO.BindingContext = new BindingContext();
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
            LINGUA.Properties.ValueMember = "IDIOMA";

           
            if (PARAM_AGENTE != string.Empty)
            {
                AGENTE.Enabled = false;

                uAgente = busAgentes.GetByKey(PARAM_AGENTE);
                
            }
            else
            {
                AGENTE.Enabled = true;

                 uAgente = new GiicNetModels.TABAGE();
                
            }
            AGENTE.Text = uAgente.AGENTE;
            AGENTEPAI.EditValue = uAgente.AGENTEPAI;
            NOME.Text = uAgente.NOME;
            MORADA1.Text = uAgente.MORADA1;
            MORADA2.Text = uAgente.MORADA2;
            MORADA3.Text = uAgente.MORADA3;
            MORADA4.Text = uAgente.MORADA4;
            TELEF.Text = uAgente.TELEF;
            TELEM.Text = uAgente.TELM;
            FAX.Text = uAgente.FAX;
            EMAIL.Text = uAgente.EMAIL;
            COMISSAO.EditValue = uAgente.COMISSAO;
            FTPFOLDER.Text = uAgente.FTPFOLDER;
            FTPDIRREMOTO.Text = uAgente.FTPDIRREMOTO;
            USERNAME.Text = uAgente.USERNAME;
            PASSWORD.Text = uAgente.PASSWORD;
            LINGUA.EditValue = uAgente.LINGUA;
            PREFIXO_ENC.Text = uAgente.PREFIXO_ENC;
            COMISSIONISTA.Checked = (bool)uAgente.COMISSIONISTA;
            STAT.EditValue = uAgente.STAT; 
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            GiicNetModels.TABAGE nAGENTE = new GiicNetModels.TABAGE();
            nAGENTE.AGENTE = AGENTE.Text;
            nAGENTE.AGENTEPAI = (string)AGENTEPAI.EditValue;
            nAGENTE.NOME = NOME.Text;
            nAGENTE.MORADA1 = MORADA1.Text;
            nAGENTE.MORADA2 = MORADA2.Text;
            nAGENTE.MORADA3 = MORADA3.Text;
            nAGENTE.MORADA4 = MORADA4.Text;
            nAGENTE.TELEF = TELEF.Text;
            nAGENTE.TELM = TELEM.Text;
            nAGENTE.FAX = FAX.Text;
            nAGENTE.EMAIL = EMAIL.Text;
            //nAGENTE.COMISSAO = Convert.ToDecimal(COMISSAO.Text.Replace(".",","));
            
            //decimal comm;
            //var type = decimal.TryParse(COMISSAO.EditValue as string, NumberStyles.Any, new CultureInfo("pt-PT"), out comm);
            //


            nAGENTE.COMISSAO = (decimal?) COMISSAO.EditValue ?? 0;
            nAGENTE.FTPFOLDER = FTPFOLDER.Text;
            nAGENTE.FTPDIRREMOTO = FTPDIRREMOTO.Text;
            nAGENTE.USERNAME = USERNAME.Text;
            nAGENTE.PASSWORD = PASSWORD.Text;
            nAGENTE.LINGUA = (string)LINGUA.EditValue;
            nAGENTE.PREFIXO_ENC = PREFIXO_ENC.Text;
            nAGENTE.COMISSIONISTA = COMISSIONISTA.Checked;
            nAGENTE.STAT = (bool)STAT.Checked;


            //fetching current information from UI passes on ef update
            uAgente = nAGENTE;



            GiicNetBus.Base.ResultList resultValida = busAgentes.Valida(uAgente);
            if (resultValida.Status)
            {
                GiicNetBus.Base.ResultList resultList;
                if (PARAM_AGENTE != string.Empty)
                {

                    resultList = busAgentes.Update((TABAGE)uAgente.Clone());
                    this.Dispose();
                }
                else resultList = busAgentes.Insert(uAgente);

                if (resultList.Status) 
                    limpar();
                else 
                    MessageBox.Show(resultList.Erros, "Erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else MessageBox.Show(resultValida.Erros, "Erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void limpar()
        {
            AGENTE.Text = string.Empty;
            AGENTEPAI.EditValue = string.Empty;
            NOME.Text = string.Empty;
            MORADA1.Text = string.Empty;
            MORADA2.Text = string.Empty;
            MORADA3.Text = string.Empty;
            MORADA4.Text = string.Empty;
            TELEF.Text = string.Empty;
            TELEM.Text = string.Empty;
            FAX.Text = string.Empty;
            EMAIL.Text = string.Empty;
            COMISSAO.Text = string.Empty;
            FTPFOLDER.Text = string.Empty;
            FTPDIRREMOTO.Text = string.Empty;
            USERNAME.Text = string.Empty;
            PASSWORD.Text = string.Empty;
            LINGUA.EditValue = string.Empty;
            PREFIXO_ENC.Text = string.Empty;
            COMISSIONISTA.Checked = true;
            STAT.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}