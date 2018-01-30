using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class MyClass
    {
        public string name;
        public int age;

        public MyClass() {}
        public MyClass(string name)
        : this(name, 0) { }

        public MyClass(int age)
            : this("No_name", age) { }


        public MyClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0} is {1} years old", name, age);
        }
    }
}
