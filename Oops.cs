using System;

namespace OOPExamples;

    // Abstract class
    abstract class Animal
    {
        public abstract void Speak();

        public virtual void Display() // Base Display method
        {
            Console.WriteLine("Animal display.");
        }
    }

    // Interface
    interface IMovable
    {
        void Move();
    }

    // Base class
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class from Shape
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Another derived class from Shape
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    // Derived class from Animal and implementing IMovable
    class Dog : Animal, IMovable
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }

        public void Move()
        {
            Console.WriteLine("The dog runs.");
        }

        public new void Display() // Method hiding
        {
            Console.WriteLine("Dog display.");
        }
    }

    // Another derived class from Animal and implementing IMovable
    class Cat : Animal, IMovable
    {
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }

        public void Move()
        {
            Console.WriteLine("The cat walks gracefully.");
        }
    }

    class Person
    {
        private string? name; // Marking name as nullable

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name ?? "unknown"}.");
        }
    }

    class Calculator
    {
        private double value;

        public Calculator(double value)
        {
            this.value = value;
        }

        // Method overloading
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        // Operator overloading
        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            return new Calculator(c1.value + c2.value);
        }

        public override string ToString()
        {
            return value.ToString();
        }

        // Method hiding
        public virtual void Display()
        {
            Console.WriteLine("Calculator display.");
        }
    }

    class ScientificCalculator : Calculator
    {
        public ScientificCalculator(double value) : base(value) { }

        public new void Display()
        {
            Console.WriteLine("Scientific calculator display.");
        }
    }

    class Oops
    {
        static void Main(string[] args)
        {
            // Demonstrating Shapes
            Shape myShape;
            myShape = new Circle();
            myShape.Draw(); // Outputs: Drawing a circle.

            myShape = new Square();
            myShape.Draw(); // Outputs: Drawing a square.

            // Demonstrating Animals
            Animal myDog = new Dog();
            myDog.Speak(); // Outputs: The dog barks.
            ((IMovable)myDog).Move(); // Outputs: The dog runs.
            myDog.Display(); // Outputs: Animal display. (because of polymorphism)

            Animal myCat = new Cat();
            myCat.Speak(); // Outputs: The cat meows.
            ((IMovable)myCat).Move(); // Outputs: The cat walks gracefully.
            myCat.Display(); // Outputs: Animal display.

            // Demonstrating Person class
            Person person = new Person();
            person.Name = "Archi";
            person.Introduce(); // Outputs: Hello, my name is Alice.

            // Demonstrating Calculator
            Calculator calc1 = new Calculator(10);
            Calculator calc2 = new Calculator(20);
            Calculator result = calc1 + calc2; // Using overloaded operator

            Console.WriteLine($"Result of adding two calculators: {result}"); // Outputs: 30
            Console.WriteLine(calc1.Add(3, 4)); // Outputs: 7
            Console.WriteLine(calc1.Add(2.5, 3.5)); // Outputs: 6

            ScientificCalculator sciCalc = new ScientificCalculator(15);
            sciCalc.Display(); // Outputs: Scientific calculator display.

            // Demonstrating hiding behavior
            Dog dog = new Dog();
            dog.Display(); // Outputs: Dog display.

            Animal animalDog = dog;
            animalDog.Display(); // Outputs: Animal display. (polymorphism)

            Console.ReadLine();
        }
    }

