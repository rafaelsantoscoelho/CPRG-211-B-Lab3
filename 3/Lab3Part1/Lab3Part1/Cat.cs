using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part1
{
    internal class Cat : Animal
    {
        public Cat(string name, string color, int age)
        {
            base.Name = name;
            base.Color = color;
            base.Age = age;
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice!");
        }
        public override string ToString()
        {
            return string.Format("Name of the cat: {0}\nColor of the cat: {1}\nAge of the cat: {2}", base.Name, base.Color, base.Age);
        }
    }
}
