using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "john", 15);
            Student student2 = new Student(40, "Tim", 10);

            Console.WriteLine(student1.isObese());
            Console.WriteLine(student2.isObese());
            Console.ReadLine();
        }
        internal class Student
        {
            public double weight;
            public string name;
            public int age;

            public Student(double aWeight,string aName,int aAge)
            {
                this.weight = aWeight;
                this.name = aName;
                this.age = aAge;

            }
            public bool isObese()
            {
                if (weight < 60)
                {
                    return true;
                }
                else return false;
            }
        }
    }
    
    
}
