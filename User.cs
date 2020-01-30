using System;
using System.Collections.Generic;
using System.Text;

namespace greenBooks
{
    
    public class User
    {
        private Banks bank;
        private AccountType account;
        private string firstName;
        private string lastName;
        private string emailAddress;
        public User(string firstName, string lastName, string emailAddress){
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            
        }

        public string getFN(){
            return firstName;
        }
        public string getLN(){
            return lastName;
        }
        public string getEmail(){
            return emailAddress;
        }
        public void setFN(string FN){
            this.firstName = FN;
        }
        public void setLN(string LN){
            this.lastName = LN;
        }
        public void setEmail(string email){
            this.emailAddress = email;
        }
    }
}





   
        
      
   
