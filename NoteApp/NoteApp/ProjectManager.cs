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
        public static void SaveData(Project project, string nameFile)
        {
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для записи в файл с указанием пути
                using (StreamWriter sw = new StreamWriter(nameFile))
                //environment.getfolderpath
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    //Вызываем сериализацию и передаем объект, который хотим сериализовать
                    serializer.Serialize(writer, project);
                }
        }

        /// <summary>
        /// Метод загрузки данных из файла с расширением json
        /// </summary>
        public static Project LoadData(string nameFile)
        {
            Project project;
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(nameFile))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                project = serializer.Deserialize<Project>(reader);
                }
            return project;
        }
    }
}
