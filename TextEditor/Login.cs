using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //initialise all users into a collection/data structure
            /*
            CredentialChecker credentialchecker = new CredentialChecker();
            credentialchecker.GetUsers();
            */
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            CreateUser form = new CreateUser();
            form.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //initialise load of user details
            CredentialChecker credentialchecker = new CredentialChecker();
            credentialchecker.GetUsers(UserNameTextBox.Text);

            bool verifylogin = credentialchecker.VerifyUser(PasswordTextBox.Text);

            //pass through the username, get the user details and check the password matches
            if (verifylogin)
            {
                string username = credentialchecker.UserName;
                string userfullname = credentialchecker.FirstName + " " + credentialchecker.LastName;
                string usertype = credentialchecker.UserType;
                 
                this.Hide();
                TextEditor form = new TextEditor(username, userfullname, usertype);
                form.Show();

            }
            else
            {
                MessageBox.Show("Unable to login. Username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class CredentialChecker
    {
        //location of login.txt in credential file
        private string credentialfile = @"Credentials\login.txt";
        private string username;
        private string password;
        private string usertype;
        private string firstname;
        private string lastname;
        private string dateofbirth;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string UserType
        {
            get { return usertype; }
            set { usertype = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }


        public Hashtable GetUsers(string username)
        {
            //create hashtable for storage of relevant user data
            Hashtable ht = new Hashtable();

            //open account file
            string[] loginfile = File.ReadAllLines(credentialfile);

            //loop through login file
            foreach (string text in loginfile)
            {
                //add text to array
                string[] kv = text.Split(',');

                //check first item matches username passed
                if (kv[0] == username)
                {
                    //add to class to track user
                    UserName = kv[0];
                    Password = kv[1];
                    UserType = kv[2];
                    FirstName = kv[3];
                    LastName = kv[4];
                    DateOfBirth = kv[5];

                    //add to hashtable and return 
                    ht.Add("UserName", kv[0]);
                    ht.Add("Password", kv[1]);
                    ht.Add("UserType", kv[2]);
                    ht.Add("FirstName", kv[3]);
                    ht.Add("LastName", kv[4]);
                    ht.Add("DateOfBirth", kv[5]);

                }
                else
                {
                    //else move to next item in list
                    continue;
                }
            }

            return ht;
        }

        //add user to the login.txt file
        public void CreateUser(string username, string password, string usertype, string firstname, string lastname, string dateofbirth)
        {
            //write to file
            string userdetails = "\n" + username + "," + password + "," + usertype + "," + firstname + "," + lastname + "," + dateofbirth;
            File.AppendAllText(credentialfile, userdetails);
        }


        //check if the user exists
        public bool UserExists(string username)
        {
           GetUsers(username);
           
           if (UserName == username)
           {
                //user exists
                return true;
           }
           else
           {
                //user does not exist
                return false;
           }

        }

        //verify the users password matches
        public bool VerifyUser(string enteredpassword)
        {
            //validate username + password correct
            if (enteredpassword == Password)
            {
                return true;
            }
            else
                return false;
        }

        public void SaveUsers()
        {
            //to implement - save data collection to file on close
        }
    }
}
