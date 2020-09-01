using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using Email.App.Common;
using Email.App.Managers;
using Email.Domain.Common;
using EmailApplication.Domain;
using EmailApplication.Domain.Entity;

namespace EmailApplication.Services.Concrete
{
    public class UserServices : BaseService<User>
    {
        UserManager userManager = new UserManager();

        public void SendMessage(string message, string subject, string email)
        {
            Messages messages = new Messages() {Subject = subject, Message = message, Email = email};
            userManager.SendMessage("","","");
            
            //userManager.SendMessage(message, subject, email);
        }
        public void CreateNewMessageFile()
        {
            userManager.CreateNewMessageFile();
        }
        public void ShowMessageHistory()
        {
            userManager.ShowMessageHistory();
        }
    }
}
