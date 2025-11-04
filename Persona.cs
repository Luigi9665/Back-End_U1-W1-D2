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

        public void GetName ()
        {
            Console.WriteLine($"Il nome della persona è {name}");
        }

        public void GetSurname ()
        {
            Console.WriteLine($"Il cognome della persona è {surname}");
        }

        public void GetAge ()
        {
            Console.WriteLine($"L'età della persona è {age}");
        }


        public void getDetails()
        {
            Console.WriteLine($"Il nome {name} il cognome {surname} e l'età {age}");
        }



    }
}
