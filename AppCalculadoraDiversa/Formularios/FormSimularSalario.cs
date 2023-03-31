using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadoraDiversa.Formularios
{
    public partial class FormSimularSalario : Form
    {
        public FormSimularSalario()
        {
            InitializeComponent();
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtSalario.Clear();
            txtTotalDeVendas.Clear();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int index = cbCargo.SelectedIndex;
            double salariofinal = 0, salariobruto = 0;
            int totaldevendas;

            salariobruto = Convert.ToDouble(txtSalario.Text);
            totaldevendas = Convert.ToInt32(txtTotalDeVendas.Text);

            //vendas * porcentagem + salario

            switch (index)
            {
                //estagiário 2
                case 0:
                    salariofinal = totaldevendas * 0.02 + salariobruto;
                    lbResultado.Text = ("Cargo de vendedor Estagiário. Salário final de R$" + salariofinal);
                    break;

                //junior 5
                case 1:
                    salariofinal = totaldevendas * 0.05 + salariobruto;
                    lbResultado.Text = ("Cargo de vendedor Júnior. Salário final de R$" + salariofinal);
                    break;

                //pleno 7
                case 2:
                    salariofinal = totaldevendas * 0.07 + salariobruto;
                    lbResultado.Text = ("Cargo de vendedor Pleno. Salário final de R$" + salariofinal);
                    break;

                //senior 10 
                case 3:
                    salariofinal = totaldevendas * 0.10 + salariobruto;
                    lbResultado.Text = ("Cargo de vendedor Sênior. Salário final de R$" + salariofinal);
                    break;

                //gerente 12
                case 4:
                    salariofinal = totaldevendas * 0.12 + salariobruto;
                    lbResultado.Text = ("Cargo de vendedor Gerente. Salário final de R$" + salariofinal);
                    break;
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
