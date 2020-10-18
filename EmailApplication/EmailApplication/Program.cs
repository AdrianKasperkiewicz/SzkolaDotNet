using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Email.App.Common;
using Email.App.Concrete;
using Email.App.Managers;
using Email.Domain.Entity;


namespace EmailApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService=new MenuActionService();
            AdminManager adminManager=new AdminManager(new JsonUserService());
            //AdminManager adminManager=new AdminManager(new BaseService<User>());
            UserManager userManager=new UserManager(new JsonMessagesServices());
            Console.WriteLine("Welcome to the e-mail application");
            while (true)
            {
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                string option = Console.ReadLine();
                if (Int32.TryParse(option, out int number) && number <= 12)
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
                            userManager.GetAllMessages();
                            break;
                        case 5:
                            userManager.GetMessageById();
                            break;
                        case 6:
                            userManager.RemoveMessageById();
                            break;
                        case 7:
                            adminManager.DeleteUsersFile();
                            break;
                        case 8:
                            userManager.DeleteMessageFile();
                            break;
                        case 9:
                            adminManager.CreateNewUserFile();
                            break;
                        case 10:
                            userManager.CreateNewMessageFile();
                            break;
                        case 11:
                            adminManager.GetUserById();
                            break;
                        case 12:
                            adminManager.RemoveUserById();
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
