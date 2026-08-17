//creating bad bad account balnce.
using System.Reflection.Metadata;

BadBankAccount badAccount = new BadBankAccount();
badAccount.balance = 5968;
Console.WriteLine(badAccount.balance);
Console.WriteLine();

//creating an account with encapsulation principle.
/*
BankAccount account = new();
decimal balance =account.Deposit(3400);
Console.WriteLine(balance);

BankAccount account2 = new();
Console.WriteLine(account2.Deposit(100));
*/

BankAccount user = new BankAccount();
user.Deposit(400);
Console.WriteLine(user.Balance());
user.Deposit(350.25m);
Console.WriteLine(user.Balance());
user.Withdraw(2000);
Console.WriteLine(user.Balance());