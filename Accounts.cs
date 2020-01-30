using System;
namespace Banking{
    public class Accounts{

        private double interestRate;
        private double principal;
        

        public Accounts( double principal, double interestRate) {
            this.principal = principal;
            this.interestRate = interestRate;
        }

        public double GetInterestRate(){
            return interestRate;
        }

        public void SetInterestRate(double interestRate){
            this.interestRate = interestRate;
        }

        public double GetPrincipal() {
            return principal;
        }

        public void SetPrincipal(double principal){
            this.principal = principal;
        }
        public void IncreasePrincipal(double investment){
            this.principal += investment;
        }
        public void DecreasePrincipal(double withdrawal)
        {
            this.principal -= withdrawal;
        }

        public double ROIContCompounded(double time)
        {
            var ROI = this.principal * Math.Log(Math.E, time * this.interestRate/100);
            return ROI;
        }
        public double ROICompounded(double time, double frequency){
            var ROI = this.principal * Math.Pow((1 + (this.interestRate/100) / frequency), (frequency * time)); 
            return ROI;
        }
        public double ROISimple(double time)
        {
            var interest = this.principal * this.interestRate/100 * time;
            return interest + this.principal;
        }
       


    }
}


//Basic Checking Accounts
//Savings Accounts
//Interest Bearing Checking Accounts
//Money Market Accounts
//CD’s
//IRAs(investment retirement accounts)
//Brokerage Accounts