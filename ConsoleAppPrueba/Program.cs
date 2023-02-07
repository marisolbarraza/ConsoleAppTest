using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            
            // Console.WriteLine("Holi mundo");
          
            /* #region Declaración de una variable
            //Declaración de una variable -> si o si se deben ser declaradas explicitamente antes de usarse. 
            int edad = 20;
            Console.WriteLine(edad);

            int numero;
            numero = 2;
            Console.WriteLine(numero);
            #endregion

            #region ejercicios convirtiendo valores

            Console.Write("Introduzca un nro: ");
            numero= int.Parse(Console.ReadLine());
            //numero = Console.Read();
            Console.WriteLine("el número es:"+ numero);
            Console.ReadKey(); //lee una tecla que se ha presionado. 
            String texto= numero.ToString();//sirve para convertir en un String 

            #endregion*/
         
            #region Reglas de asignación
            int num1;
            int num2;
            num1 = num2 = 10;
            Console.WriteLine(num1 + " "+ num2);

            int num3, num4, num5=10; //solo está inicializado num5, num 4 y num3 no, por lo que usarlos daría error. 
            #endregion

            #region contadores posfijos y sufijos
            num3 = 1;
            Console.WriteLine(num3 + " " + num3++ + " " + num3); //num3++ se hace despues de mostrar
            Console.WriteLine(num3 + " "+ ++num3 + " "+ num3);//++num3 se hace antes de mostrar

            num4 = 5;
            Console.WriteLine(num4 + " " + num4-- + " " + num4); //num3++ se hace despues de mostrar
            Console.WriteLine(num4 + " " + --num4 + " " + num4);//++num3 se hace antes de mostrar
            #endregion

            #region variables implícitas
            var num = 1;
            //num = "ddd"; No está admitido ya que la variable se inicializó con un valor int implicitamente. 
            #endregion

            #region métodos
            //método sin tipo
            int numero1 = 2;
            int numero2 = 3;

            SumaSinTipo(numero1, numero2);
            //-----------------------------------------------------------
            void SumaSinTipo(int nroA, int nroB)
            {
                int suma= SumaConTipo(nroA, nroB);  
                Console.WriteLine("Función sin tipo: "+ suma);
            }

            //método con tipo
            int SumaConTipo(int nroA, int nroB)
            {
                return nroA+ nroB;
            }
            #endregion

        }
    }
}
