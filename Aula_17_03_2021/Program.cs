using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17_03_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste obj1; // nome p objeto
            obj1 = new Teste(); //"criando/estanciando" o obj
            /////
            ///
            Teste obj2 = new Teste(); //Aqui faz tudo da mesma forma. 

            obj1.aux = "Hello World!"; //Aqui está (Atribuindo/passando um valor) pro aux do obj1, aux atributo que está na classe Teste.cs

            Console.WriteLine("obj1.aux : " + obj1.aux);

            obj1.Ola(); //Chamando o metodo do obj1

            Console.ReadKey();
        }
    }
}
