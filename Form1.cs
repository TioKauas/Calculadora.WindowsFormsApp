using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.WindowsFormsApp
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        public decimal num1 { get; set; }

        public decimal Resultado { get; set; }

        private Operacao operacaoSelecionado { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResult.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textResult.Text += "0";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            operacaoSelecionado = Operacao.Adicao;
            num1 = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            lblOperacao.Text += "+";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacaoSelecionado = Operacao.Subtracao;
            num1 = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            lblOperacao.Text += "-";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            operacaoSelecionado = Operacao.Multiplicacao;
            num1 = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            lblOperacao.Text += "X";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionado = Operacao.Divisao;
            num1 = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            lblOperacao.Text += "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacaoSelecionado)
            {
                case Operacao.Adicao:
                    Resultado = num1 + Convert.ToDecimal(textResult.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = num1 - Convert.ToDecimal(textResult.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = num1 * Convert.ToDecimal(textResult.Text);
                    break;
                case Operacao.Divisao:
                    if (Convert.ToDecimal(textResult.Text) == 0 || num1 == 0)
                    {
                        MessageBox.Show("Erro: Não é possível dividir por zero (0)");
                    }
                    else
                    {
                        Resultado = num1 / Convert.ToDecimal(textResult.Text);
                    }
                    break;
                default:
                    break;
            }

            textResult.Text = Convert.ToString(Resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            lblOperacao.Text = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!textResult.Text.Contains(","))
            {
                textResult.Text += ",";
            }
        }
    }
}
