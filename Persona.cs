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

        public string name { get; set; }
        public string surname { get; set; }

        public int age { get; set; }

        public Persona ( string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string GetName ()
        {
            return this.name;
        }

        public string GetSurname ()
        {
            return this.surname;
        }

        public int GetAge ()
        {
            return this.age;
        }


        public void getDetails()
        {
            Console.WriteLine($"Il nome {name} il cognome {surname} e l'età {age}");
        }



    }
}
