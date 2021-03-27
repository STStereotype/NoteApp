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
        private static string _pathFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.json";

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
            CreatedDirectory();
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
            try
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
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException("Invalid file path", ex);
            }
            catch(FileNotFoundException ex)
            {
                throw new FileNotFoundException("File not found", ex);
            }
            catch(JsonReaderException ex)
            {
                throw new JsonReaderException("The file is corrupted", ex);
            }
        }

        private static void CreatedDirectory()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp";
            if (!System.IO.Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
