using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using System.IO;

namespace visual_greenBooks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> listName = new List<string>();
            List<string> listAssetGrowth = new List<string>();
            List<string> listNetInterestMargin = new List<string>();
            List<string> listROA = new List<string>();
            List<string> listLATLoans = new List<string>();
            List<string> listLoansToAssets = new List<string>();
            List<string> chosenList = new List<string>();

            List<string> AssetGrowth = new List<string>();
            List<string> NetInterestMargin = new List<string>();
            List<string> ROA = new List<string>();
            List<string> LATLoans = new List<string>();
            List<string> LoansToAssets = new List<string>();




            using (var reader = new StreamReader(@"C:\Users\OTHSCS120\Downloads\FDIC Data-1-1.csv"))
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

                    AssetGrowth.Add(values[1]);
                    NetInterestMargin.Add(values[2]);
                    ROA.Add(values[3]);
                    LATLoans.Add(values[4]);
                    LoansToAssets.Add(values[5]);


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



            var use = new greenBooks.User(FNBox.Text,LNBox.Text,AccBox.SelectedIndex+1,Convert.ToInt32(PrinBox.Text));

            


            if (AccBox.SelectedIndex==0)
            {
                chosenList = listAssetGrowth;
                FBest.Content = listName[AssetGrowth.IndexOf(chosenList[0])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[0]) * Convert.ToDouble(PrinBox.Text)));
                SBest.Content = listName[AssetGrowth.IndexOf(chosenList[1])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[1]) * Convert.ToDouble(PrinBox.Text)));
                TBest.Content = listName[AssetGrowth.IndexOf(chosenList[2])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[2]) * Convert.ToDouble(PrinBox.Text)));
            }
            else if (AccBox.SelectedIndex == 1)
            {
                chosenList = listNetInterestMargin;
                FBest.Content = listName[NetInterestMargin.IndexOf(chosenList[0])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[0]) * Convert.ToDouble(PrinBox.Text)));
                SBest.Content = listName[NetInterestMargin.IndexOf(chosenList[1])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[1]) * Convert.ToDouble(PrinBox.Text)));
                TBest.Content = listName[NetInterestMargin.IndexOf(chosenList[2])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[2]) * Convert.ToDouble(PrinBox.Text)));
            }
            else if (AccBox.SelectedIndex == 2)
            {
                chosenList = listROA;
                FBest.Content = listName[ROA.IndexOf(chosenList[0])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[0]) * Convert.ToDouble(PrinBox.Text)));
                SBest.Content = listName[ROA.IndexOf(chosenList[1])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[1]) * Convert.ToDouble(PrinBox.Text)));
                TBest.Content = listName[ROA.IndexOf(chosenList[2])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[2]) * Convert.ToDouble(PrinBox.Text)));
            }
            else if (AccBox.SelectedIndex == 3)
            {
                chosenList = listLATLoans;
                FBest.Content = listName[LATLoans.IndexOf(chosenList[0])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[0]) * Convert.ToDouble(PrinBox.Text)));
                SBest.Content = listName[LATLoans.IndexOf(chosenList[1])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[1]) * Convert.ToDouble(PrinBox.Text)));
                TBest.Content = listName[LATLoans.IndexOf(chosenList[2])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[2]) * Convert.ToDouble(PrinBox.Text)));
            }
            else if (AccBox.SelectedIndex == 4)
            {
                chosenList = listLoansToAssets;
                FBest.Content = listName[LoansToAssets.IndexOf(chosenList[0])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[0]) * Convert.ToDouble(PrinBox.Text)));
                SBest.Content = listName[LoansToAssets.IndexOf(chosenList[1])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[1]) * Convert.ToDouble(PrinBox.Text)));
                TBest.Content = listName[LoansToAssets.IndexOf(chosenList[2])] + ":" + String.Format("{0:0.00}", Convert.ToString(Convert.ToDouble(chosenList[2]) * Convert.ToDouble(PrinBox.Text)));
            }
   
        }
    }
}
