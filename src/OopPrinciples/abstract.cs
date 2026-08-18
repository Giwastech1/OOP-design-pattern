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