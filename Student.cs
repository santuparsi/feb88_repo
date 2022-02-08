using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Student
    {
        //Datamembers(Variables)
        public  int sId;
        public string sName;
        public int age;
        public string std;
        string address; //private is the default access
        public void Details()
        {
           // int c;
            //Show the details of Student
            Console.WriteLine("ID: " + sId);
            Console.WriteLine("Name: " + sName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Std: " + std);
        }
    }
   class Info
    {
        private Student[] list = new Student[10];
        int count = 0;
        public void Register(Student s)
        {
            list[count] = s;
            count++;
        }
        public Student GetStudentById(int id)
        {
            foreach(Student s in list)
            {
                if(s!=null)
                {
                    if(s.sId==id)
                    {
                        return s;
                        
                    }
                }
            }
            return null;
        }
        public Student[] GetStudents()
        {
            return list;
        }
    }

    class Test_Student
    {
       static void Main()
        {
            Student s1 = new Student();
            s1.sId = 100;
            s1.sName = "Rohan";
            s1.age = 10;
            s1.std = "III";
            s1.Details();
            Student s2 = new Student();
            Console.WriteLine("Enter ID");
            s2.sId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            s2.sName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            s2.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Class");
            s2.std = Console.ReadLine();
            s2.Details();
            Student s3 = new Student();
            s3.Details();
            Student s4 = new Student() { sId = 104, sName = "Charan", age = 10, std = "III" }; //Object Initializer
            s4.Details();
            ////Array of Students
            Student[] list = new Student[6];
            list[0] = s1;
            list[1] = s2;
            list[2] = s3;
            list[3] = s4;
          list[4] = new Student() { sId = 105, sName = "Karan", age = 12, std = "IV" };
            foreach (Student s in list)
            {
                if (s != null)
                {
                    s.Details();
                    Console.WriteLine("---------------");
                }
            }
            //Info db = new Info();
            //db.Register(s1);
            //db.Register(s4);
            //db.Register(new Student() { sId = 2, sName = "Karan", age = 10, Class = "III" });
            //Student s = db.GetStudentById(2);
            //if (s != null)
            //{
            //    Console.WriteLine("Name: " + s.sName);
            //}
            //else
            //    Console.WriteLine("Invalid Id");
            //Student []list= db.GetStudents();
            //foreach (Student k in db.GetStudents())
            //{
            //    if(k!=null)
            //    Console.WriteLine("{0} {1} {2} {3} ", k.sId, k.sName, k.age, k.Class);
            //}
            Console.ReadKey();

            
        }
    }

}
