using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_24_03_2021
{
    class Endereco
    {
        //atr
        public string Rua;
        public int Num;
        public double Cep;
        public string Bairro;

        public Endereco()
        {
           /* this.Rua = ;
            this.Num = ;
            this.Cep = ;
            this.Bairro = ;
           */
        }

        public void Incluir (string Rua, string Num,string Cep,string Bairro)
        {
            this.Rua = Rua;
            this.Num = Convert.ToInt32(Num);
             this.Cep = Convert.ToDouble(Cep);
            this.Bairro = Bairro;
        }
    }
}
