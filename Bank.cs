using System;
namespace Banking
{
    
    public class Bank
    {
        SavingsAccount savings;
        CheckingAccount checking;
        CD cD;
        MoneyMarketAccount moneyMarket;
        BrokerageAccount brokerage;
        

        public Bank(double savInt, double checkInt, double CDInt, double monMarkInt, double brokInt) {
            savings = new SavingsAccount(0, savInt);
            checking = new CheckingAccount(0, checkInt);
            cD = new CD(0, CDInt);
            moneyMarket = new MoneyMarketAccount(0, monMarkInt);
            brokerage = new BrokerageAccount(0, brokInt);
        }





    }
}

           
