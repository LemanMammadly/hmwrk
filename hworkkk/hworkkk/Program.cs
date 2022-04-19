using hworkkk.NewFolder;
using System;
using hworkkk.Internface;


namespace hworkkk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emailinizi daxil edin: ");
            string email=Console.ReadLine();
            Console.WriteLine("Sifrenizi daxil edin: ");
            string password=Console.ReadLine();
            User user = new User(email,password);
          
            user.ShowInfo();
            
        }
    }
}
