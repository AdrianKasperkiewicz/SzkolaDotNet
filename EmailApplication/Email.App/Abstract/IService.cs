using System;
using System.Collections.Generic;
using System.Text;

namespace Email.App.Abstract
{
    public interface IService<T>
    {
        //List<T> Users { get; set; }
        //List<T> Messages { get; set; }
        List<T> GetAll();
        int Add(T user);
        int Edit(T user);
        void Remove(T user);
    }
}
