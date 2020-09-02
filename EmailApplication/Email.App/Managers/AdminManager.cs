using Email.App.Concrete;
using EmailApplication.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Email.App.Managers
{
    public class AdminManager
    {
        private string pathUsers =
            @"C:\Users\adrian.kasperkiewicz\Desktop\Git\SzkolaDotNet\SzkolaDotNet\SzkolaDotNet\EmailApplication\EmailApplication\User.txt";

        private string pathMessages =
            @"C:\Users\adrian.kasperkiewicz\Desktop\Git\SzkolaDotNet\SzkolaDotNet\SzkolaDotNet\EmailApplication\EmailApplication\Messages.txt";

        public void AddUser(string name, string lastName, string email, int id, DateTime createdDateTime)
        {
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
            else if (File.Exists(pathUsers))
            {
                Console.WriteLine("Wprowadź imie użytkownika");
                name = Console.ReadLine();
                Console.WriteLine("Wprowadź nazwisko użytkownika");
                lastName = Console.ReadLine();
                Console.WriteLine("Wprowadź adres mail");
                email = Console.ReadLine();
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    Console.WriteLine("\r\nWprowadź id");
                    string parseId;
                    parseId = Console.ReadLine();
                    Int32.TryParse(parseId, out id);
                    createdDateTime = DateTime.Now;

                    if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrWhiteSpace(email) && id != null)
                    {
                        List<string> newUser = new List<string>();
                        newUser.Add($"Imie {name}, nazwisko {lastName}, adres email {email}, Id: {id}, Data: {createdDateTime}");
                        File.AppendAllLines(pathUsers, newUser);
                        Console.WriteLine($"Dodano użytkownika: Imie {name}, Nazwisko {lastName}, Adres email {email}, Id: {id}, Data: {createdDateTime}");
                    }
                    else
                    {
                        Console.WriteLine("Wartości są puste \r\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\r\nNiepoprawny adres email: {email}\r\n");
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
            else
            {
                Console.WriteLine("Plik nie istnieje\r\n");
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
    }
}
