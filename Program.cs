using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

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
    enum Type
    {
        


    }
    

    class Program
    {

        static void Main(string[] args)
        {
            

            int Principle;

            List<string> listName = new List<string>();
            List<string> listAssetGrowth = new List<string>();
            List<string> listNetInterestMargin = new List<string>();
            List<string> listROA = new List<string>();
            List<string> listLATLoans = new List<string>();
            List<string> listLoansToAssets = new List<string>();
            List<string> chosenList = new List<string>();





            using (var reader = new StreamReader(@"/Users/carlosespinozablunda/Documents/FDIC Data-1-1.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listName.Add(values[0]);
                    listAssetGrowth.Add(values[1]);
                    listNetInterestMargin.Add(values[2]);
                    listROA.Add(values[3]);
                    listLATLoans.Add(values[4]);
                    listLoansToAssets.Add(values[5]);

                }
            }
            listAssetGrowth.RemoveAt(0);
            listNetInterestMargin.RemoveAt(0);
            listROA.RemoveAt(0);
            listLATLoans.RemoveAt(0);
            listLoansToAssets.RemoveAt(0);

            listAssetGrowth.Sort();
            listAssetGrowth.Reverse();

            listNetInterestMargin.Sort();
            listNetInterestMargin.Reverse();

            listROA.Sort();
            listROA.Reverse();

            listLATLoans.Sort();
            listLATLoans.Reverse();

            listLoansToAssets.Sort();
            listLoansToAssets.Reverse();

            


            // Welcome Page
            Console.WriteLine(@"Welcome to greenBooks Financial Calculator:
By entering some simple information we will give you a full analysis of your individual case
We will need which bank you want, what data is important to you, and your desired principle
But first lets get your name:
");
            // User Info
            Console.WriteLine("Enter your first name:");
            String first = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            String last = Console.ReadLine();
            // Select Account
            Console.WriteLine("Please select one of the following options. \n1 = Asset Growth \n2 = Net Interest Margin \n3 = ROA \n4 = Loss Allowance to Loans\n5 = Loans to Assets ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your principle.");
            Principle = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    chosenList = listAssetGrowth;
                    Console.WriteLine("\n\nBased on the information you gave us these are your three best options:");

                    Console.WriteLine("\n" + listName[1]);
                    Console.WriteLine("Asset Growth: "+chosenList[0] + "\n");
                    Console.WriteLine("\n" + listName[2]);
                    Console.WriteLine("Asset Growth: " + chosenList[1] + "\n");
                    Console.WriteLine("\n" + listName[3]);
                    Console.WriteLine("Asset Growth: " + chosenList[2] + "\n");
                    break;
                case 2:
                    chosenList = listNetInterestMargin;
                    Console.WriteLine("\n\nBased on the information you gave us these are your three best options:");

                    Console.WriteLine("\n" + listName[1]);
                    Console.WriteLine("Net Interest Margin: " + chosenList[0] + "\n");
                    Console.WriteLine("\n" + listName[2]);
                    Console.WriteLine("Net Interest Margin: " + chosenList[1] + "\n");
                    Console.WriteLine("\n" + listName[3]);
                    Console.WriteLine("Net Interest Margin: " + chosenList[2] + "\n");
                    break;
                case 3:
                    chosenList = listROA;
                    Console.WriteLine("\n\nBased on the information you gave us these are your three best options:");

                    Console.WriteLine("\n" + listName[1]);
                    Console.WriteLine("ROA: " + chosenList[0] + "\n");
                    Console.WriteLine("\n" + listName[2]);
                    Console.WriteLine("ROA: " + chosenList[1] + "\n");
                    Console.WriteLine("\n" + listName[3]);
                    Console.WriteLine("ROA: " + chosenList[2] + "\n");
                    break;
                case 4:
                    chosenList = listLATLoans;
                    Console.WriteLine("\n\nBased on the information you gave us these are your three best options:");

                    Console.WriteLine("\n" + listName[1]);
                    Console.WriteLine("Loss Allowance to Loans: " + chosenList[0] + "\n");
                    Console.WriteLine("\n" + listName[2]);
                    Console.WriteLine("Loss Allowance to Loans: " + chosenList[1] + "\n");
                    Console.WriteLine("\n" + listName[3]);
                    Console.WriteLine("Loss Allowance to Loans: " + chosenList[2] + "\n");
                    break;
                case 5:
                    chosenList = listLoansToAssets;
                    Console.WriteLine("\n\nBased on the information you gave us these are your three best options:");

                    Console.WriteLine("\n" + listName[1]);
                    Console.WriteLine("Loans to Assets: " + chosenList[0] + "\n");
                    Console.WriteLine("\n" + listName[2]);
                    Console.WriteLine("Loans to Assets: " + chosenList[1] + "\n");
                    Console.WriteLine("\n" + listName[3]);
                    Console.WriteLine("Loans to Assets: " + chosenList[2] + "\n");
                    break;
            }
            // User Input Principal
           

           
            
            // Create Account
          //  User user = new User(first, last, (int)CurrentAccount, Principle);
            //Show results
          
        }
    }
}
