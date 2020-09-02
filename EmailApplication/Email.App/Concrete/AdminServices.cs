using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Email.App.Common;
using Email.App.Managers;
using Email.Domain.Common;
using EmailApplication.Domain;
using EmailApplication.Domain.Entity;

namespace Email.App.Concrete
{
    public class AdminServices : BaseService<User> 
    {
        AuditableModel auditableModel =new AuditableModel();
        AdminManager adminManager = new AdminManager();

        public List<User> AddUser(string name, string lastName, string email, int id, DateTime createdDateTime)
        {
            User user = new User() {Name = name, LastName = lastName, Email = email, Id = id, CreatedDateTime = createdDateTime};
           
            adminManager.AddUser("","","",0, DateTime.Now);
            return Users;
        }
        //public void DeleteUser()
        //{
        //    DeleteUser();
        //}

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

        public void DeleteUserFile()
        {
            adminManager.DeleteUsersFile();
        }
    }
}
