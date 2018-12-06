using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejecicios_bucles
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            //pedir un numero y que se pare cuando sea negativo
            int i=0;
            int num;

            Console.WriteLine("Dame un numero positivo");
            num = Convert.ToInt32(Console.ReadLine());

            while(num>0)
            {
                Console.WriteLine("Dame otro numero");
                num = Convert.ToInt32(Console.ReadLine());
            }
           
            //lo mismo con do while

            int i = 1;
            int num;

            
            do  //es mejor hacer en este ejercicio un do while para que haga siempre el primero(aunque sea negativo)
            {
                Console.WriteLine("Dame un numero positivo");
                num = Convert.ToInt32(Console.ReadLine());
            }

            while (num > 0);
            {
                Console.WriteLine("El numero introducido es negativo");
                num = Convert.ToInt32(Console.ReadLine());
            }

            
            //pedir 4 numeros y escribir la suma total

            int suma = 0;
            int num;

            for (int i=0;i<4;i++)// hay que pensar que el numero iria pasando por cada una de las partes
                                 //condicion poner algo para que pare o filtre. lo ultimo es el "ritmo" que tiene que tomar
            {

                Console.WriteLine("Dame un numero");
                num = Convert.ToInt32(Console.ReadLine());                            
                suma = suma + num; //el valor suma va cambiando con cada bucle              
            }
            Console.WriteLine("Las suma de los 4 numeros es " + suma);

            
            //Escribe un programa que muestre en pantalla los números del 10 al 20 (incluidos los dos) 
            //con una línea vacía entre ellos.
            
            
            for(int i=10;i<21;i++)
            {
                Console.WriteLine("\n" +i);
            }
            
            //Escribe un programa que muestre en pantalla los números del 20 al 10(incluidos los dos) 
            //con una línea vacía entre ellos.

            for (int i = 20; i>9; i--)
            {
                Console.WriteLine("\n" + i);
            }
            
            //Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.

            int media = 0;
            int num;
            int suma=0;
            
            for (int i = 1; i < 11; i++)
            {

                Console.WriteLine("Dame un numero");
                num = Convert.ToInt32(Console.ReadLine());
                suma= suma + num; //el valor suma va cambiando con cada bucle    
                media = suma / i;
            }
            Console.WriteLine("La media los 10 numeros es " + media);
            
            //Escribe un programa que pida valores hasta que el usuario introduzca un 0. 
            //Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran los valores negativos. 
            //Mostrar la suma de los valores introducidos.

            int num;
            int media = 0;
            int suma = 0;
            int i= 1;
            Console.WriteLine("Dame un numero");
            num = Convert.ToInt32(Console.ReadLine());
            

            while (num != 0) //si el numero es distinto de cero,entra aqui
            {
                       if (num<0) // aqui ponemos la excepcion de que si es negativo (dentro de distinto de cero)
                       {
                             Console.WriteLine("Se ignoran los valores negativos");
                       }
                else // fuera de esa excepcion haria esto (es decir positivo istinto de cero
                
                {
                    suma = suma + num;                                   
                    media = suma / i;
                    i++; //IMPORTANTE: esto actua de contador y va aqui porque si va en negativo los tendria 
                         //en cuenta para la media
                }
               
                Console.WriteLine("Dame un numero");
               
                num = Convert.ToInt32(Console.ReadLine());
                

            }
                Console.WriteLine("La media de los numeros anteriores es " + media);

            
            //Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 dependiendo de si 
            //el usuario introduce P o I . Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez.

            String respuesta = "";

            while (respuesta != "P" && respuesta != "I") //podriamos poner en mayuscula o miniscula,pero seria rebuscado
            {
                Console.WriteLine("Escribe P o I");
                respuesta = Console.ReadLine(); 
            }

            if (respuesta=="P") // si la respuesta fuera I seria el else y fuera
            {
                for (int i=2;i<101;i=i+2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i=1;i<101;i=i+2)
                {
                    Console.WriteLine(i);
                }
            }
            
            //Escribe un programa que pregunte 
            //al usuario su edad. Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.
                                   
            int años;
            Console.WriteLine("Cuantos años tienes?");
            años = Convert.ToInt32(Console.ReadLine());
            

            for (int i=1;i<=años;i++)
            {
                    
               Console.WriteLine("Feliz cumpleaños");

            }
            
            //Pedir al usuario un número.Mostrar en pantalla
            //*
            //**
            //***
            // Con tantas líneas como el número que ha introducido



            //Escribe un programa que muestre los números de 1 a 12 en una columna.
            //En la columna de al lado de los números impares mostrar el cuadrado de ese valor 
            //y en la de los pares mostrar el cubo


            for (int i = 1; i < 13; i++)
            {
                Console.Write(i);


                if (i % 2 == 0)
                {
                    Console.WriteLine("\t" + Math.Pow(i,3);//math .pow para potencias
                }
                else
                {
                    Console.WriteLine("\t" + Math.Pow(i,2));
                }

                Console.WriteLine();
            }
            

            //Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior y 5.

            int suma = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(suma);
                // suma = suma + 5; //el valor suma va cambiando con cada bucle                 
                suma += 5;
            }

            
            //Crear un programa que muestre el valor de sumar todos los números desde 1 
            //hasta el número que introduzca el usuario.Por ejemplo si introduce 
            //el 8 debería mostrar 36(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)

            int num;
            int suma=0;

            Console.WriteLine("Dime un numero");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i=num;num>0;)
            {
                suma = suma + num;
                num--;

            }
            Console.WriteLine("La suma seria " + suma);
            */
            




            Console.ReadLine() ;




        }







       


        
    }
}
