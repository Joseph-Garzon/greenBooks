using System;
using System.Collections;
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
            checking=1,
            savings=2,
            moneyMarket=3,
            cD=4,
            brokerage=5
        }

        public List<Banking.Bank> bBanks { get; set; } = new List<Banking.Bank>();
        //public List<> bestBankAcc = new ArrayList();
        String fName { get; set;}
        String lName { get; set;}
        accountType acc { get; set; }
        Banking.Bank BankOfAmerica;
        Banking.Bank Chase;
        Banking.Bank WellsFargo;
        Banking.Bank RoseBank;
        Banking.Bank ProsperityBank;
        Banking.Bank Allegiance;
        Banking.Bank Capital;
        Banking.Bank AllyBank;
        Banking.Bank OneMainFinancial;
        Banking.Bank CitiBank;
        Banking.Bank AIG;
        Banking.Bank GoldmanSachs;

        public User(String fName, String lName, int acc, int principle)
        {
            this.fName = fName;
            this.lName = lName;
            this.acc = (accountType)acc;
            BankOfAmerica = new Banking.Bank("Bank of America",0,0,0,0,0,principle);
            Chase = new Banking.Bank("Chase",0,0,0,0,0, principle);
            WellsFargo = new Banking.Bank("Wells Fargo",0, 0, 0, 0, 0, principle);
            RoseBank = new Banking.Bank("RoseBank",0, 0, 0, 0, 0, principle);
            ProsperityBank = new Banking.Bank("Prosperity Bank",0, 0, 0, 0, 0, principle);
            Allegiance = new Banking.Bank("Allegiance",0, 0, 0, 0, 0, principle);
            Capital = new Banking.Bank("Capital",0, 0, 0, 0, 0, principle);
            AllyBank = new Banking.Bank("Ally Bank",0, 0, 0, 0, 0, principle);
            OneMainFinancial = new Banking.Bank("One Main Financial",0, 0, 0, 0, 0, principle);
            CitiBank = new Banking.Bank("Citi Bank",0, 0, 0, 0, 0, principle);
            AIG = new Banking.Bank("AIG",0, 0, 0, 0, 0, principle);
            GoldmanSachs = new Banking.Bank("GoldmanSachs",0, 0, 0, 0, 0, principle);
            callAcc();
            sortBest();
        }

        public void callAcc()
        {
            bBanks.Clear();
            bBanks.Add(BankOfAmerica);
            bBanks.Add(Chase);
            bBanks.Add(WellsFargo);
            bBanks.Add(RoseBank);
            bBanks.Add(ProsperityBank);
            bBanks.Add(Allegiance);
            bBanks.Add(Capital);
            bBanks.Add(AllyBank);
            bBanks.Add(OneMainFinancial);
            bBanks.Add(CitiBank);
            bBanks.Add(AIG);
            bBanks.Add(GoldmanSachs);
        }

        public void sortBest()
        {
            for (int x=bBanks.Count-1; x>0;x-- )
            {
                for (int y=0; y<x;y++)
                {
                    if (bBanks[y].getAccountByType((int)acc).OverallRating()> bBanks[y+1].getAccountByType((int)acc).OverallRating())
                    {
                        var temp = bBanks[y];
                        bBanks[y]=bBanks[x];
                        bBanks[x] = temp;
                        x--;
                        break;
                    }
                }
            }
        }
    }
}
