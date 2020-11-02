using System;
using System.Collections.Generic;
using System.Linq;
using Email.Domain.Common;

namespace Email.App.Abstract
{
    public class BaseService<T> : IUserService<T> where T : BaseEntity
    {
        public List<T> Users { get; set; }
        public List<T> Messages { get; set; }
        public List<T> Items { get; set; }

        public BaseService()
        {
            Users = new List<T>();
            Messages = new List<T>();
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

        public void RemoveUserById(T user)
        {
            Users.Remove(user);
        }

        public void CheckUserFileExist()
        {
            throw new NotImplementedException();
        }

        public void GetUserById(T user)
        {
            var entity = Users.FirstOrDefault(x => x.Id == user.Id);
        }

        public int AddItem(T item)
        {
            Items.Add(item);
            return item.Id;
        }

        public void CreteNewUserFile()
        {
            throw new NotImplementedException();
        }

        public void DeleteUserFile()
        {
            throw new NotImplementedException();
        }
    }
}
