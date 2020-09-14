using System;
using System.Runtime.InteropServices.WindowsRuntime;
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
            MenuActionService actionService=new MenuActionService();
            AdminManager adminManager=new AdminManager();
            UserManager userManager=new UserManager();
            Console.WriteLine("Witam w aplikacji mailowej");
            while (true)
            {
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                string option = Console.ReadLine();
                if (Int32.TryParse(option, out int number) && number <= 8)
                {
                    switch (number)
                    {
                        case 1:
                            adminManager.AddUser();
                            break;
                        case 2:
                            userManager.SendMessage();
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
                    Console.WriteLine("An incorrect value has been entered\r\n");
                }
            }
        }
    }
}
