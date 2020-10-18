using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Email.App.Abstract;
using EmailApplication.Domain.Entity;
using Newtonsoft.Json;

namespace Email.App.Common
{
    public class JsonMessagesServices : IMessageService<Messages>
    {
        private string pathMessages =
            @"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\Messages.json";

        public void CheckMessageFileExist()
        {
            if (!File.Exists(pathMessages))
            {
                Console.WriteLine("File not found. Do you want to create it? Yes/No\r\n");
                string option = Console.ReadLine().ToLower();
                switch (option)
                {
                    case "yes":
                        File.Create(pathMessages).Dispose();
                        Console.WriteLine("The file was legally created.");
                        break;
                    case "no":
                        Console.WriteLine("It was not decided to create a new file\r\n");
                        break;
                }
            }
        }

        public void CreteNewMessageFile()
        {
            if (!File.Exists(pathMessages))
            {
                File.Create(pathMessages).Dispose();
                Console.WriteLine("The file was legally created.");
            }
            else
            {
                Console.WriteLine("This file already exists");
            }
        }

        public void DeleteMessageFile()
        {
            if (!File.Exists(pathMessages))
            {
                Console.WriteLine("Message file not found");
            }
            else
            {
                File.Delete(pathMessages);
                Console.WriteLine("The message file has been deleted\r\n");
            }
        }

        public List<Messages> GetAllMessages()
        {
            List<Messages> messagesList;
            using (StreamReader sr = new StreamReader(pathMessages))
            {
                string json = sr.ReadLine();
                messagesList = JsonConvert.DeserializeObject<List<Messages>>(json);
                foreach (Messages message in messagesList)
                {
                    Console.WriteLine($"Email adress: {message.Email} Subject: {message.Subject} User id: {message.Id} Message contents: {message.MessageContents}");
                }
            }
            return messagesList;
        }

        public void GetMessageById(Messages message)
        {
            List<Messages> messagesList;
            using(StreamReader sr = new StreamReader(pathMessages))
            {
                string json = sr.ReadToEnd();
                messagesList = JsonConvert.DeserializeObject<List<Messages>>(json);
                var foundMessage = messagesList.Where(x => x.Id == message.Id).ToList();
                foreach (Messages messages in foundMessage)
                {
                    Console.WriteLine($"Email adress: {messages.Email} Subject: {messages.Subject} User id: {messages.Id} Message contents: {messages.MessageContents} Creation Date: {messages.CreatedDateTime}");
                }
            }
        }

        public int SendMessage(Messages message)
        {
            List<Messages> messagesList;
            using (StreamReader sr=new StreamReader(pathMessages))
            {
                string json = sr.ReadToEnd();
                messagesList = JsonConvert.DeserializeObject<List<Messages>>(json) ?? new List<Messages>();
                messagesList.Add(message);
            }
            File.WriteAllText(pathMessages, JsonConvert.SerializeObject(messagesList));
            return message.Id;
        }

        public void RemoveMessageById(Messages message)
        {
            List<Messages> messageList;
            using (StreamReader sr = new StreamReader(pathMessages))
            {
                string json = sr.ReadToEnd();
                messageList = JsonConvert.DeserializeObject<List<Messages>>(json);
                var userToDelete = messageList.Where(x => x.Id == message.Id).ToList();
                foreach (Messages users in userToDelete)
                {
                    messageList.Remove(users);
                }
            }
            File.WriteAllText(pathMessages, JsonConvert.SerializeObject(messageList));
        }
    }
}
