namespace BankEncapsulation;

public class BankAccount
{
    public BankAccount()
    {
        
    }
    //Fields
    private double _balance = 0;

    //Methods
    
    //Method to add amount to _balance
    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        _balance -= amount;
    }

    //Method to return the value of _balance
    public double GetBalance()
    {
        return _balance;
    }
}