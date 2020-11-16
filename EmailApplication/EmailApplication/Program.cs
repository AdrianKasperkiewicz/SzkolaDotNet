using System;
using Email.App.Concrete;
using Email.App.Database;
using Email.App.Managers;
using Email.App.Presenters;
using Email.Domain.Entity;


namespace EmailApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService=new MenuActionService();
            AdminPresenter adminPresenter = new AdminPresenter(new DatabaseManager<User>());
            UserPresenter userPresenter=new UserPresenter(new DatabaseManager<Messages>());
            Console.WriteLine("Welcome to the e-mail application");
            while (true)
            {
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                string option = Console.ReadLine();
                if (Int32.TryParse(option, out int number) && number <= 14)
                {
                    switch (number)
                    {
                        case 1:
                            adminPresenter.AddUser();
                            break;
                        case 2:
                            userPresenter.SendMessage();
                            break;
                        case 3:
                            adminPresenter.CollectionOfUsers();
                            break;
                        case 4:
                            userPresenter.GetAllMessages();
                            break;
                        case 5:
                            userPresenter.GetMessageById();
                            break;
                        case 6:
                            userPresenter.RemoveMessageById();
                            break;
                        case 7:
                            adminPresenter.DeleteUsersFile();
                            break;
                        case 8:
                            userPresenter.DeleteMessageFile();
                            break;
                        case 9:
                            adminPresenter.CreateNewUserFile();
                            break;
                        case 10:
                            userPresenter.CreateNewMessageFile();
                            break;
                        case 11:
                            adminPresenter.GetUserById();
                            break;
                        case 12:
                            adminPresenter.RemoveUserById();
                            break;
                        case 13:
                            adminPresenter.UserUpdateById();
                            break;
                        case 14:
                            userPresenter.MessageUpdateById();
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
