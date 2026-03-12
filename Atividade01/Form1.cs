using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text != string.Empty)
            {

            
                int idadeUsuario = int.Parse(txtCampo.Text);
            
                // se a idade do usuario for maior ou igual a 18
                // resultado: Você é maior de idade

                if (idadeUsuario >= 18 )
                {
                    //MessageBox.Show("Você é MAIOR de idade");
                    lbResultado.Text = "Você é MAIOR de idade";
                } else
                {
                    //MessageBox.Show("Você é MENOR de idade");
                    lbResultado.Text = "Você é MENOR de idade";
                }
            } else
            {
                MessageBox.Show("Por favor insira a sua idade",

                    "mensagem de aviso");
            }
        }

        private void txtCampo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            int numeroUsuario = int.Parse(txtCampo.Text);
            int resultado;
            string respostaFinal = "";

            //para variavel inicial, condição, calculo

            for (int contador = 1; contador <= 10; contador += 1)
            {
                resultado = numeroUsuario * contador;
                respostaFinal = respostaFinal + numeroUsuario + "x" + contador + "=" + resultado + "\n";
            }

            MessageBox.Show(respostaFinal, "Tabuada do " + numeroUsuario);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            {
                // etapa 01 - gerar um numero aleatorio
                Random aleatorio = new Random();
                int numeroSorteado = aleatorio.Next(1, 11);

                string numeroSecretoSorteado = lbResultado.Text;
                string numeroDigitadoUsuario = txtCampo.Text;

                if (numeroSecretoSorteado == "Resultado")
                {
                    lbResultado.Text = numeroSecretoSorteado.ToString();
                    numeroSecretoSorteado = numeroSorteado.ToString();
                    lbResultado.Visible = false;
                }
                // etapa 02 - pegar valor do usuario e validar se é igual ao numero sorteado
                if (numeroSecretoSorteado == numeroDigitadoUsuario)
                {
                    MessageBox.Show("Parabéns você ganhou!!");
                }
                // etapa 03 - validar se o numero é maior ou menor que o numero sorteado
                if (int.Parse(numeroDigitadoUsuario) > int.Parse(numeroSecretoSorteado))
                {
                    MessageBox.Show("O numero que voce digitou é MAIOR que o valor secreto");
                }
                // etapa 04 - validar se o numero é menor que o numero sorteado
                if (int.Parse(numeroDigitadoUsuario) < int.Parse(numeroSecretoSorteado))
                {
                    MessageBox.Show("O numero que você digitou é MENOR que o valor secreto");
                }
            }
        }

        private void btnAprendendo_Click(object sender, EventArgs e)
        {
            
                int qntRepeticao = int.Parse(txtCampo.Text);
                int contador = 1;
                //enquanto
                while (contador <= qntRepeticao)
                {
                MessageBox.Show("Estou aprendendo laço de repetição: x" + contador);

                contador++;
                }           
        }

        private void btnContar10_Click(object sender, EventArgs e)
        {
            //break
            //continue
            int numeroUsuario = 7;
            int contador = 0;

            while (contador < 10)
            {
                contador++; //11

                if (contador == numeroUsuario)
                {
                    // continue da 'um pulo' no código, ele faz o
                    // loop voltar para o começo e ignora o resto do laço
                    // continue;

                    // break finaliza a execução do loop todo, diferente do continue que
                    // vai rodar até finalizar o laço o break força o laço a ser finalizar
                    break;
                }
                MessageBox.Show("Conta" + contador);
            }
        }
    }
}