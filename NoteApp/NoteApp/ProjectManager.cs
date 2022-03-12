using System;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Менеджер проекта.
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Путь к сохраняему файлу.
        /// </summary>
        private static readonly string _pathFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp";

        public static readonly string DefaultFilename = _pathFile + "\\NoteApp.json";

        /// <summary>
        /// Метод создания папки.
        /// </summary>
        private static void CreatDirectory()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!System.IO.Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        /// <summary>
        /// Метод сохранения данных в файл с расширением json
        /// </summary>
        public static void SaveData(Project project, string nameFile)
        {
            CreatDirectory();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(nameFile))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }


        /// <summary>
        /// Метод загрузки данных из файла с расширением json
        /// </summary>
        public static Project LoadData(string nameFile)
        {
            Project project;
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamReader sr = new StreamReader(nameFile))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = serializer.Deserialize<Project>(reader);
                }
                return project == null ? new Project() : project;
            }
            catch
            {
                return new Project();
            }
        }
    }
}
