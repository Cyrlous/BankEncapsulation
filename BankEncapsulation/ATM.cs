using System.ComponentModel.Design;

namespace BankEncapsulation;

public class ATM
{
    public ATM()
    {
        
    }
    
    //Fields
    private BankAccount _myAccount = new BankAccount();
    private bool _validInput = false;
    private int _answer = 0;
    private double _myBalance = 0;

    public void Menu()
    {
        //Main loop.  Will continue to allow user to make selections
        //until 4 is selected at which point the program will exit
        do
        {
            Console.WriteLine("ATM MAIN MENU\n");
            Console.WriteLine("1. Add Funds");
            Console.WriteLine("2. Withdraw Funds");
            Console.WriteLine("3. My Balance");
            Console.WriteLine("4. Exit\n");
            Console.WriteLine("Please Enter You Selection:");
            
            //Filter user input to ensure it is an integer
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
            
            //Switch case to execute the various menu options
            switch (_answer)
            {
                //Case 1 will allow the user to enter the amount of a deposit
                case 1:
                {
                    double depositAmount = 0;
                    do
                    {
                        Console.WriteLine($"Your current balance is {_myAccount.GetBalance():C}.\n");
                        Console.WriteLine("Please enter the amount of money you would like to deposit:\n");
                        if (double.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            _myAccount.Deposit(depositAmount);
                            Console.WriteLine($"\nYour new balance is {_myAccount.GetBalance():C}.\n");
                            Console.WriteLine("Please press enter to continue.");
                            Console.ReadLine();
                            _validInput = true;
                        }
                        else
                        {
                            _validInput = false;
                        }
                    } while (_validInput == false);

                    break;
                }
                //Case 2 will allow the user to withdraw an amount up to the current balance
                case 2:
                {
                    double withdrawalAmount = 0;
                    do
                    {
                        Console.WriteLine($"Your current balance is {_myAccount.GetBalance():C}.\n");
                        Console.WriteLine("Please enter the amount of money you would like to withdraw:");
                        if (double.TryParse(Console.ReadLine(), out withdrawalAmount))
                        {
                            if (withdrawalAmount <= _myAccount.GetBalance())
                            {
                                _myAccount.Withdraw(withdrawalAmount);
                                Console.WriteLine($"\nYour new balance is {_myAccount.GetBalance():C}.\n");
                                Console.WriteLine("Please press enter to continue.");
                                Console.ReadLine();
                                _validInput = true;
                            }
                            else
                            {
                                Console.WriteLine("You do not have enough money to make this withdrawal.");
                                _validInput = false;
                            }
                        }
                        else
                        {
                            _validInput = false;
                        }
                    } while (_validInput == false);

                    break;
                }
                //Case 3 will display the current account balance
                case 3:
                {
                    Console.WriteLine($"Your current balance is {_myAccount.GetBalance():C}.\n");
                    Console.WriteLine("Please press enter to continue.");
                    Console.ReadLine();
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Thank you for using this ATM.  Please have a nice day.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Please enter a valid selection.");
                    break;
                }
            }
        } while (_answer != 4);
    }
}