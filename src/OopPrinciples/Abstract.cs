//Abstraction principle of OOP
abstract class StudentDetail
{
    abstract public void Name();
}

class StudentA:StudentDetail
{
    public override void Name()
    {
        Console.WriteLine("Giwa");
        Console.WriteLine("I am 20 years old");
    }
}

class StudentB : StudentDetail
{
    public override void Name()
    {
        Console.WriteLine("Amina");
        Console.WriteLine("I am 15 years old");
    }
}