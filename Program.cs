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
            string a = @"Welcome to GreenBooks, helping you live financially secure and care free.

To begin please input the following information about yourself.";

            Console.WriteLine(a);
            Console.WriteLine("\nWhat is your first name?");
            var firstName = Console.ReadLine();
            Console.WriteLine("\nWhat is your last name?");
            var lastName = Console.ReadLine();
            Console.WriteLine("\nWhat is your email address?");
            var email = Console.ReadLine();

            User user = new User(firstName, lastName, email);

            a = @"Please select one of the following options by entering the number.
1=Banking
2=Budgeting
3=Investments";
            Console.WriteLine("\n"+a);
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                a= @"Please select one of the following banks by entering the number.

1=Bank of America
2=Chase
3=Wells Fargo
4=Rose Bank
5=Prosperity Bank
6=Allegiance	
7=Capital
8=Ally Bank
9=One Main Financial
10=Citi Bank
11=AIG
12=Goldman Sachs
";
                Console.WriteLine("\n"+a);
                Console.WriteLine((Banks) Convert.ToInt32(Console.ReadLine()));

                a = @"Please select the type of account you would like to make.

1=Savigns Account
2=Chechking Account
3=Money Market Account
4=Certificate of Deposit
";
                Console.WriteLine("\n"+a);
                Console.WriteLine((AccountType)Convert.ToInt32(Console.ReadLine()));


               
                Banking.Bank userBank = new Banking.Bank(0,0);
                
            }
            else if(choice == 2)
            {

            }
            else{

            }


            
        }
    }
}

