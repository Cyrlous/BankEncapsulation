using System.ComponentModel.Design;

namespace BankEncapsulation;

public class ATM
{
    public ATM()
    {
        
    }
    
    //Fields
    private BankAccount myAccount = new BankAccount();
    private bool _validInput = false;
    private int _answer = 0;
    private int _myBalance = 0;

    public void Menu()
    {
        do
        {
            Console.WriteLine("ATM MAIN MENU\n");
            Console.WriteLine("1. Add Funds");
            Console.WriteLine("2. Withdraw Funds");
            Console.WriteLine("3. My Balance");
            Console.WriteLine("4. Exit\n");
            Console.WriteLine("Please Enter You Selection:");

            do
            {
                if (int.TryParse(Console.ReadLine(), out _answer))
                {
                    _validInput = true;
                }
                else
                {
                    _validInput = false;
                }
            } while (_validInput == false);

            switch (_answer)
            {
                case 1:
                {
                    double depositAmount = 0;
                    do
                    {
                        Console.WriteLine("Please enter the amount of money you would like to deposit:");
                        if (double.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            myAccount.Deposit(_myBalance);
                            _validInput = true;
                        }
                        else
                        {
                            _validInput = false;
                        }
                    } while (_validInput == false);

                    return;
                }
                    
            }
        } while (_answer != 4);
    }
}