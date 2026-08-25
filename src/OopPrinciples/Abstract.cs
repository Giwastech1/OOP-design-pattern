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

//polymorphism
class Role
{
    public virtual void MyRole()
    {
        Console.WriteLine("I am a human");
    }
}

class Father : Role
{
    public override void MyRole()
    {
        Console.WriteLine("I am the father");
    }
}

class Mother : Role
{
    public override void MyRole()
    {
        Console.WriteLine("I am the mother");
    }
}

class Child : Role
{
    public override void MyRole()
    {
        Console.WriteLine("I am the child");
    }
}