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
    public class UserServices : BaseService<Messages>
    {
        private string path =
            @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\Messages.txt";

        public void CreateNewMessageFile()
        {
            File.Create(path).Dispose();
        }
        public void ShowMessageHistory()
        {
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
