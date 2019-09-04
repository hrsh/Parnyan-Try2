using System;
using System.Collections.Generic;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var name = Console.ReadLine();

            //var len = name.Length;
            //Console.WriteLine(len);

            //var a = double.Parse(Console.ReadLine());
            //var b = double.Parse(Console.ReadLine());
            //var c = a % b;
            //Console.WriteLine(c);

            // 8 / 3 = 2.3333333
            //var c = a / b;
            //var rounded = Math.Round(c, 2);

            //var truncate = Math.Truncate(c);

            //Console.WriteLine(rounded + "\n" + truncate);

            // int chosen;
            // bool test;
            // do
            // {
            //     Console.WriteLine("Enter your choice:\nSum(1)\nDivid(2)");
            //     test = int.TryParse(Console.ReadLine(), out chosen);
            // } while (!test || chosen > 2 || chosen < 1);
//d31bfc5
            // Console.WriteLine(chosen);

            var list = new List<string>();
            for(var i = 0; i < 10; i++)
            {
                var temp = DateTime.Now.GetHashCode().ToString();
                list.Add(temp);
            }

            foreach(var s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}
