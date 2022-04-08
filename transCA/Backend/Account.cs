using System;
using transCA.Backend;
namespace transCA
{
    public class Account
    {
        private string _userName;
        private string _email;
        private string _password;
        private int _balance;

        public static Account CurrentUser { get; set; }



        public Account(string username, string email, string password)
        {
            _userName = username;
            _email = email; 
            _password = password;
            _balance = 0;
        }

        //Adding funds
        public void addFunds(int sum)
        {
            _balance = _balance + sum;
        }

        //Checking for funds
        //Returns false if not enough funds
        //otherwise true
        //Also deducts the funds from balance
        public bool CheckBalance(int sum) {
            if (sum <= _balance) 
            {
                _balance = _balance - sum;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
