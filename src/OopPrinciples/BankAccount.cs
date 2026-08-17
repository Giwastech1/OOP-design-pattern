//creating bank account class with encapsulation principle.
class BankAccount
{
    private decimal balance;

    /*
    public decimal Deposit(decimal amount)
    {
       return balance += amount;
    }
    */

    public decimal Deposit(decimal amount)
    {
        return this.balance = this.balance + amount;
    }

    public decimal Withdraw(decimal amount)
    {
        return this.balance = this.balance - amount;
    }

    public decimal Balance()
    {
        return this.balance;
    }
}