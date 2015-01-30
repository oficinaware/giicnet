using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiicNetUI.Forms.Testes
{
    public partial class teste_pivot : Form
    {
        public teste_pivot()
        {
            InitializeComponent();
        }

        private void teste_pivot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataGiicNetDataSet.CLIENTES_BR' table. You can move, or remove it, as needed.
            this.cLIENTES_BRTableAdapter.Fill(this.dataGiicNetDataSet.CLIENTES_BR);

        }
    }
}
