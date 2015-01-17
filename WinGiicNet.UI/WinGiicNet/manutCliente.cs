using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GiicNetBus.Base;
using GiicNetModels;

namespace WinGiicNet
{
    public partial class manutCliente : Form
    {
        public manutCliente()
        {
            InitializeComponent();
        }

        public static string idCliente;

        private void manutCliente_Load(object sender, EventArgs e)
        {
            if (idCliente == "")
            {

            }
            else
            {
                //GET
                CLIENTES cL = new CLIENTES();
                GiicNetBus.Base.Clientes gC = new Clientes();
                cL = gC.GetByKey(idCliente);

                txtCLIENTE.Text = cL.CLIENTE;
                txtNOME.Text = cL.NOME;
                txtNOMEABR.Text = cL.NOMEABR;
                txtMORADA1.Text = cL.MORADA1;
                txtMORADA2.Text = cL.MORADA2;
                txtMORADA3.Text = cL.MORADA3;

                //data_inativo.DateTime = cL.DATA_INACTIVO.Value;
                if (!isNull(cL.DATA_INACTIVO, "System.DateTime")) data_inativo.DateTime = cL.DATA_INACTIVO.Value;
                plf.EditValue = cL.PLAFOND;
            }
        }

        private bool isNull(object value, string tipo)
        {
            bool result = false;
            try
            {
                switch (tipo)
                {
                    case "System.DateTime":
                        if ((DateTime)value == System.DateTime.Now) result = false;
                        else result = false;
                        break;
                    default:
                        break;
                }                
            }
            catch
            {
                return true;
            }
            return result;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CLIENTES cZ = new CLIENTES();
            cZ.DATA_INACTIVO = data_inativo.DateTime;
            cZ.PLAFOND = Convert.ToDecimal(plf.Text);
        }
    }
}
