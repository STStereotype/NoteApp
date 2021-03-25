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
        private Category _category;
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _name = "Без названия";
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
        public Category Category
        {
            get { return _category; }
            set
            {
                switch (value)
                {
                    case Category.Work:
                        {
                            _category = Category.Work;
                            break;
                        }
                    case Category.Home:
                        {
                            _category = Category.Home;
                            break;
                        }
                    case Category.HealthAndSports:
                        {
                            _category = Category.HealthAndSports;
                            break;
                        }
                    case Category.People:
                        {
                            _category = Category.People;
                            break;
                        }
                    case Category.Documents:
                        {
                            _category = Category.Documents;
                            break;
                        }
                    case Category.Finance:
                        {
                            _category = Category.Finance;
                            break;
                        }
                    case Category.Different:
                        {
                            _category = Category.Different;
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
                if(value.Length == 0)
                {
                    throw new ArgumentException("Название заметки не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Количество символов в названии заметкм не может превышать 50");
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

        #endregion

    }
}