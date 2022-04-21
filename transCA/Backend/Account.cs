using System;
using System.Collections.Generic;
using transCA.Backend;
namespace transCA
{
    //Principle Author: Muhammad Choudhary
    //This is the account class that has the properties of the account
    //It also has methods add money into a account, get the balance of an account
    //It also has methods that retrieve the account usernames,passwords, and emails
    public class Account
    {
        private string _userName;
        private string _email;
        private string _password;
        private int _balance;

        public static Account CurrentUser { get; set; }



        public Account(string username, string password)
        {
            _userName = username;
            _password = password;
            _balance = 0;
        }



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

        public string GetUserName()
        {
            return _userName;
        }

        public string getEmail()
        {

            return _email;
        }

        public string getPassword()
        {

            return _password;

        }
    }
}
