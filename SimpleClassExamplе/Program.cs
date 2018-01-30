using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            //Разместить в памяти и сконфигурировать объет Car.
            Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("Mary");
            mary.PrintState();

            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            for (int i=0; i <=10;i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            

            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName);

            Console.WriteLine("People list");
            MyClass ppl1 = new MyClass();
            MyClass ppl2 = new MyClass("Ivan", 20);
            MyClass ppl3 = new MyClass(14);
            MyClass ppl4 = new MyClass("N");
            ppl1.PrintInfo();
            ppl2.PrintInfo();
            ppl3.PrintInfo();
            ppl4.PrintInfo();

            Console.ReadLine();

        }
    }
}
