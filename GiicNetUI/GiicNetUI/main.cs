using GiicNetUI.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiicNetUI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelPrincipal);
            GiicNetUI.Comum.Forms.Base.Clientes.formClientes ClientForm = new Comum.Forms.Base.Clientes.formClientes();
            ClientForm.TopLevel = false;
            ClientForm.AutoScroll = true;
            ClientForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ClientForm);
            ClientForm.Show();

            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelTopo);
            GiicNetUI.Comum.Forms.Base.Clientes.formMenuClientes MenuClientForm = new Comum.Forms.Base.Clientes.formMenuClientes();
            MenuClientForm.TopLevel = false;
            MenuClientForm.AutoScroll = true;
            MenuClientForm.Dock = DockStyle.Fill;
            this.panelTopo.Controls.Add(MenuClientForm);
            MenuClientForm.Show();
            MenuClientForm.Tag = ClientForm;
        }

        private void barButtonItem64_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelPrincipal);
            GiicNetUI.Comum.Forms.Base.Artigos.formArtigos ArticleForm = new Comum.Forms.Base.Artigos.formArtigos();
            ArticleForm.TopLevel = false;
            ArticleForm.AutoScroll = true;
            ArticleForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ArticleForm);
            ArticleForm.Show();

            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelTopo);
            GiicNetUI.Comum.Forms.Base.Artigos.formMenuArtigos MenuArticleForm = new Comum.Forms.Base.Artigos.formMenuArtigos();
            MenuArticleForm.TopLevel = false;
            MenuArticleForm.AutoScroll = true;
            MenuArticleForm.Dock = DockStyle.Fill;
            this.panelTopo.Controls.Add(MenuArticleForm);
            MenuArticleForm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Forms.Base.MeiosTrasporte.formMeiosTransporte FormMeiosTransporte = new Comum.Forms.Base.MeiosTrasporte.formMeiosTransporte();
            FormMeiosTransporte.ShowDialog();
            FormMeiosTransporte.Dispose();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Forms.Base.TabPag.formTabPag FormTabPag = new Comum.Forms.Base.TabPag.formTabPag();
            FormTabPag.ShowDialog();
            FormTabPag.Dispose();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Forms.Base.TabEURO.formTabEURO FormTabEuro = new Comum.Forms.Base.TabEURO.formTabEURO();
            FormTabEuro.ShowDialog();
            FormTabEuro.Dispose();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Forms.Base.TabCLASSE.formTabClasse FormTabClasse = new Comum.Forms.Base.TabCLASSE.formTabClasse();
            FormTabClasse.ShowDialog();
            FormTabClasse.Dispose();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Forms.Base.TabAGE.formTABAGE FormTabAge = new Comum.Forms.Base.TabAGE.formTABAGE();
            FormTabAge.ShowDialog();
            FormTabAge.Dispose();
        }
    }
}