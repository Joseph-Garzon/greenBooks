using System;
namespace Banking
{
    
    public class Bank
    {
        SavingsAccount savingsAccount;
        CheckingAccount checkingAccount;
        CD certificateOfDeposit;
        BrokerageAccount brokerage;
        MoneyMarketAccount moneyMarketAccount;

        double SavingsRate;
        double CheckingRate;
        double CDRate;
        double BrokerageRate;
        double MoneyMarketRate;


        public Bank(double principal, int chosenBank) {
            int a = 1;

           // string bank = (greenBooks.Banks)a;

            switch(chosenBank){

                case 1: int x = 1;

                    break;

            }



            /*savingsAccount = new SavingsAccount(principal, SavingsRate);

            if (interestChecking){
                checkingAccount = new CheckingAccount(principal, CheckingRate);
            }
            else { checkingAccount = new CheckingAccount(principal, 0); }

            certificateOfDeposit = new CD(principal, CDRate);

            brokerage = new BrokerageAccount(principal, BrokerageRate);

            moneyMarketAccount = new MoneyMarketAccount(principal, MoneyMarketRate);*/

        }
    }
}

           