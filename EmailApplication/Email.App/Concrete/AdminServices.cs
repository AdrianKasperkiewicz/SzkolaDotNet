using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Email.App.Common;
using EmailApplication.Domain;
using EmailApplication.Domain.Entity;

namespace Email.App.Concrete
{
    public class AdminServices : BaseService<User>
    {
        private string pathUsers =
            @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\User.txt";

        private string pathMessages =
            @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\Messages.txt";

        public void AddUser(char userType)
        {
            int userTypeId;
            Int32.TryParse(userType.ToString(), out userTypeId);
            User user = new User(1, "");
            user. = userTypeId;
            Console.WriteLine("Please enter id for new item:");
            var id = Console.ReadLine();
            int itemId;
            Int32.TryParse(id, out itemId);
            Console.WriteLine("Please enter name for new item:");
            var name = Console.ReadLine();

            //item.Id = itemId;
            item.Name = name;

            Items.Add(item);
            return itemId;

            if (!File.Exists(pathUsers))
            {
                Console.WriteLine("Nie znaleziono pliku. Czy chcesz go utworzyć? Tak/Nie\r\n");
                string option = Console.ReadLine().ToLower();
                switch (option)
                {
                    case "tak":
                        CreateNewUserFile();
                        break;
                    case "nie":
                        Console.WriteLine("Nie zdecydowano się na utworzenie nowego pliku\r\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Podaj imię nowego użytkownika: ");
                name = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko nowego użytkownika: ");
                lastName = Console.ReadLine();
                Console.WriteLine("Podaj adres email nowego użytkownika: ");
                email = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrWhiteSpace(email))
                {
                    List<string> newUser = new List<string>();
                    newUser.Add($"Imie {name}, nazwisko {lastName}, adres email {email}");
                    Console.WriteLine($"Utworzyłeś nowego użytkownika: Imie {name}, nazwisko {lastName}, adres email {email}\r\n");
                    File.AppendAllLines(pathUsers, newUser);
                }
                else
                {
                    Console.WriteLine("Wartości są puste \r\n");
                }
            }
        }
        public void DeleteUsersFile()
        {
            if (File.Exists(pathUsers))
            {
                Console.WriteLine("Czy na pewno chcesz usunąć plik z użytkonikami? Tak/Nie\r\n");
                string option = Console.ReadLine().ToLower();
                switch (option)
                {
                    case "tak":
                        File.Delete(pathUsers);
                        Console.WriteLine("Poprawnie usunięto plik z użytkownikami\r\n");
                        break;
                    case "nie":
                        Console.WriteLine("Nie podjęto próby usunięcia pliku z użytkownikami\r\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Plik nie istnieje\r\n");
            }
        }
        public void DeleteMessagesHistoryFile()
        {
            if (File.Exists(pathMessages))
            {
                Console.WriteLine("Czy na pewno chcesz usunąć plik z historią wiadomości? Tak/Nie\r\n");
                string option = Console.ReadLine().ToLower();
                switch (option)
                {
                    case "tak":
                        File.Delete(pathMessages);
                        Console.WriteLine("Plik z historią wiadomości został usunięty\r\n");
                        break;
                    case "nie":
                        Console.WriteLine("Nie zdecydowano się na usunięcie pliku.\r\n");
                        break;
                }
            }
        }
        public void CollectionOfUsers()
        {
            if (File.Exists(pathUsers))
            {
                string usersCollection = File.ReadAllText(pathUsers);
                Console.WriteLine(usersCollection);
            }
        }
        public void CreateNewMessageFile()
        {
            if (!File.Exists(pathMessages))
            {
                File.Create(pathMessages).Dispose();
                Console.WriteLine("Poprawnie utworzono plik, lecz jest on pusty. Proszę utworzyć nową wiadomość.\r\n");
            }
            else
            {
                Console.WriteLine("Plik już istnieje\r\n");
            }
        }
        public void CreateNewUserFile()
        {
            if (!File.Exists(pathUsers))
            {
                File.Create(pathUsers).Dispose();
                Console.WriteLine("Poprawnie utworzono plik, lecz jest on pusty. Proszę dodać nowego użytkownika\r\n");
            }
            else
            {
                Console.WriteLine("Plik już istnieje\r\n");
            }
        }

        //public void CollectionOfUsers()
        //{
        //    if (File.Exists(pathUsers))
        //    {
        //        string usersCollection = File.ReadAllText(pathUsers);
        //        Console.WriteLine(usersCollection);
        //    }
        //}
        //public void CreateNewMessageFile()
        //{
        //    if (!File.Exists(pathMessages))
        //    {
        //        File.Create(pathMessages).Dispose();
        //        Console.WriteLine("Poprawnie utworzono plik, lecz jest on pusty. Proszę utworzyć nową wiadomość.\r\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Plik już istnieje\r\n");
        //    }
        //}
        //public void CreateNewUserFile()
        //{
        //    if (!File.Exists(pathUsers))
        //    {
        //        File.Create(pathUsers).Dispose();
        //        Console.WriteLine("Poprawnie utworzono plik, lecz jest on pusty. Proszę dodać nowego użytkownika\r\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Plik już istnieje\r\n");
        //    }
        //}
    }
}
