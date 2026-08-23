//Inheritance principle of OOP
class Animal
{
    public void Eating()
    {
        Console.WriteLine("Animal is eating");
    }

}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("The cat is meowing");
    }
}

class Vehicle
{
    public string? Brand { get; set; }
    public int Amount { get; set; }

    public void Start()
    {
        Console.WriteLine("The vehicle is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("The vehicle is stopping...");
    }
}