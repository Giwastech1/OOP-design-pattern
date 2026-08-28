using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Phone
{
    public string? ReleasedYear { get; set; }
    public int PhonePrice { get; set; }
    public string? Brand { get; set; }

    public virtual void Start()
    {
        Console.WriteLine("The phone is starting...");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The phone is stoping...");
    }
}
