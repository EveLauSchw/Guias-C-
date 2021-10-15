using System;

namespace Guia2

{
    /*  class Tarea1
       //Tarea 1: Crea un programa que pida al usuario su identificador y su contraseña 
       //(ambos numéricos), y no le permita seguir hasta que introduzca 
       //como identificador "1234" y como contraseña "1111".
      {
          static void Main(string[] args)
          {
              int log , pass;

              {
                  Console.Write("Ingrese su Loguin numerico: ");
                  log = Convert.ToUInt16(Console.ReadLine());
                  Console.Write("Ingrese su Contraseña numerica: ");
                  pass = Convert.ToUInt16(Console.ReadLine());



                  do
                  {
                      Console.WriteLine("Ingrese su loguin; ");
                      log = Convert.ToInt16(Console.ReadLine());
                      Console.WriteLine("Ingrese su Contraseña numerica");
                      pass = Convert.ToInt16(Console.ReadLine());


                      if (pass != 1111 && log!=1234 ) // lo toma como true
                          Console.WriteLine("Acceso NO habilitado");
                  }
                  while (pass != 1111 && log != 1234); //lo toma como falso
                  Console.WriteLine("Acceso Habilitado");

              }

          }
      }*/

    /*
     class Tarea2
        //Tarea 2: Crea un programa calcule cuantas cifras tiene un número entero positivo
        //(pista: se puede hacer dividiendo varias veces entre 10).
    {
        static void Main(string[] args)
        {
            int numero, contador;
            contador = 0;

            
            {
                Console.Write("Ingrese un numero entero positivo:\n ");
                numero = Convert.ToInt32(Console.ReadLine());
                
                while (numero != 0)
                {
                    numero /=10;
                    ++contador;
                }
                    Console.WriteLine("El numero de digitos de nu numero ingresado es: {0} ", contador);
            }
            
        }
    }
    */

    /*
    class Tarea3
    //Tarea 3: Crea un programa que muestre la tabla de multiplicar del 9.
    {
        static void Main(string[] args)
        {
           
            {
                int n, tabla;
                

                Console.Write("TABLA DEL 9: \n");

                for  ( n = 1; n <= 10; n++)
                    for (tabla = 9; tabla <= 9; tabla ++)
                        
                        
                    Console.WriteLine("{0} X {1} = {2}", n, tabla, n*tabla);
                
             
            }

        }
    }
    */
    /*
    class Tarea4
    //Tarea 4: Crea un programa que contenga un bucle sin fin
    //que muestre los números enteros positivos a partir del uno.
    {
        static void Main(string[] args)
        {

            {
                int i ;


                Console.Write("Bucle sin fin de pares enteros: \n");

                for (i = 0; ; i++)
                  
                  Console.WriteLine (i);


            }

        }
    }
    */
    class Tarea5
    //Tarea 5: Crea un programa que contenga un bucle sin fin que escriba
    //"Hola " en pantalla, sin avanzar de línea.
    {
        static void Main(string[] args)
        {

            {
                int i;
                for (i = 0; ; i++)
                {
                    Console.WriteLine("Hola", i);
                    break;
                }

            }

        }
    }




    /*
    class Tarea6
    { //Tarea 6: ¿Cuál sería el resultado de las siguientes operaciones? 
      //a=5; b=++a; c=a++; b=b*5; a=a*2; 

        static void Main (string[] args)
        {
            int a = 5, b,c;
            Console.WriteLine("El valor de A es : {0} ", a);

            b = ++a;
            Console.WriteLine("El valor de B es : {0} ", b);

            c = a++;
            Console.WriteLine("El valor de C es : {0} ", c);

            b = b * 5;
            Console.WriteLine("El valor de B multiplicado 5 es : {0} ", b);

            a = a * 2;
            Console.WriteLine("El valor de A multiplicado 2 es : {0} ", a);
        }
    }
    */

    /*
    class Tarea7
    { //Tarea 7: ¿Cuál sería el resultado de las siguientes operaciones?
      //a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b; 
        static void Main(string[] args)
        {
            int a = 5, b, c;

            Console.WriteLine("El valor de A es : {0} ", a);

            b = a + 2;
            Console.WriteLine("El valor de B es : {0} ", b);
            
            b -= 3;
            Console.WriteLine("El valor de B menos 3 es : {0} ", b);
           
            c = -3;
            Console.WriteLine("El valor de C es : {0} ", c);
            
            c *= a ;
            Console.WriteLine("El valor de C multiplicado 2 es : {0} ", c);

            ++c;
            Console.WriteLine("El valor de C + 1 es: {0}", c);

            a *= b;
            Console.WriteLine("El valor de A multip B es: {0}", a);
        }


    }*/

    /*
    class Tarea8
    { //Tarea 8: Crea un programa que pida una letra al usuario
      //y diga si se trata de una vocal.
        static void Main(string[] args)
        {
            string letra;

            Console.WriteLine("Ingrese una letra");
            letra = (Console.ReadLine());

            if ((letra == "a") || (letra == "e") || (letra == "i") || (letra == "o") || (letra == "u"))
                Console.WriteLine("La letrea ingresada es una vocal");

            else Console.WriteLine("La letra ingresada no es vocal");
        }
    */

    /*
        class Tarea9
        {
            // Tarea 9: Crear un programa que pida al usuario un nombre y una contraseña.
            // La contraseña se debe introducir dos veces.
            // Si las dos contraseñas no son iguales, se avisará al usuario y se le
            //volverán a pedir las dos contraseñas.

            static void Main(string[] args)
            {
                int loguin, pass1, pass2;

                do
                {
                    Console.WriteLine("Ingrese su loguin; ");
                    loguin = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese su Contraseña numerica");
                    pass1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese nuevamente su Contraseña numerica");
                    pass2 = Convert.ToInt16(Console.ReadLine());

                    if (pass1 != pass2) // lo toma como true
                        Console.WriteLine("Acceso NO habilitado");

                }
                while (pass1 != pass2); //lo toma como falso
                Console.WriteLine("Acceso Habilitado");
            }

        }
    */

    /*
        class Tarea10
        {
            // Tarea 10: Crear un programa que pida al usuario su nombre,
            // y le diga "Hola" si se llama "Martín",
            // o bien le diga "No te conozco" si teclea otro nombre.
            static void Main(string[] args)
            {
                string valida1 = "Evelyn";

                string clave;

                do
                {
                    Console.WriteLine("Ingrese su Nombre registrado; ");
                    clave = Console.ReadLine();
                    if (clave != valida1)
                        Console.WriteLine("No te conozco...");
                }
                while (clave != valida1); //lo toma como falso
                Console.WriteLine("Hola, Eve!!");
            }

        }

    }
    */

}