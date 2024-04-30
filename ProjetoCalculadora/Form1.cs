using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }


        private Operacao OperadorSelecionado { get; set; }

        // Enumeração para representar os diferentes tipos de operações
        private enum Operacao
        {
            Adicao,
            Subtrair,
            Multiplicar,
            Divisao
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            Limparlbl();
            txtResultado.Text += "9";
        }

        //Operadores
        private void btnDividir_Click(object sender, EventArgs e)
        {
            Limparlbl();

            if (decimal.TryParse(txtResultado.Text, out decimal numero))
            {
                OperadorSelecionado = Operacao.Divisao;
                Valor = numero;
                txtResultado.Text = " ";
                lblOperador.Text = "/";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Limparlbl();
            if (decimal.TryParse(txtResultado.Text, out decimal numero))
            {
                OperadorSelecionado = Operacao.Multiplicar;
                Valor = numero;
                txtResultado.Text = " ";
                lblOperador.Text = "x";
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Limparlbl();
            if (decimal.TryParse(txtResultado.Text, out decimal numero)) {
                {
                    OperadorSelecionado = Operacao.Subtrair;
                    Valor = numero;
                    txtResultado.Text = " ";
                    lblOperador.Text = "-";
                }
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Limparlbl();
            if (decimal.TryParse(txtResultado.Text, out decimal numero))
            {
                OperadorSelecionado = Operacao.Adicao;
                Valor = numero;
                txtResultado.Text = " ";
                lblOperador.Text = "+";
            }
        }
        // Métodos para lidar com cliques nos botões de operadores
        private void btnIgual_Click(object sender, EventArgs e)
        {
            Limparlbl();
            // Verifica se o texto do campo txtResultado é um número válido
            if (decimal.TryParse(txtResultado.Text, out decimal numero))
            {
                switch (OperadorSelecionado)
                {
                    case Operacao.Adicao:
                        Resultado = Valor + numero;
                        break;
                    case Operacao.Subtrair:
                        Resultado = Valor - numero;
                        break;
                    case Operacao.Divisao:
                        if (numero != 0) {
                            Resultado = Valor / numero;
                        }
                        else
                        {
                            lblTestZero.Text = "Impossivel Dividir por 0";
                        }
                        break;
                    case Operacao.Multiplicar:
                        Resultado = Valor * numero;
                        break;
                }
                txtResultado.Text = Convert.ToString(Resultado);
                lblOperador.Text = "=";
                
            }
        
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }
        // Método para lidar com o clique no botão de limpar
        private void btnLimpas_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperador.Text = "";
            lblTestZero.Text = "";
        }
        // Método para limpar o label de aviso
        private void Limparlbl()
        {
            lblTestZero.Text = "";
        }

        
      
    }
}
