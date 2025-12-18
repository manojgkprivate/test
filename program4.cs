using System;

// 1. Custom Exception
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class BankAccount
{
    public double Balance =50000;

    public void withdraw(double ammout)
    {
        if(ammout> Balance)
        {
            throw new InsufficientBalanceException("Insufficint balance");
        }
        Balance-=ammout;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc =new BankAccount();
         try{
            acc.withdraw(6000);
         }
         catch(InsufficientBalanceException ex)
         {
            Console.WriteLine(ex.Message);
         }
    }
}
