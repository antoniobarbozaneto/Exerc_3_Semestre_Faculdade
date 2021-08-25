using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS3_Aula_28_04_21_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa Pe = new Pessoa();

            Pe.Cod = 123; // nao tem get set
            MessageBox.Show(" "+Pe.Cod);// nao tem get set

            Pe.Gravar_Nome("Joao"); // Gravar e Ler PT
            MessageBox.Show(Pe.Ler_Nome());// Gravar e Ler PT

            Pe.Set_SobreNome("Silva"); // set e get manual
            MessageBox.Show(Pe.Get_SobreNome());// set e get manual

            Pe.Idade = -33;
            MessageBox.Show(""+Pe.Idade);

            Pe.RG = 321;
            MessageBox.Show("" + Pe.RG);
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa Pe = new Pessoa();

            Pe.End.Rua = " 13 maio";
            Pe.End.Bairro = " Centro";
            Pe.End.Num = 123;

            Pe.Cadastro("joao", 55);
            Pe.End.Cadastro("25marco", 123);

            Pe.Cadastro("joao", 55, "25marco", 123);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa Pe = new Pessoa();
            Endereco Aux = new Endereco();

            Aux.Rua = " 13 maio";
            Aux.Bairro = " Centro";
            Aux.Num = 123;
            Aux.CEP = "12320-000";
            Aux.UF = "SP";

            // Prova do conceito
            /*
            Pe.End.Rua = Aux.Rua; // tipo 1
            Pe.End.Bairro = Aux.Bairro;// tipo 1
            Pe.End.Num = Aux.Num;// tipo 1
            Pe.End.CEP = Aux.CEP;// tipo 1

            Pe.End = Aux; // tipo 2 troca // tipo 1
            */
            // fim da prova do conceito

            Pe.Cadastro("maria", 33, Aux);

            MessageBox.Show(Pe.Ler_Nome() + " " + Pe.Get_SobreNome() + " " + Pe.Idade + " ");
            MessageBox.Show(Pe.End.Rua + " " + Pe.End.CEP + " " + Pe.End.UF);

        }
    }
}
