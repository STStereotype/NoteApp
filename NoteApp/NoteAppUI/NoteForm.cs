using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Класс формы работы с заметками: Редактирование и добавление заметок.
    /// </summary>
    public partial class NoteForm : Form
    {
        #region Переменные
        /// <summary>
        /// Переменная enum добавление и редактирования заметки.
        /// </summary>
        private NoteMode _addOrEdit;
        /// <summary>
        /// переменная списка заметок.
        /// </summary>
        private Project _project;
        /// <summary>
        /// Переменная одной заметки.
        /// </summary>
        private Note _tempNote;
        /// <summary>
        /// Переменная индекса редактируемой заметки.
        /// </summary>
        private int _indexEditNote;

        #endregion

        /// <summary>
        /// Создает экземпляр AddEditNote добавления новой заметки.
        /// </summary>
        /// <param name="project">Прокет, в котором хранятся заметки.</param>
        public NoteForm(Project project)
        {
            InitializeComponent();
            InitializationComboBox();
            _project = project;
            _tempNote = new Note();
            _addOrEdit = NoteMode.Add;
            textBoxNameNote.Text = _tempNote.Name;
        }

        /// <summary>
        /// Создает экземпляр AddEditNote редактирование заметки.
        /// </summary>
        /// <param name="notes">Список заметок, в которой будет изменена заметка.</param>
        /// <param name="indexNote">Индект редактируемой заметки.</param>
        public NoteForm(Project project, int indexNote)
        {
            InitializeComponent();
            InitializationComboBox();
            _indexEditNote = indexNote;
            _project = project;
            _project.Notes = project.Notes;
            _tempNote = (Note)_project.Notes[_indexEditNote].Clone();
            textBoxNameNote.Text = _tempNote.Name;
            comboBoxCategory.SelectedIndex = (int)_tempNote.Category;
            textBoxTextNote.Text = _tempNote.TextNote;
            _addOrEdit = NoteMode.Edit;
        }

        private void textBoxNameNote_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxNameNote.BackColor = Color.LightGreen;
                _tempNote.Name = textBoxNameNote.Text;

            }
            catch 
            {
                textBoxNameNote.BackColor = Color.FromArgb(0xFF, 0x55, 0x55);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                _tempNote.Name = textBoxNameNote.Text;
                if (_addOrEdit == NoteMode.Add)
                    _project.Notes.Add(_tempNote);
                else if (_addOrEdit == NoteMode.Edit)
                    _project.Notes[_indexEditNote] = _tempNote;
                ProjectManager.SaveData(_project, ProjectManager.DefaultFilename);
                Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Input error",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Метод заполнение ComboBoxCategory.
        /// </summary>
        private void InitializationComboBox()
        {
            comboBoxCategory.Items.Add(Category.Work);
            comboBoxCategory.Items.Add(Category.Home);
            comboBoxCategory.Items.Add(Category.HealthAndSports);
            comboBoxCategory.Items.Add(Category.People);
            comboBoxCategory.Items.Add(Category.Documents);
            comboBoxCategory.Items.Add(Category.Finance);
            comboBoxCategory.Items.Add(Category.Different);
            comboBoxCategory.SelectedIndex = 0;
        }

        private void textBoxTextNote_TextChanged(object sender, EventArgs e)
        {
            if (_tempNote != null)
                _tempNote.TextNote = textBoxTextNote.Text;
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_tempNote != null)
                _tempNote.Category = (Category)comboBoxCategory.SelectedItem;
        }

        private void AddEditNote_Load(object sender, EventArgs e)
        {

        }
    }
}
