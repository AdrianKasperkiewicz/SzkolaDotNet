using System.Collections.Generic;
using System.IO;

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
            using (var sr = new StreamReader(_filePath))                               //StreamReader jest strumieniem, który jest Ci potrzebny żeby jakikolwiek plik przeczytać. To taki mechanizm który pobiera plik bajt po bajcie i daje rady te wszystkie bajty zamienić na string 
            {
                var json = sr.ReadToEnd();                                                   //ReadToEnd=to metoda, która przeczyta cały plik i zamieni go na string (czyli czyta wszystko z sr i zamienia na string json
                entityList = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();     //deserializacja string do swoich obiektów, u mnie Lista<Userów>, ??=jeśli JsonConvertDeserialization będzie nullem to stwórz nową listę User
                entityList.Add(entity);                                                                //dodanie nowego elementu do pliku json
            }
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(entityList));           //zapisuje filePath, zawartością serialozowaną users
            
            return entity.Id;
        }

        public void Delete(T entity)
        {

        }

        public void Update(T entity)
        {
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
        
        public T GetById()
        {
            return null;
        }
    }
}
