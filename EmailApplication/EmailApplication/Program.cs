using System;
using Email.App.Concrete;
using EmailApplication.Services;
using AdminServices = EmailApplication.Services.AdminServices;

namespace EmailApplication
{
    public class Program
    {
        //StartScreenServices startScreen=new StartScreenServices();
        //startScreen.StartScreen();

        static void Main(string[] args)
        {
            AdminServices adminServices = new AdminServices();
            UserServices userServices = new UserServices();
            Console.WriteLine("Witam w aplikacji mailowej");
            while (true)
            {
                Console.WriteLine("Powiedz co chcesz zrobić");
                Console.WriteLine("1. Dodać użytkownia");
                Console.WriteLine("2. Wysłać mail");
                Console.WriteLine("3. Zobaczyć listę użytkowników");
                Console.WriteLine("4. Zobaczyć historię wiadomości");
                Console.WriteLine("5. Usunąć plik z użytkownikami");
                Console.WriteLine("6. Usunąć plik z historią wiadomości");
                Console.WriteLine("7. Dodać plik User.txt");
                Console.WriteLine("8. Dodać plik Messages.txt\r\n");

                string option = Console.ReadLine();
                if (Int32.TryParse(option, out int number) && number <= 8)
                {
                    switch (number)
                    {
                        case 1:
                            var keyInfo = adminServices.AddUser()
                            break;
                        case 2:
                            SendMessage();
                            break;
                        case 3:
                            ShowAllUsers();
                            break;
                        case 4:
                            ShowAllMessages();
                            break;
                        case 5:
                            DeleteUsersFile();
                            break;
                        case 6:
                            DeleteHistoryOfmessagesFile();
                            break;
                        case 7:
                            CreateUsersFile();
                            break;
                        case 8:
                            CreateMessagesFile();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wprowadzono błędną wartość\r\n");
                }
            }
        }
    }
}
