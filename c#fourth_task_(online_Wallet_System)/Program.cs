using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace c_fourth_task__online_Wallet_System_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome our Online Wallet System");
            Menu();
            Console.Write("Please choose an option: ");
            Option();
        }
        static void Menu()
        {
            Console.WriteLine("1.Create Account:");
            Console.WriteLine("2.Add Money into Account:");
            Console.WriteLine("3.Get Money from Account:");
            Console.WriteLine("4.Show Balance:");
            Console.WriteLine("5.Show Props:");
            Console.WriteLine("6.Exit:");

        }

        public static void Option()
        {
            int option = 0;
            char isContinue = 'n';
            bool isSystemContinue = true;
            Account account = null;
            do
            {
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {

                    account = new Account();
                    Console.WriteLine("Please write account name:");
                    string accountName = Console.ReadLine();
                    account.Name = accountName;
                    Console.WriteLine("Please write account surname:");
                    string accountSurName = Console.ReadLine();
                    account.SurName = accountSurName;
                    Console.WriteLine("Please write account number:");
                    string accountNumber = Console.ReadLine();
                    account.AccountNumber = accountNumber;
                    List<Account> accounts = new List<Account>();
                    accounts.Add(account);
                    foreach (var item in accounts)
                    {
                        Console.WriteLine($"Account name: {item.Name}");
                        Console.WriteLine($"Account surname: {item.SurName}");
                        Console.WriteLine($"Account number: {item.AccountNumber}");
                    }
                    Console.WriteLine("Do you want to continue: (y/n)");
                    isContinue = char.Parse(Console.ReadLine());
                    if (isContinue == 'n')
                    {
                        break;
                    }
                    isSystemContinue = false;


                }
                else if (option == 2)
                {
                    if (account != null)
                    {
                        account.AddMoney();
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Do you want to continue: (y/n)");
                    isContinue = char.Parse(Console.ReadLine());
                    if (isContinue == 'n')
                    {
                        break;
                    }
                    isSystemContinue = false;
                }
                else if (option == 3)
                {
                    if (account != null)
                    {
                        account.GetMoney();
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Do you want to continue: (y/n)");
                    isContinue = char.Parse(Console.ReadLine());
                    if (isContinue == 'n')
                    {
                        break;
                    }
                    isSystemContinue = false;
                }
                else if (option == 4)
                {
                    if (account != null)
                    {
                        account.ShowBalance();
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Do you want to continue: (y/n)");
                    isContinue = char.Parse(Console.ReadLine());
                    if (isContinue == 'n')
                    {
                        break;
                    }
                    isSystemContinue = false;

                }
                else if (option == 5)
                {
                    if (account != null)
                    {
                        account.GetTransaction();
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Do you want to continue: (y/n)");
                    isContinue = char.Parse(Console.ReadLine());
                    if (isContinue == 'n')
                    {
                        break;
                    }
                    isSystemContinue = false;
                }
                else if (option == 6)
                {

                    isSystemContinue = false;
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Please choose an correct option");
                }


            } while (isContinue == 'y' || isSystemContinue == true); ;



        }
    }


}
