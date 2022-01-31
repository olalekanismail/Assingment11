using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAndUsingObjects
{
   public class Cat
    {

        public string Name { get; set; }
        public string Colour { get; set; }
        public Cat(string name, string colour)
        {
            Name = name;
            Colour = colour;
        }

        public  string SayMiau(string Name)
        {
            return Name;
        }

    }

    public class Sequence
    {
        public void sequence()
        {

        }
        public void NextValue()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
               
                
        }

    }
}
