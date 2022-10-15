using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class CreateUser : Form
    {
        private string password;
        private string Password { get => password; set => password = value; }

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = "username";
            string firstname = "firstname";
            string lastname = "lastname";
            string dateofbirth = "dateofbirth";
            string usertype = "usertype";
            string password = "password";


            //create hashtable for storage of relevant user data
            Hashtable user = new Hashtable();

            //add inputs to hashtable 
            user.Add(username, UserNameInput.Text);
            user.Add(password, PasswordInput.Text);
            user.Add(usertype, UserTypeComboBox.Text);
            user.Add(firstname, FirstNameInput.Text);
            user.Add(lastname, LastNameInput.Text);
            user.Add(dateofbirth, UserDOBInput.Text);


            //reset the error dialogs
            FirstNameValidationFail.Text = "";
            LastNameValidationFail.Text = "";
            UserNameValidationFail.Text = "";
            UserTypeValidationFail.Text = "";
            PasswordEntryValidationFail.Text = "";
            PasswordMatchFail.Text = "";

            bool passwordcheck = CheckPassword();
            
            if (!String.IsNullOrEmpty((string)user[firstname]))
            {

                if (!String.IsNullOrEmpty((string)user[lastname]))
                {

                    if (!String.IsNullOrEmpty((string)user[username]))
                    {
                        // if (username = an exisitng username)
                        //{ 
                        if (!String.IsNullOrEmpty((string)user[usertype]))
                        {

                            if (!String.IsNullOrEmpty(PasswordInput.Text))
                            {

                                if (!String.IsNullOrEmpty(ConfirmPasswordInput.Text))
                                {
                                    if (passwordcheck)
                                    {
                                        CredentialChecker credentialchecker = new CredentialChecker();

                                        if (credentialchecker.UserExists(username))
                                        {
                                            MessageBox.Show("A user with this username already exists", "User already exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            credentialchecker.CreateUser((string)user[username], (string)user[password], (string)user[usertype], (string)user[firstname], (string)user[lastname], (string)user[dateofbirth]);

                                            MessageBox.Show("New user created: " + (string)user[firstname] + " " + (string)user[lastname], "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            Login form = new Login();
                                            form.Show();
                                            this.Close();
                                        }

                                    }
                                    else
                                    {
                                        //error dialog advising passwords don't match
                                        PasswordMatchFail.Text = "Passwords don't match.";
                                    }
                                }
                                else
                                {
                                    PasswordMatchFail.Text = "Please re-enter the password";
                                }
                            }
                            else
                            {
                                PasswordEntryValidationFail.Text = "Please enter a password";
                            }
                        }
                        else
                        {
                            UserTypeValidationFail.Text = "User type is required";
                        }
                    //}
                    //else
                    }
                    else
                    {
                        UserNameValidationFail.Text = "Username is required.";
                    }
                }
                else
                {
                    LastNameValidationFail.Text = "Last name is required";
                }
            }
            else
            {
                FirstNameValidationFail.Text = "First name is required.";
            }
        }

        private bool CheckPassword()
        {
            if (PasswordInput.Text == ConfirmPasswordInput.Text)
            {
                Password = PasswordInput.Text;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
