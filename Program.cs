using System;
using System.Collections;

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
    enum accountType
    {
        checking = 1,
        savings = 2,
        moneyMarket = 3,
        cD = 4,
        brokerage = 5
    }


    class Program
    {
        static void Main(string[] args)
        {
            accountType CurrentAccount;
            int Principle;

            // Welcome Page
            Console.WriteLine(@"Welcome to greenBooks Financial Calculator:
By entering some simple information we will give you a full analysis of your individual case
We will need which bank you want, wheat type of account you want, and your desired principle
But first lets get your name:
");
            // User Info
            Console.WriteLine("Enter your first name:");
            String first=Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            String last=Console.ReadLine();
            // Select Account
            Console.WriteLine("Please select one of the following options. \n1 = Checking Account \n2 = Savings Account \n3 = Money Marketing Account \n4 = CD \nbrokerage = 5 ");
            CurrentAccount = (accountType)Convert.ToInt32(Console.ReadLine());
            // User Input Principal
            Console.WriteLine("Please enter your principle.");
            Principle = Convert.ToInt32(Console.ReadLine());
            // Create Account
            User user = new User(first,last,(int)CurrentAccount,Principle);
            //Show results
            Console.WriteLine("\n\nBased on the information you gave us these are your three best options:");
            Console.WriteLine(user.bBanks[1].Name+":");
            Console.Write(user.bBanks[1].getAccountByType((int)CurrentAccount).ReturnInvestment(/*enter perameters if needed*/));
            Console.WriteLine("\n"+user.bBanks[2].Name + ":");
            Console.Write(user.bBanks[2].getAccountByType((int)CurrentAccount).ReturnInvestment(/*enter perameters if needed*/));
            Console.WriteLine("\n"+user.bBanks[3].Name + ":");
            Console.Write(user.bBanks[3].getAccountByType((int)CurrentAccount).ReturnInvestment(/*enter perameters if needed*/));
        }
    }
}
