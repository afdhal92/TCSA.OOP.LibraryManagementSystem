using Spectre.Console;
using TCSA.OOP.LibraryManagementSystem;

//var menuChoices = new string[3] { "View Books", "Add Book", "Delete Book" };


//Car car1 = new Car();
//Car car2 = new Car();

//car1.name = "Ferrari";
//car2.name = "BMW";

//car1.PrintName();
//car2.PrintName();

//class Car()
//{
//    internal string name;

//    internal void PrintName()
//    {
//        name = name.ToUpper();
//        Console.WriteLine($"I'm a {name}");
//    }
//}

//UserInterface.MainMenu();
//UserInterface userInterface = new UserInterface();
//userInterface.MainMenu();

//(string, int) book1 = ("Frankenstein", 350);
//Console.WriteLine($"Title: {book1.Item1}, Pages: {book1.Item2}");

//(string Title, int Pages) book2 = ("Frankenstein", 350);
//Console.WriteLine($"Title: {book2.Title}, Pages: {book2.Pages}");


//var book1 = new Book("Hamlet", 200);
//var book2 = new Book("Great Gatsby", 300);

//var book1 = new Book(); //compiler error

Animal myDog = new Dog("Buddy", 3);
Animal myCat = new Cat("Whiskers", 2);

myDog.MakeSound(); // Output: Buddy says: Woof!
myCat.MakeSound(); // Output: Whiskers says: Meow!

internal abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method that must be implemented by derived classes
    public abstract void MakeSound();
}

internal class Dog : Animal
{
    public Dog(string name, int age)
        : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

internal class Cat : Animal
{
    public Cat(string name, int age)
        : base(name, age) // Calling the base class constructor
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

