using System;

namespace OOPExamples;

    abstract class Animal
    {
        public abstract void Speak();

        public virtual void Display() 
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

    
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    
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

        public new void Display() 
        {
            Console.WriteLine("Dog display.");
        }
    }

    
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
        private string? name; 

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
            
            Shape myShape;
            myShape = new Circle();
            myShape.Draw(); 

            myShape = new Square();
            myShape.Draw(); 

            // Demonstrating Animals
            Animal myDog = new Dog();
            myDog.Speak();
            ((IMovable)myDog).Move(); 
            myDog.Display(); 

            Animal myCat = new Cat();
            myCat.Speak(); 
            ((IMovable)myCat).Move(); 
            myCat.Display(); 

            
            Person person = new Person();
            person.Name = "Archi";
            person.Introduce(); 

            
            Calculator calc1 = new Calculator(10);
            Calculator calc2 = new Calculator(20);
            Calculator result = calc1 + calc2; 

            Console.WriteLine($"Result of adding two calculators: {result}"); 
            Console.WriteLine(calc1.Add(3, 4)); 
            Console.WriteLine(calc1.Add(2.5, 3.5)); 

            ScientificCalculator sciCalc = new ScientificCalculator(15);
            sciCalc.Display(); 

            
            Dog dog = new Dog();
            dog.Display(); 

            Animal animalDog = dog;
            animalDog.Display(); 

            Console.ReadLine();
        }
    }

