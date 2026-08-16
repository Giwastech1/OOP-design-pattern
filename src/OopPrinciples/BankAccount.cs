//creating bank account class with encapsulation principle.
class BankAccount
{
    private decimal balance;

    public decimal Deposit(decimal amount)
    {
       return balance += amount;
    }
}