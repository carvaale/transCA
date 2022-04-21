using System;
using System.Collections.Generic;

namespace transCA.Backend
{
    //Principle Author: Muhammad Choudhary
    //This is static class that will keep track of all the accounts in the app
    //It has a list which a method can add a account to and also a method to verify
    //the creditentials of an account upon login


    public enum LoginResult
    {

        IncorrectPassword,
        NoEmail,
        AllGood

    }

    public static class AccountRepository
    {




        private static List<Account> _accountList;// = new List<Account>();



        static AccountRepository()
        {
            _accountList = new List<Account>();
        }



        public static void AddAccount(Account account) {

            _accountList.Add(account);

        }


        public static bool AccountExists(string email) {

            foreach (Account account in _accountList) {

                if (email.ToLower() == account.getEmail().ToLower()) {
                    return true;
                }

            }

            return false;


        }

        public static LoginResult TryLogin(string email, string password) {

            if (!AccountExists(email)) {

                return LoginResult.NoEmail;
            }

            foreach (Account account in _accountList) {
                if (email.ToLower() == account.getEmail().ToLower()){
                    if (account.getPassword().Equals(password)) {
                        return LoginResult.AllGood;

                    }

                }
            }
            return LoginResult.IncorrectPassword;

        }


    }
}
