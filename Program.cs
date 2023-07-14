using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5assg7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            fruits.Add("Date");
            fruits.Add("ElderBerry");
            Console.WriteLine("Total number of elements in array list  :  " + fruits.Count);

            foreach (var i in fruits)
            {
                Console.WriteLine(i);
            }
            var res = fruits.Contains("Date");
            Console.WriteLine("***************************************");
            Console.WriteLine("Check if array list contain the elemnt Date in it " + res);
            Console.WriteLine("**************************************");
            fruits.Insert(1, "Fig");
            Console.WriteLine("After inserting Fig into array list ");
            foreach (var i in fruits)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**************************************");
            fruits.Remove("Banana");
            Console.WriteLine("Array list after removing Banana from list ");
            foreach (var i in fruits)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**************************************");


            Console.ReadKey();
        }
    }
}