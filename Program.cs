using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ForeachnWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            
            string[] arr1 = new string[] { "Naveen", "Mohith", "Manoj", "Rohith"};
            //ForEach Loop
            foreach( string a in arr1)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Above data is displayed using foreach loop");
            Console.WriteLine("\n");
            //WhileLoop
            int i=0;
            while(i < arr1.Length)
            {
                Console.WriteLine(arr1[i]);
                i++;
            }
            Console.WriteLine("Above data is displayed using while loop");
            Console.WriteLine("\n");
            //ArrayList
            int h = 15;
            ArrayList list = new ArrayList();
            list.Add("Naveen");
            list.Add("Mohith");
            list.Add("Manoj");
            list.Add("Rohith");
            list.Add(23);
            list.Add(h); //Boxing occurs automatically
            int b = (int)list[5]; //Unboxing occurs explicitly
            Console.WriteLine("The capacity of ArrayList is {0}", list.Capacity);
            Console.WriteLine("The count of items in ArrayList is {0}", list.Count);
            Console.WriteLine("Performing Foreach loop on ArrayList");
            foreach(var items in list)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("\n");
            //HashTable
            Hashtable ht = new Hashtable();
            ht.Add(1, "Naveen");
            ht.Add(2, "12");
            ht.Add(3, "Rohith");
            ht.Add(4, "15");
            Console.WriteLine("The Following is the output from HashTable");
            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
            Console.ReadLine();
        }
    }
}
