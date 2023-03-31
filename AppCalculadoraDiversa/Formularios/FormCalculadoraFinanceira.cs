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
    public partial class FormCalculadoraFinanceira : Form
    {
        public FormCalculadoraFinanceira()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtCapital.Clear();
            txtCapital.BackColor = Color.White;
            txtJuros.Clear();
            txtMontante.Clear();
            txtMontante.BackColor = Color.White;
            txtTaxa.Clear();
            txtTaxa.BackColor = Color.White;
            txtTempo.Clear();
            txtTempo.BackColor = Color.White;
        }

        private void cmbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMontante.BackColor = Color.White;
            txtMontante.ReadOnly = false;

            txtCapital.BackColor = Color.White;
            txtCapital.ReadOnly = false;

            txtTaxa.BackColor = Color.White;
            txtTaxa.ReadOnly = false;

            txtTempo.BackColor = Color.White;
            txtTempo.ReadOnly = false;

            

            int index = cmbOpcao.SelectedIndex;

            switch (index)
            {
                case 0:
                    {
                        txtMontante.BackColor = Color.LightGray;
                        txtMontante.ReadOnly = true;
                        break;
                    }

                case 1:
                    {
                        txtCapital.BackColor = Color.LightGray;
                        txtCapital.ReadOnly = true;
                        break;
                    }

                case 2:
                    {
                        txtTaxa.BackColor = Color.LightGray;
                        txtTaxa.ReadOnly = true;
                        break;
                    }

                case 3:
                    {
                        txtTempo.BackColor = Color.LightGray;
                        txtTempo.ReadOnly = true;
                        break;                        
                    }
                
                default:
                    break;
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double juros = 0, montante = 0, capital = 0, taxa = 0, tempo = 0;
            int index = cmbOpcao.SelectedIndex;

            //>>>>>>preencher com os calculos<<<<<<<

            switch (index)
            {
                case 0:
                    { //montante
                        capital = Convert.ToDouble(txtCapital.Text);
                        tempo = Convert.ToDouble(txtTempo.Text);
                        taxa = Convert.ToDouble(txtTaxa.Text);
                        taxa = taxa / 100;
                        montante = capital * (1 + taxa * tempo);
                        juros = montante - capital;
                        txtMontante.Text = montante.ToString("C");
                        txtJuros.Text = juros.ToString("C");
                        break;
                    }
                
                case 1:
                    { //capital
                        montante = Convert.ToDouble(txtMontante.Text);
                        taxa = Convert.ToDouble(txtTaxa.Text);
                        tempo = Convert.ToDouble(txtTempo.Text);
                        taxa = taxa / 100;
                        capital = montante / (1 + taxa * tempo);
                        juros = montante - capital;
                        txtCapital.Text = capital.ToString("C");
                        txtJuros.Text = juros.ToString("C");
                        break;
                    }
                
                case 2:
                    { //taxa
                        montante = Convert.ToDouble(txtMontante.Text);
                        capital = Convert.ToDouble(txtCapital.Text);
                        tempo = Convert.ToDouble(txtTempo.Text);
                        taxa = (montante - capital) / (capital * tempo);
                        juros = montante - capital;
                        taxa = taxa * 100;
                        txtTaxa.Text = taxa.ToString() + "%";
                        txtJuros.Text = juros.ToString("C");
                        break;

                    }
                
                case 3:
                    { //tempo
                        montante = Convert.ToDouble(txtMontante.Text);
                        capital = Convert.ToDouble(txtCapital.Text);
                        taxa = Convert.ToDouble(txtTaxa.Text);
                        tempo = (montante - capital) / (capital * taxa);
                        txtTempo.Text = tempo.ToString();
                        txtJuros.Text = juros.ToString("C");
                        break;
                        
                    }
            }
        }

        private void txtTaxa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
