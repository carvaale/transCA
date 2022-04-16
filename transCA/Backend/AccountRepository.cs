using System;
using System.Collections.Generic;

namespace transCA.Backend
{



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
