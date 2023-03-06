using System;

namespace ConsoleApplicationNR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ESTE ES UN COMENTARIO1
             */
            /// ESTE ES UN COMENTARIO 2
            /// **SUMA DE NUMEROS**
            Console.WriteLine("INGRESE EL VALOR 1");
            string value1 = Console.ReadLine();
            int value1Number = Int32.Parse(value1);

            Console.WriteLine("INGRESE EL VALOR 2");
            string value2 = Console.ReadLine();
            int value2Number = Int32.Parse(value2);


            Console.WriteLine(value1Number + value2Number);



            //RESTA DE NÚMEROS//
            Console.WriteLine("INGRESE EL VALOR 1");
            string value3 = Console.ReadLine();
            int value3Number = Int32.Parse(value3);

            Console.WriteLine("INGRESE EL VALOR 2");
            string value4 = Console.ReadLine();
            int value4Number = Int32.Parse(value4);


            Console.WriteLine(value3Number - value4Number);

            //MULTIPLICACIÓN NÚMEROS//

            Console.WriteLine("INGRESE EL VALOR 1");
            string value5 = Console.ReadLine();
            int value5Number = Int32.Parse(value5);

            Console.WriteLine("INGRESE EL VALOR 2");
            string value6 = Console.ReadLine();
            int value6Number = Int32.Parse(value6);


            Console.WriteLine(value5Number * value6Number);

            //DIVISION NÚMEROS//

            Console.WriteLine("INGRESE EL VALOR 1");
            string value7 = Console.ReadLine();
            int value7Number = Int32.Parse(value7);

            Console.WriteLine("INGRESE EL VALOR 2");
            string value8 = Console.ReadLine();
            int value8Number = Int32.Parse(value8);


            Console.WriteLine(value7Number / value8Number);



        }
    }
}
