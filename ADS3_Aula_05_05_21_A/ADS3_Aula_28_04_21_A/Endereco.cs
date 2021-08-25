using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS3_Aula_28_04_21_A
{
    class Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Num { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }

        public Endereco()
        { 

        }
        public void Cadastro(string Rua, int Num)
        {
            this.Rua = Rua;
            this.Num = Num;
        }


    }
}
