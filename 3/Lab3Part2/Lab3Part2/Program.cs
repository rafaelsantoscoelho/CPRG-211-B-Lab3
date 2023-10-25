namespace Lab3Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Task #2\n");

            Console.WriteLine("Enter the dog's name:");
            string dogName = Console.ReadLine();

            Console.WriteLine("Enter the dog's color:");
            string dogColor = Console.ReadLine();

            Console.WriteLine("Enter the dog's age:");
            int dogAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the dog's height:");
            double dogHeight = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Dog dog = new Dog(dogName, dogColor, dogHeight, dogAge);
            Console.WriteLine(string.Format("Name of the dog: {0}\nColor of the dog: {1}\nAge of the dog: {2}\nHeight of the dog: {3}", dog.Name, dog.Color, dog.Age, dog.Height));
            dog.Eat();
            dog.Cry();

            Console.WriteLine();

            Console.WriteLine("Enter the cat's name:");
            string catName = Console.ReadLine();

            Console.WriteLine("Enter the cat's color:");
            string catColor = Console.ReadLine();

            Console.WriteLine("Enter the cat's age:");
            int catAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cat's height:");
            double catHeight = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Cat cat = new Cat(catName, catColor, catHeight, catAge);
            Console.WriteLine(string.Format("Name of the cat: {0}\nColor of the cat: {1}\nAge of the cat: {2}\nHeight of the cat: {3}", cat.Name, cat.Color, cat.Age, cat.Height));
            cat.Eat();
            cat.Cry();

            Console.WriteLine();

            Console.WriteLine("Creating a list of animals...");
            List<IAnimal> list = new List<IAnimal>();
            
            list.Add(new Dog("Scooby", "Brown", 1.5, 18));
            list.Add(new Cat("Hazel", "White", 1.2, 7));
            list.Add(new Dog("Bilu", "Blue", 1.3, 2));
            list.Add(new Cat("Fernanda", "Black", 1.8, 5));

            Console.WriteLine("Printing names of animals in the list...");
            Console.WriteLine();

            int index = 1;

            foreach (IAnimal animal in list)
            {
                if (animal is Dog)
                {
                    Dog animalDog = animal as Dog;
                    Console.WriteLine(string.Format("Animal at position #{0} in the list is a dog and it is called {1}", index, animalDog.Name));
                }

                else
                {
                    Cat animalCat = animal as Cat;
                    Console.WriteLine(string.Format("Animal at position #{0} in the list is a cat and it is called {1}", index, animalCat.Name));
                }

                index++;
            }

            Console.WriteLine("----------------------");
        }
    }
}