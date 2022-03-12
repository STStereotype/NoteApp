using System.Collections.Generic;

namespace NoteApp
{
    /// <summary>
    /// Класс хранящий данные о заметках
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Своство заметок.
        /// </summary>
        public List<Note> Notes{ get; set; } = new List<Note>();
    }
}
