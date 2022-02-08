using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ClassesAndObjects
{
    class Sample
    {
        public void Greet()
        {
            Console.WriteLine("Welcome to C# Programming..");
        }
        public void Add(int a,int b)
        {
            int c;//local variable
            c = a + b;
            Console.WriteLine("Addition: " + c);
        }
        public string Message(string name="Rahul")
        {
            //string result;
            //result = "Hello " + name;
            //return result;
            return "Hello " + name;
        }
        public int Sqaure(int i)
        {
            return i * i;
        }
        public bool isEven(int no)
        {
            if (no % 2 == 0)
                return true;
            else
                return false;
        }
        public void Sum(int a,int b=10)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public void Mul(int a,double b)
        {
            double result = a * b;
            Console.WriteLine("Multiplication: " + result);
        }
    }
    class Test_Sample
    {
        public static void Main()
        {
            Sample s1 = new Sample();
            s1.Greet();
            s1.Add(6, 8);
            s1.Add(6, 4);
            s1.Add(a:9, b:1); //passing values using name of the parameter
            string result=s1.Message(name:"Sachin");
            Console.WriteLine(result);
            Console.WriteLine(s1.isEven(141) ? "Even" : "Odd");
            s1.Sum(12);
            s1.Sum(12, 34);
            s1.Message();
            s1.Mul(12, 34.5);
            s1.Mul(b: 23.4, a: 34); //named parameter values
        }
    }
}
