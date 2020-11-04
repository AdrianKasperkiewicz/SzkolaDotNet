using System;
using System.Text.RegularExpressions;
using Email.App.Database;
using Email.Domain.Entity;

namespace Email.App.Presenters
{
    public class AdminPresenter
    {
        private readonly DatabaseManager<User> _databaseManager;

        public AdminPresenter(DatabaseManager<User> databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void AddUser()
        {
            _databaseManager.FIleExist();
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
                    _databaseManager.Add(user);
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
                    _databaseManager.DeleteFile();
                    break;
                case "no":
                    Console.WriteLine("the file was not deleted.\r\n");
                    break;
            }
        }

        public void CollectionOfUsers()
        {
            var userList = _databaseManager.GetAll();

            userList.ForEach(x => Console.WriteLine($"Name: {x.Name} Last name: {x.LastName} Email adress: {x.Email} User id: {x.Id} Creation date: {x.CreatedDateTime}"));
        }

        public void CreateNewUserFile()
        {
            _databaseManager.FIleExist();
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
                var userListById = _databaseManager.GetById(user);

                userListById.ForEach(x => Console.WriteLine($"Name: {x.Name}, Last name: {x.LastName}, Email adress: {x.Email}, Id: {x.Id}, Creation date: {x.CreatedDateTime}"));
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
                _databaseManager.Delete(user);
                Console.WriteLine("User deleted successfully");
            }
            else
            {
                Console.WriteLine("An incorrect value has been entered");
            }
        }
    }
}
