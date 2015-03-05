using GiicNetModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiicNetUI.Comum.Forms.Base.Clientes
{
    public partial class formManutClientes : Form
    {
        public string idCliente { get; set; }

        public formManutClientes()
        {
            InitializeComponent();
        }        

        private void formManutClientes_Load(object sender, EventArgs e)
        {
            if(idCliente != string.Empty)
            {
                var context = new DataGiicNetEntities();
                GiicNetBus.Base.Clientes busClientes = new GiicNetBus.Base.Clientes(context);
                var modelCliente = busClientes.GetByKey(idCliente);

                CLIENTE.Text = idCliente;
                CLIENTE.Enabled = false;
                DATAREG.EditValue = modelCliente.DTINI;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}