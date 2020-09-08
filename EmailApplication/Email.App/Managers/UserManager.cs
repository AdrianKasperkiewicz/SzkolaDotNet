﻿using EmailApplication.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Email.App.Concrete;
using EmailApplication.Services.Concrete;

namespace Email.App.Managers
{
    public class UserManager : UserServices
    {

        private string path =
                   @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\Messages.txt";
        private readonly UserServices userServices = new UserServices();
        private readonly AdminServices adminServices=new AdminServices();
        public void SendMessage()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Wprowadź swój adres email");
                string email = Console.ReadLine();
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    Console.WriteLine("Wprowadź temat");
                    string subject = Console.ReadLine();
                    Console.WriteLine("Wprowadź treść wiadomości");
                    string message = Console.ReadLine();
                    DateTime createdDateTime = DateTime.Now;
                    if (email != null && subject != null && message != null)
                    {
                        List<string> newMessageAdd = new List<string>();
                        newMessageAdd.Add($"Adres email nadawcy: {email}, Temat: {subject}, Wiadomość: {message}, Data: {createdDateTime}");

                        File.AppendAllLines(path, newMessageAdd);
                        Console.WriteLine($"Adres email nadawcy: {email}, Temat: {subject}, Wiadomość: {message}\r\n");
                        Messages messages = new Messages()
                        {
                            MessageContents = message,
                            Subject = subject,
                            Email = email
                        };
                        userServices.SendMessage(messages);
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
                        adminServices.CreateNewMessageFile();
                        Console.WriteLine("Plik został poprawnie utworzony, lecz jest pusty. Proszę dodać nową wiadomość");
                        break;
                    case "nie":
                        Console.WriteLine("Nie zdecydowałeś się na utworzenie pliku.\r\n");
                        break;
                }
            }
        }
        public void ShowMessageHistory()
        {
            if (File.Exists(path))
            {
                userServices.ShowMessageHistory();
            }
            else
            {
                Console.WriteLine("Nie znaleziono pliku\r\n");
            }
        }
    }
}
