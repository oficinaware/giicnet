using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.MVVM;
using GiicNetUI.Comum.Forms.Base.Clientes;

namespace GiicNetUI
{
    public partial class main : Form
    {
        GiicNetUI.Comum.Forms.Base.Clientes.formMenuClientes MenuClientForm { get; set; }
        //public GiicNetUI.Comum.Forms.Base.Clientes.formClientes ClientForm { get; set; }
        GiicNetUI.Comum.Forms.Base.Artigos.formArtigos ArticleForm { get; set; }
        GiicNetUI.Comum.Forms.Base.Artigos.formMenuArtigos MenuArticleForm { get; set; }
        GiicNetUI.Comum.Forms.Base.MeiosTrasporte.formMeiosTransporte FormMeiosTransporte { get; set; }
        GiicNetUI.Comum.Forms.Base.TabPag.formTabPag FormTabPag { get; set; }

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
            formClientes ClientForm = new Comum.Forms.Base.Clientes.formClientes();
            ClientForm.TopLevel = false;
            ClientForm.AutoScroll = true;
            ClientForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ClientForm);
            ClientForm.Show();

            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelTopo);
             MenuClientForm = new Comum.Forms.Base.Clientes.formMenuClientes();
            MenuClientForm.TopLevel = false;
            MenuClientForm.AutoScroll = true;
            MenuClientForm.Dock = DockStyle.Fill;
            this.panelTopo.Controls.Add(MenuClientForm);
            MenuClientForm.Show();
            MenuClientForm.Tag = ClientForm;
            // aqui
            if (panelPrincipal.Controls.Contains(ClientForm))
            {
                formClientes c1 = ClientForm;

            }
            // fim
        }

        private void barButtonItem64_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelPrincipal);
            ArticleForm = new Comum.Forms.Base.Artigos.formArtigos();
            ArticleForm.TopLevel = false;
            ArticleForm.AutoScroll = true;
            ArticleForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ArticleForm);
            ArticleForm.Show();

            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelTopo);
            MenuArticleForm = new Comum.Forms.Base.Artigos.formMenuArtigos();
            MenuArticleForm.TopLevel = false;
            MenuArticleForm.AutoScroll = true;
            MenuArticleForm.Dock = DockStyle.Fill;
            this.panelTopo.Controls.Add(MenuArticleForm);
            MenuArticleForm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormMeiosTransporte = new Comum.Forms.Base.MeiosTrasporte.formMeiosTransporte();
            FormMeiosTransporte.ShowDialog();
            FormMeiosTransporte.Dispose();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTabPag = new Comum.Forms.Base.TabPag.formTabPag();
            FormTabPag.ShowDialog();
            FormTabPag.Dispose();
        }
    }
}