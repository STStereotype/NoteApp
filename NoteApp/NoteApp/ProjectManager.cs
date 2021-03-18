using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Менеджер проекта.
    /// </summary>
    static public class ProjectManager
    {
        /// <summary>
        /// Путь к сохраняему файлу.
        /// </summary>
        private static string _pathFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "NoteApp.json";

        public static string DefaultFilename 
        { 
            get
            {
                return _pathFile;
            } 
        }

        /// <summary>
        /// Метод сохранения данных в файл с расширением json
        /// </summary>
        public static void SaveData(List<Note> notes, string nameFile)
        {
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для записи в файл с указанием пути
                using (StreamWriter sw = new StreamWriter(nameFile))
                //environment.getfolderpath
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    //Вызываем сериализацию и передаем объект, который хотим сериализовать
                    serializer.Serialize(writer, notes);
                }
        }

        /// <summary>
        /// Метод загрузки данных из файла с расширением json
        /// </summary>
        public static List<Note> LoadData(string nameFile)
        {
            List<Note> notes = null;
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(nameFile))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                    notes = serializer.Deserialize<List<Note>>(reader);
                }
            return notes;
        }
    }
}
