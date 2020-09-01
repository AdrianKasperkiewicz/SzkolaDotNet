using System;
using Email.App.Concrete;
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
                            adminServices.AddUser("","","",0);
                            break;
                        case 2:
                            userServices.SendMessage("", "", "");
                            break;
                        case 3:
                            adminServices.CollectionOfUsers();
                            break;
                        case 4:
                            userServices.ShowMessageHistory();
                            break;
                        case 5:
                            adminServices.DeleteUserFile();
                            break;
                        case 6:
                            adminServices.DeleteMessagesHistoryFile();
                            break;
                        case 7:
                            adminServices.CreateNewUserFile();
                            break;
                        case 8:
                            adminServices.CreateNewMessageFile();
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
