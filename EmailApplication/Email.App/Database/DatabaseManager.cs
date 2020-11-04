using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Email.Domain.Common;
using Newtonsoft.Json;

namespace Email.App.Database
{
    public class DatabaseManager<T> where T : BaseEntity
    {
        private readonly string _filePath;
           

        public DatabaseManager()
        {
            _filePath = $@"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApplication\EmailApplication\{typeof(T).Name}.json";
        }

        public int Add(T entity)
        {
            List<T> entityList;
            using (var sr = new StreamReader(_filePath))                                            //StreamReader jest strumieniem, który jest Ci potrzebny żeby jakikolwiek plik przeczytać. To taki mechanizm który pobiera plik bajt po bajcie i daje rady te wszystkie bajty zamienić na string 
            {
                var json = sr.ReadToEnd();                                                    //ReadToEnd=to metoda, która przeczyta cały plik i zamieni go na string (czyli czyta wszystko z sr i zamienia na string json
                entityList = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();         //deserializacja string do swoich obiektów, u mnie Lista<Userów>, ??=jeśli JsonConvertDeserialization będzie nullem to stwórz nową listę User
                entityList.Add(entity);                                                             //dodanie nowego elementu do pliku json
            }
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(entityList));          //zapisuje filePath, zawartością serialozowaną users
            
            return entity.Id;
        }

        public void Delete(T entity)    //Do poprawy. Usuwa wszystko z listy
        {
            List<T> entityList;
            using (var sr = new StreamReader(_filePath))
            {
                var json = sr.ReadToEnd();
                entityList = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
                var toDelete = entityList.Where(x => x.Id == entity.Id).ToList();
                foreach (var item in toDelete)
                {
                    entityList.Remove(item);
                }
                
            }
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(entityList));
        }

        public void Update(T entity)    //Do zrobienia
        {
            List<T> entityList;
            using (var sr = new StreamReader(_filePath))
            {
                var json = sr.ReadToEnd();
                entityList = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
                foreach (var userEdit in entityList)
                {
                    userEdit.Id = entity.Id;
                }
            }
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(entityList));
        }

        public List<T> GetAll()
        {
            List<T> entityList;
            using (var sr = new StreamReader(_filePath))
            {
                var json = sr.ReadLine();
                entityList = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return entityList;
        }
        
        public List<T> GetById(T entity)
        {
            List<T> entityList;
            using (var sr = new StreamReader(_filePath))
            {
                var json = sr.ReadToEnd();
                entityList = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            var userById = entityList.Where(x => x.Id == entity.Id).ToList();
            return userById;
        }

        public void FileExist()    
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Dispose();
                Console.WriteLine("The file has been created but is empty.");
            }
            else
            {
                Console.WriteLine("File exist.");
            }
        }

        public void DeleteFile()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
    }
}
