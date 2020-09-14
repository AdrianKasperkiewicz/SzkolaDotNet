using System;
using System.Collections.Generic;
using System.Text;
using EmailApplication.Domain.Entity;

namespace Email.App.Abstract
{
    public interface IService<T>
    {
        //List<T> Users { get; set; }
        //List<T> Messages { get; set; }
        List<T> GetAllUsers();
        int AddUser(T user);
        int EditUser(T user);
        void RemoveUser(T user);
    }
}
