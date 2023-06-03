using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba
{
    public class ExamenParcial
    {
        public void Pregunta1()
        {
            try
            {
                Int16 a;
                String b = "-33333";
                a = Int16.Parse(b);
                Console.WriteLine("El número es " + a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Pregunta2()
        {
            try
            {
                int a = 0;
                string b = "";
                a = int.Parse(b);
                Console.WriteLine("El número es " + a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Pregunta3()
        {
            //try
            //{
            //    int a, b = 2;
            //    int c = a / b;
            //    Console.WriteLine("El valor de c es : " + c);
            //}
            //catch (Exception ex)
            //{
            //    Log.Error("Exception " + ex.Message);
            //}
        }
        public void Pregunta4()
        {
            int a = 0, b = 1; a = b;
            Console.WriteLine("El resultado es " + a + b);
        }
    }
}
