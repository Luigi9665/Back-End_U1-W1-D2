using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lezione2
{
    public class Persona
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        public Persona ( string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string GetName ()
        {
            return Name;
        }

        public string GetSurname ()
        {
            return Surname;
        }

        public int GetAge ()
        {
            return Age;
        }


        public void getDetails()
        {
            Console.WriteLine($"Il nome {Name} il cognome {Surname} e l'età {Age}");
        }



    }
}
