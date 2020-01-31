using System;
using System.Collections.Generic;
using System.Text;

namespace greenBooks
{
    public class User
    {
        public enum bankName
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
        Banking.Bank _bank { get; set; }
        String email { get; set; }
        int status=0;

        public User(String fName, String lName, String email, int bn, int acc, int principle, int status)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.bn = (bankName)bn;
            this.acc = (accountType)acc;
            _bank = new Banking.Bank(principle,bn);
            this.status = status;
        }

        public int getStatus(){
            return status;
        }

        public void setStatus(int status){
            this.status = status;
        }

    }
}
