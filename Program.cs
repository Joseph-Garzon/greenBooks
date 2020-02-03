using System;

namespace greenBooks
{
    enum Banks
    {
        BankOfAmerica = 1,
        Chase = 2,
        WellsFargo = 3,
        RoseBank = 4,
        ProsperityBank = 5,
        Allegiance = 6,
        Capital = 7,
        AllyBank = 8,
        OneMainFinancial = 9,
        CitiBank = 10,
        AIG = 11,
        GoldmanSachs = 12
    };
    enum AccountType
    {
        SavingsAccount = 1,
        CheckingAccount = 2,
        MoneyMarketAccount = 3,
        CD = 4,
    };

    class Program
    {
    
        static void Main(string[] args)
        {
            // Welcome Page
            Console.WriteLine("Welcome");

            // User Info

            //Select Option
            Boolean done = true;
            do
            {
                Console.WriteLine("Please select on of the following options. \n1 = Banking \n2 = Budgeting");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1) // Banking
                {
                 done = true;

                    Console.WriteLine("Please select on of the following options. \n1 = Bank of America \n2 = \n3 =  \n4 = \n5 =  \n6 = \n7 =  \n8 = \n9 =  \n10 = \n11 =  \n12 = ");// Select Bank
                    // Select Account
                    // User Input Principal
                    // Create Account

                }
                else if (choice == 2) //Budgeting
                {
                    done = true;
                    
                }
                else
                {
                    Console.WriteLine("The option you selceted is not valid.");
                    done = false;

                }
            } while (!done);




        }
    }
}

