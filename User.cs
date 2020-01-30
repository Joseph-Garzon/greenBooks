using System;
using System.Collections.Generic;
using System.Text;

namespace greenBooks
{
    public class User
    {
        public enum bankName
        {
            Chase = 1,
            BankOfAmerica = 2,
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
        }

        public enum accountType
        {
            basicChackingAccount=1,
            savingsAccounts=2,
            interestBearingCheckingAccount=3,
            moneyMarketAccount=4,
            CD=5,
            IRA=6,
            brokerageAccount=7
        }

        String fName { get; set;}
        String lName { get; set;}
        bankName bn { get; set; }
        accountType acc { get; set; }
        Bank 

        public User(String fName, String lName, int bn, int acc)
        {
            this.fName = fName;
            this.lName = lName;
            this.bn = (bankName)this.bn;
            this.acc = (accountType)acc;
        }
    }
}
