using System;
using System.Collections.Generic;
using System.Text;
using EmailApplication.Domain.Entity;

namespace Email.App.Abstract
{
    public interface IMessageService<T>
    {
        List<T> GetAllMessages();
        int SendMessage(T message);
        void CheckMessageFileExist();
        void GetMessageById(T message);
        void CreteNewMessageFile();
        void DeleteMessageFile();
        void RemoveMessageById(T message);
    }
}
