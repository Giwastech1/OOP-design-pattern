//creating bad bad account balnce.
/*
BadBankAccount badAccount = new BadBankAccount();
badAccount.balance = 5968;
Console.WriteLine(badAccount.balance);
Console.WriteLine();
*/
//creating an account with encapsulation principle.
/*
BankAccount account = new();
decimal balance =account.Deposit(3400);
Console.WriteLine(balance);

BankAccount account2 = new();
Console.WriteLine(account2.Deposit(100));
*/
/*
BankAccount user = new BankAccount();
user.Deposit(400);
Console.WriteLine(user.Balance());
user.Deposit(350.25m);
Console.WriteLine(user.Balance());
user.Withdraw(2000);
Console.WriteLine(user.Balance());
Console.WriteLine();

Dog dog = new Dog();
dog.Eating();
dog.Bark();
Console.WriteLine();

Cat cat = new Cat();
cat.Eating();
cat.Meow();

StudentA detail_1 = new StudentA();
detail_1.Name();
Console.WriteLine();

StudentB detail_2 = new StudentB();
detail_2.Name();
*/

/*
Bike bike = new Bike();
bike.Brand = "Bajaj";
bike.Amount = 1000000;
bike.NumberOfTire = 2;
bike.Start();
bike.Stop();
Console.WriteLine(bike.NumberOfTire);

Car car = new Car();
car.Brand = "Toyota";
car.NumOfDoor = 4;
car.Start();
car.Stop();
Console.WriteLine(car.Brand);

Mother mother = new Mother();
mother.MyRole();
*/

using System.ComponentModel;

List<object> phones = new List<object>();
phones.Add(new Phone { Brand = "Samsung", ReleasedYear = "2022", PhonePrice = 4200 });
phones.Add(new Phone { Brand = "Tekno", ReleasedYear = "2017", PhonePrice = 2000 });

foreach(var phone in phones)
{
    if(phone is Phone)
    {
        var phoneItem = (Phone)phone;
        phoneItem.Start();
        Console.WriteLine(phoneItem.Brand);
        Console.WriteLine(phoneItem.ReleasedYear);
    }
}