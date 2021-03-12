using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{
    class Project
    {

        #region Поля

        /// <summary>
        /// Список заметок.
        /// </summary>
        private List<Note> _note;

        #endregion

        #region Методы

        /// <summary>
        /// Метод добавления заметки.
        /// </summary>
        /// <param name="category">Категория заметки.</param>
        /// <param name="nameNote">Название заметки.</param>
        /// <param name="textNote">Текст заметки.</param>
        public void AddNote(category category, string nameNote, string textNote)
        {
            var tempNote = new Note();
            tempNote.Category = category;
            tempNote.Name = nameNote;
            tempNote.TextNote = textNote;
            _note.Add(tempNote);
        }

        /// <summary>
        /// Метод удаления заметки.
        /// </summary>
        public void RemoveNote()
        {
            _note.RemoveAt(0);
        }

        #endregion

    }
}
