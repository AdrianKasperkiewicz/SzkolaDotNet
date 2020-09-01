using System;
using Email.App.Concrete;
using Email.App.Managers;
using EmailApplication.Services;
using EmailApplication.Services.Concrete;

namespace EmailApplication
{
    public class Program
    {
        //StartScreenServices startScreen=new StartScreenServices();
        //startScreen.StartScreen();

        static void Main(string[] args)
        {
            //AdminServices adminServices = new AdminServices();
            //UserServices userServices = new UserServices();
            AdminManager adminManager=new AdminManager();
            UserManager userManager=new UserManager();
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
                            adminManager.AddUser("","","",0);
                            break;
                        case 2:
                            userManager.SendMessage("", "", "");
                            break;
                        case 3:
                            adminManager.CollectionOfUsers();
                            break;
                        case 4:
                            userManager.ShowMessageHistory();
                            break;
                        case 5:
                            adminManager.DeleteUsersFile();
                            break;
                        case 6:
                            adminManager.DeleteMessagesHistoryFile();
                            break;
                        case 7:
                            adminManager.CreateNewUserFile();
                            break;
                        case 8:
                            adminManager.CreateNewMessageFile();
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
