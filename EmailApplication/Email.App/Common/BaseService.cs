using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Email.App.Abstract;
using Email.Domain.Common;

namespace Email.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Users { get; set; }

        public BaseService()
        {
            Users = new List<T>();
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
            if (entity !=null)
            {
                entity = user;
            }

            return entity.Id;
        }

        public void RemoveUser(T user)
        {
            Users.Remove(user);
        }
    }
}
