using System;

namespace Guia
{

    class Tarea02
    {
        static void Main()
        {
            System.Console.WriteLine(200 + 56);
        }
    }

    
     class Tarea03
     {
         static void Main()
         {
             System.Console.WriteLine(5 * 2);
         }
     }

     class Tarea04
     {
         static void Main()
         {
             System.Console.WriteLine(321 - 213);           
         }
     }

     class Tarea05
     {
         static void Main()
         {

             System.Console.WriteLine("El resultado de: (20+5)%6");

             System.Console.WriteLine((20+5) %6);
         }
     }

     class Tarea06
     {
         static void Main()
         {
             int n1, n2, producto;



             n1 = 102;
             n2 = 12;
             producto = n1 * n2;

             System.Console.WriteLine("La multip de {0} y {1} es {2}",n1, n2, producto);
         }
     }

    class Tarea07
    {
        static void Main()
        {
            int n1, n2, suma;



            n1 = 200;
            n2 = 1111;
            suma = n1 + n2;

            System.Console.WriteLine("La multip de {0} y {1} es {2}", n1, n2, suma);
        }
    }

    class Tarea08
    {
        static void Main()
        {
            int numero1, numero2, producto;

            numero1 = 10;
            numero2 = 25;
            producto = numero1 * numero2;

            System.Console.WriteLine("La multip de {0} y {1} es {2}", numero1, numero2, producto);
            
        }
    }

    class Tarea09
    {
        static void Main(string[] args)
        {
            float n1, n2, producto;
            Console.WriteLine("Ingrese el primer numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el srgundo numero:");
            n2 = float.Parse(Console.ReadLine());

            producto = n1 * n2;

            Console.WriteLine("El producto de {0} y {1} es igual a: {2}", n1, n2, producto);

        }
    }

    class Tarea10
    {
        static void Main(string[] args)
        {
            float n1;

            Console.WriteLine("Ingrese el primer numero:");
            n1 = System.Convert.ToInt32(Console.ReadLine());
            if (n1 % 2 == 0)
                Console.WriteLine("el numero ingresado {0}, es par.", n1);
            else Console.WriteLine("El numero ingresado es impar");

        }
    }

    class Tarea11
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Ingrese el primer numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el srgundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2) Console.WriteLine("El numero {0}, es mayor que, {1}", n1, n2);
            else
                if (n1 < n2) Console.WriteLine("el Numero {0}, es menor que, {1}", n1, n2);
            else Console.WriteLine("Los numero son iguales");

        }

    }

    class Tarea12
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Ingrese el primer numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el srgundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 != 0) Console.WriteLine("El resultado de {0} dividio {1} es {2}", n1, n2, (n1 / n2));
            else Console.WriteLine("Error");
            
        }
    }

    class Tarea13
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Ingrese un numero del 1 al 5:");
            n1 = Convert.ToInt32(Console.ReadLine());

            switch (n1)
            {
                case 1: Console.WriteLine("Uno");
                    break;
                case 2: Console.WriteLine("Dos");
                    break;
                case 3: Console.WriteLine("Tres");
                    break;
                case 4: Console.WriteLine("Cuatro");
                    break;
                case 5: Console.WriteLine("Cinco");
                    break;
            }

        }
    }

    
    class Tarea14
    {
        static void Main (string[] args)
        {
            int n1=1;
           
            while(n1<11)
            {
                Console.WriteLine(n1);
                n1 = n1 + 1;
            }
        }
    }

    class Tarea15
    {
        static void Main(string[] args)
        {
            int n1 = 0;

            do
                Console.WriteLine(n1=n1+1);
              
            while (n1 < 10);

        }
    }
    
    class Tarea16
    {
        static void Main(string[] args)
        {
            int n1;
            for (n1 = 10; n1 <= 20; n1++)
                Console.Write("{0},",n1);

        }

    }
    

}