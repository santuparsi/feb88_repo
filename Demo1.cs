using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Demo1
    {
        public int Sum(int []a) //return sum of array no's
        {
            int sum = 0;
            foreach (int k in a)
                sum = sum + k;
            return sum;
        }
        public string [] GetNames(string []s) //retun names stat with S
        {
            string[] list = new string[s.Length];
            int indx = 0;
            foreach(string k in s)
            {
                if(k.StartsWith("S"))
                {
                    list[indx] = k;
                    indx++;
                }
            }
            return list;
        }
    }
    class Test_Demo1
    {
        static void Main()
        {
            Demo1 obj = new Demo1();
            int[] n = { 12, 2, 3, 4, 5, 6, 7, 66, 56 };
            int result = obj.Sum(n);
            Console.WriteLine("Sum of Array no's " + result);
            result = obj.Sum(new int[] { 23, 45, 56, 67, 78, 89 });
            Console.WriteLine("Sum: " + result);
            string[] names = obj.GetNames(new string[] { "Suren", "Suraj", "Sushanth", "Karan", "Charan" });
            foreach (string k in names)
                Console.WriteLine(k);
        }
    }
}
