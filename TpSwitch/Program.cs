using System;

namespace TpSwitch
{
    class Program
    {
        

        

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el monto a convertir en pesos ");
            int moneda = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elige una de las opciones");
            Console.WriteLine("1. Euro");
            Console.WriteLine("2. Dolar");
            Console.WriteLine("3. Real");
            Console.WriteLine("4. Libra");           

            string menu = Console.ReadLine();


            static void Dollar(int moneda)
            {
                Console.WriteLine(moneda * 98);
            }
            static void Euro(int moneda)
            {
                Console.WriteLine(moneda * 115);
            }
            static void Real(int moneda)
            {
                Console.WriteLine(moneda * 18);
            }
            static void Libra(int moneda)
            {
                Console.WriteLine(moneda * 135);
            }

            switch (menu)
            {
                case "1":
                    Euro(moneda);
                    break;
                case "2":
                    Dollar(moneda);
                    break;
                case "3":
                    Real(moneda);
                    break;
                case "4":
                    Libra(moneda);
                    break;

                default:
                    Console.WriteLine("Ingrese una opcion correcta");
                    break;
            }



        }
    }
}
