using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{
    /// <summary>
    /// Класс хранящий данные о заметках
    /// </summary>
    public class Project
    {
        #region Поля

        /// <summary>
        /// Список заметок.
        /// </summary>
        private List<Note> _notes;

        #endregion


        /// <summary>
        /// Своство заметок.
        /// </summary>
        public List<Note> Notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
            }
        }
    }
}
