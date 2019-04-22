using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\Alejandro Perez G\Documents\lectura.txt");
            System.Console.WriteLine(text);

            string[] numbers = text.Split();


            foreach (string number in numbers)
            {


                Console.WriteLine(number);
                //hola mundo

            }

            //var temp = new List<string>();
            //foreach (var s in numbers)
            //{
            //    if (!string.IsNullOrEmpty(s))
            //        temp.Add(s);
            //}
            //numbers = temp.ToArray();

            //Console.WriteLine(numbers);


            //int[] myInts = Array.ConvertAll(numbers, int.Parse);






        }
    }
}
