using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace EmailApp
{
    public class UserService
    {
        public List<User> Users { get; set; }

        public List<User> GetAllUser()
        {
            return Users;
        }

        public void AddNewUser(int id, string name, string lastName, string emailAdress, string domainAdress, string allAdress)
        {
            User newUserAdd = new User()
            {
                Id = id,
                Name = name,
                LastName = lastName,
                EmailAdress = emailAdress,
                DomainAdress = domainAdress,
                AllAdress = allAdress
            };


            //Users.Add(newUserAdd);
            Console.WriteLine("Wprowadź imię ");
            name = Console.ReadLine();
            Console.WriteLine("Wprowadź nazwisko ");
            lastName = Console.ReadLine();
            Console.WriteLine("Wprowadź adres mail");
            emailAdress = Console.ReadLine();
            Console.WriteLine("Wprowadź domenę w jakiej chcesz założyć konto mail");
            domainAdress = Console.ReadLine();
            allAdress = ($"{emailAdress}@{domainAdress}");          

            string NewUserPath = @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApp\EmailApp\Users.txt";
            string[] newUser = { $"Imie: {name}, Nazwisko: {lastName} Adres mail: {allAdress}" };
            if (File.Exists(NewUserPath))
            {
                File.AppendAllLines(NewUserPath, newUser);
                Console.WriteLine($"Twoje dane: Imie: {name}, Nazwisko: {lastName}, Adres mail: {allAdress}");
            }
            else
            {
                var exception = File.Create(NewUserPath);
            }
        }

        public string UserMessage(string emailAdress, string message, string subject, int messageId, DateTime creationDate)
        {
            User userMessage = new User()
            {
                EmailAdress = emailAdress,
                Message = message,
                Subject = subject,
                MessageId = messageId,
                CreationDate = creationDate
            };
            //MessageOperator messageOperator = new MessageOperator();

            Console.WriteLine("Wprowadź temat");
            subject = Console.ReadLine();
            Console.WriteLine("Wprowadź wiadomość");
            message = Console.ReadLine();

            string path = @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApp\EmailApp\Message.txt";
            string[] messages = { $"ID: {messageId}, Temat: {subject}, Wiadomość: {message},  Data utworzenia: {creationDate.ToString()}" };
            if (File.Exists(path))
            {
                File.AppendAllLines(path, messages);
            }
            else
            {
                var exception = File.Create(path);
            }
            return message;
        }
    }
}
