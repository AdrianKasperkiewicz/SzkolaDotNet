using EmailApplication.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Email.App.Abstract;
using Email.App.Concrete;


namespace Email.App.Managers
{
    public class UserManager 
    {
        private IMessageService<Messages> _messageService;
        public UserManager(IMessageService<Messages> messageService)
        {
            _messageService = messageService;
        }

        public void SendMessage()
        {
                _messageService.CheckMessageFileExist();
                Console.WriteLine("Enter user email adress");
                string email = Console.ReadLine();
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    Console.WriteLine("Please enter a subject");
                    string subject = Console.ReadLine();
                    Console.WriteLine("Please enter your message");
                    string message = Console.ReadLine();
                    Console.WriteLine("Please enter message id");
                    string parseId;
                    parseId = Console.ReadLine();
                    Int32.TryParse(parseId, out int id);
                    DateTime createdDateTime = DateTime.Now;
                    if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(subject) && !string.IsNullOrWhiteSpace(message) && id != null)
                    {
                        Console.WriteLine($"Sender's email address: {email}, Subject: {subject}, Message: {message}, Id: {id}, Created Date: {createdDateTime}\r\n");
                        Messages messages = new Messages()
                        {
                            MessageContents = message,
                            Subject = subject,
                            Email = email,
                            CreatedDateTime= createdDateTime,
                            Id=id
                        };
                        _messageService.SendMessage(messages);
                    }
                    else
                    {
                        Console.WriteLine("Values are empty");
                    }
                }
                else
                {
                    Console.WriteLine($"Incorrect email address format entered: {email}");
                }
        }
        public void GetAllMessages()
        {
            _messageService.GetAllMessages();
        }

        public void GetMessageById()
        {
            Console.WriteLine("Enter the id of the message you want to find");
            string parseId = Console.ReadLine();

            if (Int32.TryParse(parseId, out int id))
            {
                Messages message = new Messages()
                {
                    Id = id
                };
                _messageService.GetMessageById(message);
            }
            else
            {
                Console.WriteLine("An incorrect value has been entered");
            }
        }
        public void DeleteMessageFile()
        {
            Console.WriteLine("Are you sure you want to delete the file with users? Yes/No");
            string option = Console.ReadLine().ToLower();
            switch (option)
            {
                case "yes":
                    _messageService.DeleteMessageFile();
                    break;
                case "no":
                    Console.WriteLine("The file was not deleted.\r\n");
                    break;
            }
        }

        public void CreateNewMessageFile()
        {
            _messageService.CreteNewMessageFile();
        }

        public void RemoveMessageById()
        {
            Console.WriteLine("Enter the id of the message you want to delete");
            string parseId = Console.ReadLine();
            if (Int32.TryParse(parseId, out int id))
            {
                Messages message = new Messages()
                {
                    Id = id
                };
                _messageService.RemoveMessageById(message);
                Console.WriteLine("Message deleted successfully");
            }
            else
            {
                Console.WriteLine("An incorrect value has been entered");
            }
        }
    }
}
