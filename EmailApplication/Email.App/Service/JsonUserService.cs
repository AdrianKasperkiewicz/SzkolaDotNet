using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Email.App.Abstract;
using Email.App.Database;
using Email.Domain.Entity;
using Newtonsoft.Json;

namespace Email.App.Service
{
    public class JsonUserService
    {
        private string pathUsers =
            @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\User.json";
        public int AddUser(User user)
        {
            List<User> userList;
            using (StreamReader sr = new StreamReader(pathUsers))                               //StreamReader jest strumieniem, który jest Ci potrzebny żeby jakikolwiek plik przeczytać. To taki mechanizm który pobiera plik bajt po bajcie i daje rady te wszystkie bajty zamienić na string 
            {
                string json = sr.ReadToEnd();                                                   //ReadToEnd=to metoda, która przeczyta cały plik i zamieni go na string (czyli czyta wszystko z sr i zamienia na string json
                userList = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();     //deserializacja string do swoich obiektów, u mnie Lista<Userów>, ??=jeśli JsonConvertDeserialization będzie nullem to stwórz nową listę User
                userList.Add(user);                                                                //dodanie nowego elementu do pliku json
            }
            File.WriteAllText(pathUsers, JsonConvert.SerializeObject(userList));           //zapisuje pathUsers, zawartością serialozowaną users
            return user.Id;
        }

        public int EditUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
          var databaseManager = new DatabaseManager<User>();
          
          return databaseManager.GetAll();
        }

        public void GetUserById(User user)
        {
            List<User> userList;
            using (StreamReader sr = new StreamReader(pathUsers))
            {
                string json = sr.ReadToEnd();
                userList = JsonConvert.DeserializeObject<List<User>>(json);
                var foundUser = userList.Where(x => x.Id == user.Id).ToList();
                foreach (User users in foundUser)
                {
                    Console.WriteLine($"Name: {users.Name} Last name: {users.LastName} Email adress: {users.Email} User id: {users.Id} Creation date: {users.CreatedDateTime}");
                }
            }
        }

        public void RemoveUserById(User user)
        {
            List<User> userList;
            using (StreamReader sr = new StreamReader(pathUsers))
            {
                string json = sr.ReadToEnd();
                userList = JsonConvert.DeserializeObject<List<User>>(json);
                var userToDelete = userList.Where(x => x.Id == user.Id).ToList();
                foreach (User users in userToDelete)
                {
                    userList.Remove(users);
                }
            }
            File.WriteAllText(pathUsers, JsonConvert.SerializeObject(userList));
        }

        public void CheckUserFileExist()
        {
            if (!File.Exists(pathUsers))
            {
                Console.WriteLine("File not found. Do you want to create it? Yes/No\r\n");
                string option = Console.ReadLine().ToLower();
                switch (option)
                {
                    case "yes":
                        File.Create(pathUsers).Dispose();
                        Console.WriteLine("The file was legally created.");
                        break;
                    case "no":
                        Console.WriteLine("It was not decided to create a new file\r\n");
                        break;
                }
            }

        }
        public void CreteNewUserFile()
        {
            if (!File.Exists(pathUsers))
            {
                File.Create(pathUsers).Dispose();
                Console.WriteLine("The file was legally created.");
            }
            else
            {
                Console.WriteLine("This file already exists");
            }
        }

        public void DeleteUserFile()
        {
            File.Delete(pathUsers);
            Console.WriteLine("The user file has been deleted\r\n");
        }
    }
}
