using System;

namespace NoteApp
{
    /// <summary>
    /// Класс заметок.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Категория заметки.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _name = "Untitled";

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _textNote = "";

        /// <summary>
        /// Дата и время создания заметки
        /// </summary>
        private DateTime _dateCreation;

        /// <summary>
        /// Дата и время последнего редактирования
        /// </summary>
        private DateTime _timeLastEdit;

        /// <summary>
        /// Конструктор класса Note.
        /// </summary>
        public Note()
        {
            _timeLastEdit = _dateCreation = DateTime.Now;
        }

        /// <summary>
        /// Свойство категории заметки.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set
            { _category = value; }
        }

        /// <summary>
        /// Свойство назнавия заметки.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentException("Note title cannot be empty");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("The number of characters in the title of the notes cannot exceed 50");
                }
                else
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Свойство текста заметки
        /// </summary>
        public string TextNote
        {
            get { return _textNote; }
            set { _textNote = value; }
        }

        /// <summary>
        /// Свойство даты создания заметки.
        /// </summary>
        public DateTime DateCreation
        {
            get { return _dateCreation; }
        }

        /// <summary>
        /// Свойство даты последнего редактирования заметки.
        /// </summary>
        public DateTime TimeLastEdit
        {
            get { return _timeLastEdit; }
            set { _timeLastEdit = DateTime.Now; }
        }

        /// <summary>
        /// Метод интерфейса ICloneable, создание копии заметки
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}