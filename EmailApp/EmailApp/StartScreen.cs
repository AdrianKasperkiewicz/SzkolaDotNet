using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EmailApp
{
    public class StartScreen : UserService
    {
        UserService userService = new UserService();
        User user = new User();
        public void FirstScreen()
        {
            Console.WriteLine("Witam Cię w mojej aplikacji emailowej!!");
            Console.WriteLine("Wybierz proszę co chcesz zrobić chcesz zrobić");
            Console.WriteLine("1 Aby wysłać maila");

            string option = Console.ReadLine();
            if (Int32.TryParse(option, out int number))
            {
                switch (number)
                {
                    case 1:
                        MessageSending();
                        break;
                }
            }
        }
        public void MessageSending() 
        {
                
                userService.UserMessage(user.EmailAdress, user.Message, user.Subject, user.MessageId, user.CreationDate);

        }
    }
}
