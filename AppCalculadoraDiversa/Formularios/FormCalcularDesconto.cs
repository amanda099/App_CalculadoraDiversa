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
    public partial class FormCalcularDesconto : Form
    {
        public FormCalcularDesconto()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtValorTotal.Clear();
            txtValorDaCompra.Clear();
            txtValorDoDesconto.Clear();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int index = cbCliente.SelectedIndex;

            //desconto:
            //cliente comum -> 3% desc
            //cliente especial -> 5% desc
            //cliente VIP -> 10% desc
            //premium -> 12% desc

            double valorCompra = 0, valorDesconto = 0, valorTotalCompra = 0;

            valorCompra = Convert.ToDouble(txtValorDaCompra.Text);

            switch (index)
            {
                case 0:
                    valorDesconto = valorCompra / 100 * 3;
                    valorTotalCompra = valorCompra - valorDesconto;

                    txtValorDoDesconto.Text = valorDesconto.ToString("C");
                    txtValorTotal.Text = valorTotalCompra.ToString("C");

                    break;
                case 1:
                    valorDesconto = valorCompra / 100 * 5;
                    valorTotalCompra = valorCompra - valorDesconto;
                    

                    txtValorDoDesconto.Text = valorDesconto.ToString("C");
                    txtValorTotal.Text = valorTotalCompra.ToString("C");
                    break;
                case 2:
                    valorDesconto = valorCompra / 100 * 10;
                    valorTotalCompra = valorCompra - valorDesconto;
                    

                    txtValorDoDesconto.Text = valorDesconto.ToString("C");
                    txtValorTotal.Text = valorTotalCompra.ToString("C");
                    break;
                case 3:
                    valorDesconto = valorCompra / 100 * 12;
                    valorTotalCompra = valorCompra - valorDesconto;

                    txtValorDoDesconto.Text = valorDesconto.ToString("C");
                    txtValorTotal.Text = valorTotalCompra.ToString("C");
                    break;
            }   
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCliente.SelectedIndex;
            switch (index)
            {
                case 0:
                lbTipoCliente.Text = ("Cliente do tipo COMUM recebe 3% de desconto!");

                    break;
                case 1:
                lbTipoCliente.Text = ("Cliente do tipo ESPECIAL recebe 5% de desconto!");
                    
                    break;
                case 2:
                    lbTipoCliente.Text = ("Cliente do tipo VIP recebe 10% de desconto!");

                    break;
                case 3:
                lbTipoCliente.Text = ("Cliente do tipo PREMIUM recebe 12% de desconto!");

                    break;
                default:
                    break;
            }
        }
    }
}
