using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using Email.App.Database;
using Email.Domain.Entity;


namespace Email.App.Managers
{
    public class UserPresenter
    {
        private DatabaseManager<Messages> _databaseManager;

        public UserPresenter(DatabaseManager<Messages> databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void SendMessage()
        {
            _databaseManager.FileExist();
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
                if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(subject) &&
                    !string.IsNullOrWhiteSpace(message) && id != null)
                {
                    Console.WriteLine(
                        $"Sender's email address: {email}, Subject: {subject}, Message: {message}, Id: {id}, Created Date: {createdDateTime}\r\n");
                    Messages messages = new Messages()
                    {
                        MessageContents = message,
                        Subject = subject,
                        Email = email,
                        CreatedDateTime = createdDateTime,
                        Id = id
                    };
                    _databaseManager.Add(messages);
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
            var messages = _databaseManager.GetAll();

            messages.ForEach(x =>
                Console.WriteLine(
                    $"Email Adress: {x.Email},Subject: {x.Subject} Message: {x.MessageContents}, Send date: {x.CreatedDateTime}, Id: {x.Id}"));
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
                var messageById = _databaseManager.GetById(message);
                messageById.ForEach(x =>
                    Console.WriteLine(
                        $"Email Adress: {x.Email},Subject: {x.Subject} Message: {x.MessageContents}, Send date: {x.CreatedDateTime}, Id: {x.Id}"));
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
                    _databaseManager.DeleteFile();
                    break;
                case "no":
                    Console.WriteLine("The file was not deleted.\r\n");
                    break;
            }
        }

        public void CreateNewMessageFile()
        {
            _databaseManager.FileExist();
        }

        public void RemoveMessageById()
        {
            Console.WriteLine("Enter the id of the message you want to delete");
            string parseId = Console.ReadLine();
            if (Int32.TryParse(parseId, out int id))
            {
                _databaseManager.Delete(id);
                Console.WriteLine("Message deleted successfully");
            }
            else
            {
                Console.WriteLine("An incorrect value has been entered");
            }
        }

        public void MessageUpdateById()
        {
            Console.WriteLine("Enter the id of the message you want to update");
            string parseId = Console.ReadLine();
            if (Int32.TryParse(parseId, out int id)) 
            {
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

                    DateTime updatedDateTime = DateTime.Now;
                    if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(subject) &&
                        !string.IsNullOrWhiteSpace(message) && id != null)
                    {
                        Console.WriteLine(
                            $"Sender's email address: {email}, Subject: {subject}, Message: {message}, Id: {id}, Updated Date: {updatedDateTime}\r\n");
                        Messages messages = new Messages()
                        {
                            MessageContents = message,
                            Subject = subject,
                            Email = email,
                            UpdatedDateTime = updatedDateTime,
                            Id = id
                        };
                        _databaseManager.Update(messages);
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
            else
            {
                Console.WriteLine($"");
            }
        }
    }
}
