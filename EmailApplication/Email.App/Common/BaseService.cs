using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Email.App.Abstract;
using Email.App.Managers;
using Email.Domain.Common;
using EmailApplication.Domain.Entity;

namespace Email.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity 
    {
      
        private string pathUsers =
            @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\User.txt";
        public List<T> Users { get; set; }
        public List<T> Messages { get; set; }
        public List<T> Items { get; set; }
        
        public BaseService()
        {
            Users = new List<T>();
            Messages=new List<T>();
            Items = new List<T>();
        }
        public List<T> GetAllUsers()
        {
            return Users;
        }

        public int AddUser(T user)
        {
            Users.Add(user);
            return user.Id;
        }

        public int EditUser(T user)
        {
            var entity = Users.FirstOrDefault(x => x.Id == user.Id);
            if (entity != null)
            {
                entity = user;
            }

            return entity.Id;
        }

        public void RemoveUser(T user)
        {
            Users.Remove(user);
        }

        public void SendMessage(T message)
        {
            Messages.Add(message);
        }

        public int AddItem(T item)
        {
            Items.Add(item);
            return item.Id;
        }
    }
}
