using System;
namespace transCA
{
    public class Account
        //Name: Muhammad Choudhary
    {



        //Storing user name of user
        private string _userName;


        private string _email;

        private string _password;

        

        //Storing user balance
        private double _balance;


        //Adding funds
        public void addFunds(double sum)
        {
            _balance = _balance + sum;
        }

        //Checking for funds
        //Returns false if not enough funds
        //otherwise true
        //Also deducts the funds from balance
        public bool CheckBalance(double sum) {

            if (sum >= _balance) {

                _balance = _balance - sum;
                return true;

            }

            else
            {
                return false;
            }

        }






        public Account(string username, string email, string password)
        {

            _userName = username;
            _email = email;
            _password = password;


        }
    }
}
