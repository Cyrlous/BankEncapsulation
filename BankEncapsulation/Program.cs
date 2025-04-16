namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            double addFunds = 0;
            double myBalance = 0;
            
            Console.WriteLine("Enter the amount of money you would like to deposit:");

            while (!double.TryParse(Console.ReadLine(), out addFunds))
            {
                Console.WriteLine("Please enter a valid number");
            }
            
            myAccount.Deposit(addFunds);
            myBalance = myAccount.GetBalance();
            
            Console.WriteLine($"Balance: {myBalance}");
        }
    }
}
