using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudoPOO
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2= 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0"; // Vai juntar o número informado junto do que já tinha no textbox para poder concatenar os itens
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e) // Numero 7 
        {
            textBoxResultado.Text += "7"; 
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture/*comando para que a formatação seja mostrada com as casas decimais*/);

            textBoxResultado.Text = ""; //quando o botão + for apertado, o campo de texto será limpado para que a segunda operação possa entrar

            operacao = "SOMA"; //a operação irá ser igual a SOMA

            labelOperacao.Text = "+"; //o símbolo "+" será mostrado na label para identificar qual foi a operação selecionada

        }

        private void button2_Click(object sender, EventArgs e) // botão =
        {
            valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture/*comando para que a formatação seja mostrada com as casas decimais*/);

            if (operacao == "SOMA") // Se a operação for de soma:
            {
                textBoxResultado.Text = Convert.ToString(valor1 + valor2).Replace(".",","); // O valor será convertido para string para que possa ser exibido
                                                                                            // no textBox e o replace irá trocar os pontos por vírgula, quando
                                                                                            // o mesmo for convertido para string
            }
    
            if (operacao == "SUBTRACAO")
            {
                textBoxResultado.Text = Convert.ToString(valor1 - valor2).Replace(".", ","); 
            }

            if (operacao == "DIVISAO")
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2).Replace(".", ",");
            }

            if (operacao == "MULTIPLICACAO")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2).Replace(".", ",");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture/*comando para que a formatação seja mostrada com as casas decimais*/);

            textBoxResultado.Text = ""; //quando o botão - for apertado, o campo de texto será limpado para que a segunda operação possa entrar

            operacao = "SUBTRACAO"; //a operação irá ser igual a SUBTRACAO

            labelOperacao.Text = "-"; //o símbolo "-" será mostrado na label para identificar qual foi a operação selecionada
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture/*comando para que a formatação seja mostrada com as casas decimais*/);

            textBoxResultado.Text = ""; //quando o botão ÷ for apertado, o campo de texto será limpado para que a segunda operação possa entrar

            operacao = "DIVISAO"; //a operação irá ser igual a DIVISAO

            labelOperacao.Text = "÷"; //o símbolo "÷" será mostrado na label para identificar qual foi a operação selecionada
        }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture/*comando para que a formatação seja mostrada com as casas decimais*/);

            textBoxResultado.Text = ""; //quando o botão x for apertado, o campo de texto será limpado para que a segunda operação possa entrar

            operacao = "MULTIPLICACAO"; //a operação irá ser igual a MULTIPLICACAO

            labelOperacao.Text = "x"; //o símbolo "x" será mostrado na label para identificar qual foi a operação selecionada
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            labelOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += ".";
        }
    }
}
