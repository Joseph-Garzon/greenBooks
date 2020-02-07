using System;
namespace Banking
{

    public class Bank
    {
        public String Name { get; set;}
        SavingsAccount savings;
        CheckingAccount checking;
        CD cD;
        MoneyMarketAccount moneyMarket;
        BrokerageAccount brokerage;


        public Bank(String Name, double savInt, double checkInt, double CDInt, double monMarkInt, double brokInt, int principle)
        {
            this.Name = Name;
            savings = new SavingsAccount(principle, savInt);
            checking = new CheckingAccount(principle, checkInt);
            cD = new CD(principle, CDInt);
            moneyMarket = new MoneyMarketAccount(principle, monMarkInt);
            brokerage = new BrokerageAccount(principle, brokInt);
        }

        public Accounts getAccountByType(int sel)
        {
            if (sel==1)
            {
                return savings;
            }
            else if (sel == 2)
            {
                return checking;
            }
            else if (sel == 4)
            {
                return cD;
            }
            else if (sel == 3)
            {
                return moneyMarket;
            }
            else if (sel == 5)
            {
                return brokerage;
            }
            else
            {
                Console.Write("!");
                return checking;
            }

        }

    }
}
