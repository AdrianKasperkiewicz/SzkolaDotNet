﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using EmailApplication.Properties;

namespace EmailApplication.Services
{
    public class UserServices : Messages
    {
        private string path =
                   @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien3\EmailApplication\EmailApplication\Messages.txt";
        public void SendMessage(string message, string subject, string email)
        {
            Messages messages = new Messages()
            {
                Message = message,
                Subject = subject,
                Email = email
            };

            if (File.Exists(path))
            {
                Console.WriteLine("Wprowadź swój adres email");
                email = Console.ReadLine();
                Console.WriteLine("Wprowadź temat");
                subject = Console.ReadLine();
                Console.WriteLine("Wprowadź treść wiadomości");
                message = Console.ReadLine();
                if (email != null && subject != null && messages != null)
                {
                    List<string> arr = new List<string>();
                    arr.Add($"Adres email nadawcy: {email}, Temat: {subject}, Wiadomość: {message}");

                    File.AppendAllLines(path, arr);
                    Console.WriteLine($"Adres email nadawcy: {email}, Temat: {subject}, Wiadomość: {message}\r\n");
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