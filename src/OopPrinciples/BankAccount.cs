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
        if(amount <= 0)
        {
            throw new ArgumentException("Amount must be greater than zero");
        }
        return this.balance = this.balance + amount;
    }

    public decimal Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount to withdraw should be greater than zero");
        }
        if(amount > this.balance)
        {
            // throw new InvalidOperationException("you can withdraw higher than your balnce");
            Console.WriteLine("No! you can't  withdraw higher than balance");
            return this.balance;
        }
        return this.balance = this.balance - amount;
    }

    public decimal Balance()
    {
        return this.balance;
    }
}