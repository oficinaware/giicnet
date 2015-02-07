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
        public GiicNetUI.Comum.Forms.Base.Clientes.formClientes fClients { get; set; }

        public main()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelPrincipal);
            fClients = new Comum.Forms.Base.Clientes.formClientes();
            fClients.TopLevel = false;
            fClients.AutoScroll = true;
            fClients.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fClients);
            fClients.Show();

            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelTopo);
            GiicNetUI.Comum.Forms.Base.Clientes.formMenuClientes fMenuClientes = new Comum.Forms.Base.Clientes.formMenuClientes();
            fMenuClientes.TopLevel = false;
            fMenuClientes.AutoScroll = true;
            fMenuClientes.Dock = DockStyle.Fill;
            this.panelTopo.Controls.Add(fMenuClientes);
            fMenuClientes.Show();
            fMenuClientes.Tag = fClients;
        }

        private void barButtonItem64_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelPrincipal);
            GiicNetUI.Comum.Forms.Base.Artigos.formArtigos f = new Comum.Forms.Base.Artigos.formArtigos();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(f);
            f.Show();

            GiicNetUI.Comum.Helpers.PanelHelper.Clear(panelTopo);
            GiicNetUI.Comum.Forms.Base.Artigos.formMenuArtigos fM = new Comum.Forms.Base.Artigos.formMenuArtigos();
            fM.TopLevel = false;
            fM.AutoScroll = true;
            fM.Dock = DockStyle.Fill;
            this.panelTopo.Controls.Add(fM);
            fM.Show();
        }
    }
}