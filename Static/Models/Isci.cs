using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static.Models
{
    internal class Isci
    {
        string _name;
        string _surname;
        byte _age;
        static int  _salary;

        static Isci()
        {
            _salary = 3000;
        }
        public Isci(string name,string surname,byte age)
        {
          
            _name = name;
            _surname = surname;
            _age = age;

        }
        public void GetInfo()
        {
            Console.WriteLine( $"Name:{_name} \n Surename:{_surname}\nAge:{_age} \n maas:{_salary}");
            

        }
        public static void BonuseSalary(int bonus)
        {
            Console.WriteLine("maas artir");
            Console.WriteLine("artiqdan soraki maas"+(_salary+bonus));
        }

        

    }
}
