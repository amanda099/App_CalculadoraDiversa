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
    public partial class FormCalcularRaizes : Form
    {
        public FormCalcularRaizes()
        {
            InitializeComponent();
        }

        private void cmbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTipoRaiz.SelectedIndex;

            switch (index)
            {
                case 0:
                    lbBase.Text = "Informe a base: ";
                    lbExpoente.Text = "Informe o expoente: ";
                    txtExpoente.ReadOnly = false;
                    break;

                case 1:
                    lbBase.Text = "Informe o radicando: ";
                    lbExpoente.Text = "Índice: ";
                    txtExpoente.ReadOnly = true;
                    double expoenteQuadrada = 1.0 / 2.0;
                    txtExpoente.Text = expoenteQuadrada.ToString();
                    break;

                case 2:
                    lbBase.Text = "Informe o radicando: ";
                    lbExpoente.Text = "Índice: ";
                    txtExpoente.ReadOnly = true;
                    double expoenteCubica = 1.0 / 3.0;
                    txtExpoente.Text = expoenteCubica.ToString();

                    break;

                case 3:
                    lbBase.Text = "Informe o radicando: ";
                    lbExpoente.Text = "Informe o índice: ";
                    txtExpoente.ReadOnly = false;
                   

                    break;

                default:

                    break;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtExpoente.Clear();
            txtResultado.Clear();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int index = cbTipoRaiz.SelectedIndex;
            double baze = 0, expoente = 0, resultado = 0;

            baze = Convert.ToDouble(txtBase.Text);
            expoente = Convert.ToDouble(txtExpoente.Text);

            switch (index)
            {
                //potência
                case 0:
                    resultado = Math.Pow(baze, expoente);
                    txtResultado.Text = resultado.ToString();
                    break;

                //raiz quadrada
                case 1:
                    resultado = Math.Pow(baze, expoente);
                    txtResultado.Text = resultado.ToString();
                    break;

                //raiz cubica
                case 2:
                    resultado = Math.Pow(baze, expoente);
                    txtResultado.Text = resultado.ToString();
                    break;

                //raiz enésima
                case 3:
                    double indiceEnesima = double.Parse(txtExpoente.Text);
                    indiceEnesima = 1.0 / indiceEnesima;
                    txtResultado.Text = indiceEnesima.ToString();

                    resultado = Math.Pow(baze, indiceEnesima);
                    txtResultado.Text = resultado.ToString();
                    break;

                default:

                    break;
            }
        }

        private void FormCalcularRaizes_Load(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
