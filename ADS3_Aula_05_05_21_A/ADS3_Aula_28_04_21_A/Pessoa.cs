using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS3_Aula_28_04_21_A
{
    class Pessoa
    {
        public int Cod;
        private string Nome;
        private string SobreNome;
        private int _idade; // idade xidade
        public int RG { get; set; } // isso é um metodo especial para get set basico (_rg)

        public Endereco End; 

        
        public Pessoa()
        {
            End = new Endereco(); // quando dentro de class deve ser feito no construtor 

            Cod = 0;
            Nome = "";
            SobreNome = "";
            _idade = 0;
            RG = 0;            
        }

        public string Ler_Nome()
        {
            return Nome;
        }
        public void Gravar_Nome(string Valor)
        {   
            // if testando o que vem do Valor
            Nome = Valor;
        }

        public string Get_SobreNome()
        {
            return SobreNome;
        }
        public void Set_SobreNome(string  SobreNome)
        {
            this.SobreNome = SobreNome;
        }

        public int Idade // usuario class vai ver 
        {
            get => _idade; // idade xidade
            set
            {
                if (value > 0) 
                {
                    _idade = value;
                }
            }
        }
        
        // feito lá junto com os atrib

        public void Cadastro(string Nome,int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public void Cadastro(string Nome, int Idade, string Rua, int Num) // nao recomendado
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.End.Rua = Rua;
            this.End.Num = Num;

        }
        public void Cadastro(string Nome, int Idade, Endereco xEnd)// recomendado 
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.End = xEnd;
        }

    }
}
