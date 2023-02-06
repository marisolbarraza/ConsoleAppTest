using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region comentarios
            /*Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin sodales nulla urna. Donec pharetra pulvinar 
             metus non vestibulum. Ut tincidunt felis non viverra porta. Praesent lorem risus, hendrerit in rutrum eget */
            //Soy un simple comentario de línea
            #endregion
            Console.WriteLine("Holi mundo");

            #region Declaración de una variable
            //Declaración de una variable -> si o si se deben ser declaradas explicitamente antes de usarse. 
            int edad = 20;
            Console.WriteLine(edad);

            int numero;
            numero = 2;
            Console.WriteLine(numero);
            #endregion



        }
    }
}
