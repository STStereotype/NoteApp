using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметок.
    /// </summary>
    public class Note : ICloneable
    {

        #region Поля 

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private category _category;
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _name = "";
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

        #endregion

        #region Конструкторы класса

        /// <summary>
        /// Конструктор класса Note.
        /// </summary>
        public Note()
        {
            _timeLastEdit = _dateCreation = DateTime.Now;
        }

        #endregion

        #region Свойства 

        /// <summary>
        /// Свойство категории заметки.
        /// </summary>
        public category Category
        {
            get { return _category; }
            set
            {
                switch (value)
                {
                    case category.Work:
                        {
                            _category = category.Work;
                            break;
                        }
                    case category.Home:
                        {
                            _category = category.Home;
                            break;
                        }
                    case category.HealthAndSports:
                        {
                            _category = category.HealthAndSports;
                            break;
                        }
                    case category.People:
                        {
                            _category = category.People;
                            break;
                        }
                    case category.Documents:
                        {
                            _category = category.Documents;
                            break;
                        }
                    case category.Finance:
                        {
                            _category = category.Finance;
                            break;
                        }
                    case category.Different:
                        {
                            _category = category.Different;
                            break;
                        }
                    default:

                        break;
                }

            }
        }

        /// <summary>
        /// Свойство назнавия заметки.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length < 0)
                {
                    throw new ArgumentException("Название заметки не может быть пустым");
                }
                else if (value.Length < 0)
                {
                    throw new ArgumentException("Колличество символов в заметке не может привышать 50");
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

        public object Clone()
        {
            return MemberwiseClone();
            //Note note = new Note();
            //note.Category = this.Category;
            //return note;
        }

        #endregion

    }
}