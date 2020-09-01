using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Email.App.Common;
using Email.App.Managers;
using EmailApplication.Domain;
using EmailApplication.Domain.Entity;

namespace Email.App.Concrete
{
    public class AdminServices : BaseService<User>
    {
        AdminManager adminManager = new AdminManager();
        public void AddUser(string name, string lastName, string email, int id)
        {
            adminManager.AddUser(name, lastName, email, id);
        }
        public void DeleteUser()
        {
            adminManager.DeleteUsersFile();
        }

        public void DeleteMessagesHistoryFile()
        {
            adminManager.DeleteMessagesHistoryFile();
        }
        public void CollectionOfUsers()
        {
            adminManager.CollectionOfUsers();
        }
        public void CreateNewMessageFile()
        {
            adminManager.CreateNewMessageFile();
        }
        public void CreateNewUserFile()
        {
            adminManager.CreateNewUserFile();
        }
    }
}
