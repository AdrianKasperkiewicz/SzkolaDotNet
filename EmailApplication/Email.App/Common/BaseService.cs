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
        public List<T> Messages { get; set; }

        public BaseService()
        {
            Users = new List<T>();
            Messages=new List<T>();
        }
        public List<T> GetAll()
        {
            return Users;
        }

        public int Add(T user)
        {
            Users.Add(user);
            return user.Id;
        }

        public int Edit(T user)
        {
            var entity = Users.FirstOrDefault(x => x.Id == user.Id);
            if (entity !=null)
            {
                entity = user;
            }

            return entity.Id;
        }

        public void Remove(T user)
        {
            Users.Remove(user);
        }

        public void SendMessage(T message)
        {
            Messages.Add(message);
        }
    }
}
