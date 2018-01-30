using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Motorcycle
    {
        public int driverIntensity;

        public string driverName;
        public void SetDriverName(string name)
        { this.driverName = name; }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            { Console.WriteLine("Yeeeee Haaaaeeww!"); }
        }
        //Единственный конструктор, использующий необязательные аргументы
        public Motorcycle(int intensivity=0,string name = "") {
            if(intensivity>10)
            { intensivity = 10; }

            driverIntensity = intensivity;
            driverName = name;

        }
       

    }
}
