﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florae_Basket
{
    class LoginController
    {
        private bool fail;

        public LoginController(int userAcctType, string user, string pass) {
            fail = false;
            /* 
            Database_Manager dbMngr = new Database_Manager();

            if (dbMngr.checkUsername(user)) {
                //checks the db password against the salted version of the provided password
                if (dbMngr.FetchPassword(user) != (pass + ".cs.is.fun.team.dirk.")) {
                    MessageBox.Show("Your password was not correct. Please enter the right credentials.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fail = true;   
            }
                else {
                    //Proceed to Main Menu
                    new MainMenu(userAcctType).Show();
                }
            else
                MessageBox.Show("Your username was not correct. Please enter the right credentials.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fail = true;
            }
            */
        }

        public bool Fail() { return fail; }
        /*
        
        public void CreateGUI(int acct)
        {
            ChangeUserGUI change = new ChangeUserGUI(this);
            change.ShowDialog();
            new MainMenu(acct).Show();
        }

        public void Main(string first, string last, string username, string password, string accType)
        {
            Database_Manager db = new Database_Manager();
            bool exists = false;

            exists = db.checkUsername(username);
            if (exists)
            {
                if (password != null && password != "")
                {
                    db.ChangePassword(username, Salt(password));
                }
                if (last != null && last != "")
                {
                    db.ChangeLastname(username, last);
                }
                if (first != null && first != "")
                {
                    db.ChangeFirstname(username, first);
                }
                if (accType != null && accType != "")
                {
                    db.ChangeAccType(username, accType);
                }
                if (verify(username, password, first, last, accType))
                {
                    MessageBox.Show("User account successfully changed.");
                }
                else
                {
                    MessageBox.Show("ERROR: User info was not changed");
                }
            }
            else
            {
                MessageBox.Show("ERROR: User account does not exist");
            }
        }

        // salt the password by adding on to the end of it
        public string Salt(string pwd)
        {
            pwd = pwd + ".cs.is.fun.team.dirk.";
            return pwd;
        }

        // hash the password
        private int Hash(string pwd)
        {
            int pwdHash = pwd.GetHashCode();
            return pwdHash;
        }

        public bool verify(string username, string password, string first, string last, string acct)
        {
            Database_Manager db = new Database_Manager();

            if (password != "" && password != null)
            {
                string salted = Salt(password);
                if (db.FetchPassword(username) != salted)
                {
                    return false;
                }
            }
            if (first != "" && first != null)
            {
                if (db.Fetchfirst(username) != first)
                {
                    return false;
                }
            }
            if (last != "" && last != null)
            {
                if (db.FetchLast(username) != last)
                {
                    return false;
                }
            }
            if (acct != "(No change)")
            {
                if (db.Fetchaccttype(username) != acct)
                {
                    return false;
                }
            }
            return true;
        }
        */
    }
}
