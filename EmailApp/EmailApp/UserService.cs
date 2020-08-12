using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EmailApp
{
    public class UserService
    {
        public List<User> Users { get; set; }
       
        public List <User> GetAllUser()
        {
            return Users;
        } 
        public int AddNewUser(int id, string name, string lastName, string emailAdress, Array domainAdress)
        {
            User user = new User() {Id=id ,Name=name, LastName=lastName, EmailAdress=emailAdress, DomainAdress=domainAdress };
            Users.Add(user);
            return user.Id;
        }

        public string UserMessage(string emailAdress, string message,string subject, int messageId, DateTime creationDate)
        {
            User userMessage = new User() { EmailAdress = emailAdress, Message = message, Subject=subject, 
                                            MessageId = messageId, CreationDate=creationDate };

            Console.WriteLine("Wprowadź temat");
            subject = Console.ReadLine();
            Console.WriteLine("Wprowadź wiadomość");
            message = Console.ReadLine();
            messageId++;
            string path=@"C:\Users\adrian.kasperkiewicz\Desktop\Git\SzkolaDotNet\SzkolaDotNet\SzkolaDotNet\EmailApp\EmailApp\Message.txt";
            string[] messages = { $"Temat: {subject}, Wiadomość: {message}, ID: {messageId.ToString()}, Data utworzenia: {creationDate.ToString()}"};
            if (File.Exists(path))
            {
                File.WriteAllLines(path, messages);
            }
            else
            {
                var s = File.Create(path);
            }
            return message;
        }
    }
}
