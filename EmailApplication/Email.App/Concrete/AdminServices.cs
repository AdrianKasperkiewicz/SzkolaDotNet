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
        private string pathUsers =
            @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\User.txt";

        private string pathMessages =
            @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\Messages.txt";

        public void DeleteMessagesHistoryFile()
        {
            File.Delete(pathMessages);
        }
        public void CollectionOfUsers()
        {
            Console.WriteLine(File.ReadAllText(pathUsers));
        }

        public void CreateNewUsersFile()
        {
            File.Create(pathUsers).Dispose();
        }
        public void CreateNewMessageFile()
        {
            File.Create(pathMessages).Dispose();
        }

        public void DeleteUserFile()
        {
            File.Delete(pathUsers);
        }
    }
}
