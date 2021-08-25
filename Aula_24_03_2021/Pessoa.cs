using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_24_03_2021
{
    class Pessoa
    {
        //atr
        public string Nome;
        public int Idade;
        public double Cpf;

        public Endereco End; //Objeto dentro da classe Endereco

        //Met Construtor
        public Pessoa()
        {
            End = new Endereco();// Estanciando a classe Endereco dentro do Construtor.

       //     this.Nome = "Teste";
       //     this.Idade = 20;
       //    this.Cpf = 123456789;
        }

        //met
        public void Incluir(string Nome, string Idade,string Cpf) //jeito 1 de fazer
        {
            this.Nome = Nome;
            this.Idade = Convert.ToInt32(Idade);
            this.Cpf = Convert.ToDouble(Cpf);
        }

        public void Incluir(string Nome, string Idade, string Cpf, string Rua, string Num, string Cep, string Bairro) //jeito 2 de fazer
        {
            this.Nome = Nome;
            this.Idade = Convert.ToInt32(Idade);
            this.Cpf = Convert.ToDouble(Cpf);
         // End.Rua = Rua;
         // End.Num = Num;
            End.Incluir(Rua,Num,Cep,Bairro);
        }
    }
}
