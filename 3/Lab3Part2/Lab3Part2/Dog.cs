using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    internal class Dog : IAnimal
    {
        // Fields
        private string _name;
        private string _color;
        private double _height;
        private int _age;

        // Properties
        public string Name { get { return _name; } set { _name = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public double Height { get { return _height; } set { _height = value; } }
        public int Age { get { return _age; } set { _age = value; } }

        // Constructor
        public Dog(string name, string color, double height, int age)
        {
            Name = name;
            Color = color;
            Height = height;
            Age = age;
        }

        // Methods
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat!");
        }

        public string Cry()
        {
            Console.WriteLine("Woof!");
            return "Woof!";
        }
    }
}
