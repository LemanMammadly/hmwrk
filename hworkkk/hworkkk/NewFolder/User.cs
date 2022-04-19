
using hworkkk.Internface;
using System;
using System.Collections.Generic;
using System.Text;

namespace hworkkk.NewFolder
{
    public class User : IAccount
    {
        public string FullName;
        public string Email;
        private string _password;

        public string PassWord 
        {
            get
            {
                return _password;
            }
            set
            {              
                PasswordChecked(value);
                _password = value;
                
            }
        }
       

        public void ShowInfo()
        {
            Console.WriteLine($"Email: {Email} Sifre: {PassWord}");
        }

        public bool PasswordChecked(string passWord)
        {
            bool check = true;
            while (check)
            {
                bool checkUpper = false;
                bool checkLower = false;
                bool checkDigit = false;

                if (passWord.Length >= 8)
                {

                    foreach (char item in passWord)
                    {
                        if (char.IsUpper(item))
                        {
                            checkUpper = true;
                        }
                        else if (char.IsLower(item))
                        {
                            checkLower = true;
                        }
                        else if (char.IsDigit(item))
                        {
                            checkDigit = true;
                        }                     
                    }
                    if (checkUpper == true && checkLower == true && checkDigit == true)
                    {
                        Console.WriteLine("Sifre duzgundur");
                        check = false;
                        break;
                    }
                    if (checkDigit == false || checkLower == false || checkUpper == false)
                    {
                        Console.WriteLine("Sifreni Duzgun Daxil Et:");
                      
                        passWord = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Sifre minimum 8 simvollu olmalidir");
                    passWord = Console.ReadLine();
                }

            }
            return check;
        }
        public User(string email, string password)
        {
            Email = email;
            PassWord = password;
        }
    }
}
