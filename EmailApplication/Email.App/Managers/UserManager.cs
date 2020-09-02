﻿using EmailApplication.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Email.App.Managers
{
    public class UserManager : Messages
    {
        private string path =
                   @"C:\Users\adrian.kasperkiewicz\Desktop\Git\SzkolaDotNet\SzkolaDotNet\SzkolaDotNet\EmailApplication\EmailApplication\Messages.txt";
        public void SendMessage(string message, string subject, string email, DateTime createdDateTime)
        {

            if (File.Exists(path))
            {
                Console.WriteLine("Wprowadź swój adres email");
                email = Console.ReadLine();
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    Console.WriteLine("Wprowadź temat");
                    subject = Console.ReadLine();
                    Console.WriteLine("Wprowadź treść wiadomości");
                    message = Console.ReadLine();
                    createdDateTime = DateTime.Now;
                    if (email != null && subject != null && message != null)
                    {
                        List<string> arr = new List<string>();
                        arr.Add($"Adres email nadawcy: {email}, Temat: {subject}, Wiadomość: {message}, Data: {createdDateTime}");

                        File.AppendAllLines(path, arr);
                        Console.WriteLine($"Adres email nadawcy: {email}, Temat: {subject}, Wiadomość: {message}\r\n");
                    }
                    else
                    {
                        Console.WriteLine("Wartości są puste");
                    }
                }
                else
                {
                    Console.WriteLine($"Wprowadzono błędny format adresu email: {email}");
                }

            }
            else
            {
                Console.WriteLine("Plik nie istnieje. Czy chcesz go stworzyć? Tak/Nie\r\n");
                string option = Console.ReadLine().ToLower();

                switch (option)
                {
                    case "tak":
                        CreateNewMessageFile();
                        break;
                    case "nie":
                        Console.WriteLine("Nie zdecydowałeś się na utworzenie pliku.\r\n");
                        break;
                }
            }
        }
        public void CreateNewMessageFile()
        {
            File.Create(path).Dispose();
            Console.WriteLine("Utworzono plik ale jest on pusty. Proszę wysłać nową wiadomość\r\n");
        }

        public void ShowMessageHistory()
        {
            if (File.Exists(path))
            {
                string messageHistory = File.ReadAllText(path);
                Console.WriteLine(messageHistory);
            }
            else
            {
                Console.WriteLine("Nie znaleziono pliku\r\n");
            }
        }
    }
}
