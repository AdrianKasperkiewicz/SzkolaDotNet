using System;
using System.Text.RegularExpressions;
using Email.App.Service;
using Email.Domain.Entity;

namespace Email.App.Presenters
{
    public class AdminPresenter
    {
        private readonly JsonUserService _userService;

        public AdminPresenter(JsonUserService userService)
        {
            _userService = userService;
        }
        public void AddUser()
        {
                _userService.CheckUserFileExist();
                Console.WriteLine("Enter user name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter user last name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter user email adress");
                string email = Console.ReadLine();
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    Console.WriteLine("Enter id");
                    string parseId;
                    parseId = Console.ReadLine();
                    Int32.TryParse(parseId, out int id);
                    DateTime createdDateTime = DateTime.Now;

                    if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrWhiteSpace(email) && id != null)
                    {
                        Console.WriteLine($"User added: Name: {name}, Last name:  {lastName}, Email adress: {email}, Id: {id}, Created date: {createdDateTime}");
                        User user = new User()
                        {
                            Name = name,
                            LastName = lastName,
                            Email = email,
                            Id = id,
                            CreatedDateTime = createdDateTime
                        };
                        _userService.AddUser(user);
                    }
                    else
                    {
                        Console.WriteLine("Values are empty \r\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\r\nInvalid email adress: {email}\r\n");
                }
        }
        public void DeleteUsersFile()
        {
            Console.WriteLine("Are you sure you want to delete the file with users? Yes/No");
            string option = Console.ReadLine().ToLower();
            switch (option)
            {
                case "yes":
                    _userService.DeleteUserFile();
                    break;
                case "no":
                    Console.WriteLine("The file was not deleted.\r\n");
                    break;
            }
        }
        public void CollectionOfUsers()
        {
            var userList = _userService.GetAllUsers();

            foreach (var user in userList)
            {
                Console.WriteLine($"Name: {user.Name} Last name: {user.LastName} Email adress: {user.Email} User id: {user.Id} Creation date: {user.CreatedDateTime}");
            }
        }
        public void CreateNewUserFile()
        {
            _userService.CreteNewUserFile();
        }

        public void GetUserById()
        {
            Console.WriteLine("Enter the id of the user you want to find");
            string parseId = Console.ReadLine();
            
            if (Int32.TryParse(parseId, out int id))
            {
                User user = new User()
                {
                    Id = id
                };
              _userService.GetUserById(user); 
            }
            else
            {
                Console.WriteLine("An incorrect value has been entered");
            }
        }
        public void RemoveUserById()
        {
           Console.WriteLine("Enter the id of the user you want to delete");
           string parseId = Console.ReadLine();
           if (Int32.TryParse(parseId, out int id))
           {
               User user = new User
               {
                   Id = id
               };
               _userService.RemoveUserById(user);
               Console.WriteLine("User deleted successfully");
           }
           else
           {
               Console.WriteLine("An incorrect value has been entered");
           }
        }
    }
}
