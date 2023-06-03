using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configuración del logger
            Log.Logger = new LoggerConfiguration()
                            .WriteTo.File("Tejada.txt")
                            .CreateLogger();

            //Console.WriteLine("Bye, World!");
            //Console.WriteLine("Hola, Mundo!");
            //Saludar();
            //Convertir();
            //Convertir2();
            ExamenParcial obj = new();
            obj.Pregunta1();
            //obj.Pregunta2();
            //obj.Pregunta3();
            //obj.Pregunta4();
            //obj.Pregunta5();
        }

        public static void Saludar()
        {
            try
            {
                // Acá pueden ir los Log Informativos y de Advertencia
                Log.Information("Vamos a dividir dos numeros");

                int a = 10;
                int b = 0;
                int c = a / b;

                Log.Information("La división se realízó correctamente");

            }
            catch (Exception ex)
            {
                //Acá va el Log de Error
                Log.Error("No se pudo dividir, porqué " + ex.Message);
            }

        }

        public static void Convertir()
        {
            try
            {
                // Acá pueden ir los Log Informativos y de Advertencia
                Log.Information("Vamos a dividir dos numeros");

                Int16 b;
                Console.WriteLine("Ingrese un número int16");
                string a = Console.ReadLine();
                b = Int16.Parse(a);
                Console.WriteLine("El número ingresado es " + b);


                Log.Information("La división se realízó correctamente");

            }
            catch (Exception ex)
            {
                //Acá va el Log de Error
                Log.Error("No se pudo dividir, porqué " + ex.Message);
            }

        }

        public static void Convertir2()
        {
            try
            {
                // Acá pueden ir los Log Informativos y de Advertencia
                Log.Information("Vamos a dividir dos numeros");

                Int16 b;
                Console.WriteLine("Ingrese un número"); // hola
                string a = Console.ReadLine();
                b = Int16.Parse(a);
                Console.WriteLine("El número ingresado es " + b);


                Log.Information("La división se realízó correctamente");

            }
            catch (ArgumentNullException ex)
            {
                Log.Error("ArgumentNullException " + ex.Message);
            }
            catch (FormatException ex)
            {
                Log.Error("FormatException " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Log.Error("OverflowException " + ex.Message);
            }
            catch (Exception ex)
            {
                Log.Error("Exception " + ex.Message);
            }

        }
    }
}