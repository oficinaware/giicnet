using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinGiicNet.Helper;

namespace WinGiicNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            manutCliente cC = new manutCliente();
            cC.ShowDialog();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //this.panel1.Controls.Clear();
            PanelHelper.Clear(panel1);
            PastaMenus.formMenu1 myForm = new PastaMenus.formMenu1();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(myForm);
            myForm.Show();

            //this.panel2.Controls.Clear();
            PanelHelper.Clear(panel2);
            PastaGrids.formGridClientes myFormGrid = new PastaGrids.formGridClientes();
            myFormGrid.TopLevel = false;
            myFormGrid.AutoScroll = true;
            myFormGrid.Dock = DockStyle.Fill;
            myFormGrid.tipoLoad = "1";
            this.panel2.Controls.Add(myFormGrid);
            myFormGrid.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //this.panel1.Controls.Clear();
            PanelHelper.Clear(panel1);
            PastaMenus.formMenu2 myForm = new PastaMenus.formMenu2();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel1.Controls.Add(myForm);
            myForm.Show();

            //this.panel2.Controls.Clear();
            PanelHelper.Clear(panel2);
            PastaGrids.formGridClientes myFormGrid = new PastaGrids.formGridClientes();
            myFormGrid.TopLevel = false;
            myFormGrid.AutoScroll = true;
            myFormGrid.Dock = DockStyle.Fill;
            myFormGrid.tipoLoad = "2";
            this.panel2.Controls.Add(myFormGrid);
            myFormGrid.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //this.panel2.Controls.Clear();
            PanelHelper.Clear(panel2);
            PastaGrids.formGridClientes myFormGrid = new PastaGrids.formGridClientes();
            myFormGrid.TopLevel = false;
            myFormGrid.AutoScroll = true;
            myFormGrid.Dock = DockStyle.Fill;
            myFormGrid.tipoLoad = "3";
            this.panel2.Controls.Add(myFormGrid);
            myFormGrid.Show();
        }
    }
}