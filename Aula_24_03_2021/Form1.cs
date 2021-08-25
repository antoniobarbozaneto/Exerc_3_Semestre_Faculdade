using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_24_03_2021
{
    public partial class Form1 : Form
    {
        Pessoa Pe;
        public Form1()
        {
            Pe = new Pessoa(); //estanciando o obj da classe Pessoa.
            InitializeComponent();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pe.Incluir(txb_nome.Text, txb_idade.Text, txb_cpf.Text, txb_rua.Text, txb_num.Text, txb_cep.Text, txb_bairro.Text);

            //Dessa maneira acima garante que não tem como ele fazer apenas 1 metodo inves de fazer os 2 Incluir Pessoa e Endereco.

          
            //  Pe.Incluir(txb_nome.Text,txb_idade.Text,txb_cpf.Text);
          //  Pe.End.Incluir(txb_bairro.Text, txb_num.Text, txb_cep.Text, txb_bairro.Text);

           /*
             Pe.End.Rua = "13 maio"; //setando o atr rua do objeto End, que está dentro da objeto PE.
             Pe.Nome = txb_nome.Text;
             Pe.Idade = Convert.ToInt32(txb_idade.Text);
             Pe.Cpf = Convert.ToDouble(txb_cpf.Text);
           */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = " Nome: " + Pe.Nome + ", Idade: " + Pe.Idade + ", Cpf: " + Pe.Cpf + ", Rua: " + Pe.End.Rua + ", Num: " + Pe.End.Num + ", Bairro: " + Pe.End.Bairro + ", Cep: " + Pe.End.Cep;

            /*
             txb_nome.Text = Pe.Nome;
             txb_idade.Text = Convert.ToString(Pe.Idade);
             txb_cpf.Text = Convert.ToString(Pe.Cpf);
            /*
            txb_nome.Text = Pe.Nome;
            txb_idade.Text = Convert.ToString(Pe.Idade);
            txb_cpf.Text = Convert.ToString(Pe.Cpf);
            txb_rua.Text = Pe.End.Rua;
            txb_num.Text = Convert.ToString(Pe.End.Num);
            txb_bairro.Text = Pe.End.Bairro;
            txb_cep.Text = Convert.ToString(Pe.End.Cep);
            //Convertendo os dados para String para exibir nas TextBoxs
            */


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
