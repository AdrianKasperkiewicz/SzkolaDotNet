using System.Collections.Generic;

namespace Email.App.Abstract
{
    public interface IUserService<T>
    {
        List<T> GetAllUsers();
        int AddUser(T user);
        int EditUser(T user);
        void RemoveUserById(T user);
        void CheckUserFileExist();
        void GetUserById(T user);
        void CreteNewUserFile();
        void DeleteUserFile();
    }
}
