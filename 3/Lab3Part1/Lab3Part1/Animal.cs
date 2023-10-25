using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part1
{
    internal abstract class Animal
    {
        // Fields
        private string _name;
        private string _color;
        private int _age;

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        // Abstract method Eat
        public abstract void Eat();
    }
}
