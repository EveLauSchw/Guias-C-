using System;

namespace Guia3
{
    /*class Tarea1
    //Tarea 1: Crea una función llamada "Signo", que reciba un número real,
    //y devuelva un número entero con el valor:
    //-1 si el número es negativo, 1 si es positivo o 0 si es cero.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Signo(n1);
        }
        static void Signo(int n1)
        {
            if (n1 > 0)
            {
                Console.WriteLine("1");
            }
            else if (n1 < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }

    }
    */

    /*class Tarea2
     //Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros
     //q recibirá como parámetros.El resultado será otro número entero.
    {
        static void Main(string[] args)
        {
            int nro1, nro2, resultado;
            int Menor(int param1, int param2)
            {
                if(param1<param2)
                {
                    return param1;
                }
                else
                {
                    return param2;
                }
            }
            Console.WriteLine("Ingrese un valor entero:");
            nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo valor entero:");
            nro2 = int.Parse(Console.ReadLine());

            resultado = Menor(nro1, nro2);
            Console.WriteLine("El menor es: {0}" , resultado);


        }
    }
    */

    /*class Tarea3
    //Tarea 3: Crea una función "EsPrimo", que reciba un número y devuelva el valor
    //booleano "true" si es un número primo o "false" en caso contrario.
    
    //Los números primos son aquellos números naturales que solamente se pueden dividir
    //por sí mismos y por 1, es decir,
    //que si intentamos dividirlos por cualquier otro número,
    //el resultado no es entero.

    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese un numero: ");
            int n = int.Parse(Console.ReadLine());
            EsPrimo(n);

        }

        static void EsPrimo(int n)
        {
            for (int i = 2; i < n; i++) 
            {
                if (n % i == 0)
                {
                    Console.WriteLine(false);
                    break;
                }
                else
                {
                    Console.WriteLine(true);
                    break;
                }
            }


        }
    }
    */
    /*
    class Tarea4
    {
        static void Main(string[] args)
        {
            //Se utiliza para limpiar la consola.
            Console.Clear();


            //Definimos la cantidad de filas q va a tener nuestro triangulo.
            for (int fila = 1; fila <= 7; fila++)
            {
                //En este for lo que le decimos es q vaya descontando espacios hasta el final.
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" ");

                //En este bucle lo q hacemos es q con el 2*fila,
                //agregemos una fila extra al triangulo cuando lo ejecutemos en la consola
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write(" * ");

                Console.WriteLine("");
            }
        }
    }
    */

    class Tarea5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleije una opcion a calcular:");
            Console.WriteLine("Opcion-1 Suma");
            Console.WriteLine("Opcion-2 Resta");
            Console.WriteLine("Opcion-3 Multipica");
            Console.WriteLine("Opcion-4 Divide");
            Console.WriteLine("----------------------------");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------");
            Calcula(a, b, opcion);



        }

        public static void Calcula(int a, int b, int opcion)

        {

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El resultado es: {0}", a + b);
                    break;
                case 2:
                    Console.WriteLine("El resultado es: {0}", a - b);
                    break;
                case 3:
                    Console.WriteLine("El resultado es: {0}", a * b);
                    break;
                case 4:
                    Console.WriteLine("El resultado es: {0}", a / b);
                    break;

            }

        }
    }

    class Tarea6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero:");

            Console.WriteLine("----------------------------");
            int suma = int.Parse(nameof);
            int acum = 0;
            do
            {
                for(int i = 0; i <= (n.Length - 1); i++)
                acum = 0;
                while (suma > 0)
                {
                    var cifra = suma % 10;
                    acum += cifra;
                }
            }
        }
    }
}




