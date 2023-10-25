using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part1
{
    internal class Dog : Animal
    {
        public Dog(string name, string color, int age)
        {
            base.Name = name;
            base.Color = color;
            base.Age = age;
        }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat!");
        }
        public override string ToString()
        {
            return string.Format("Name of the dog: {0}\nColor of the dog: {1}\nAge of the dog: {2}", base.Name, base.Color, base.Age);
        }
    }
}
