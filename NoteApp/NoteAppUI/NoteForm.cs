using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Форма работы с заметками: Редактирование и добавление заметок.
    /// </summary>
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Переменная одной заметки.
        /// </summary>
        private Note _note;
        
        /// <summary>
        /// Словарь ошибок.
        /// </summary>
        private Dictionary<string, string> _errors = new Dictionary<string, string>();

        /// <summary>
        /// Конструктор для добавления новой заметки.
        /// </summary>
        /// <param name="project">Прокет, в котором хранятся заметки.</param>
        public NoteForm(Note note)
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                comboBoxCategory.Items.Add(item);
            }
            comboBoxCategory.SelectedIndex = 0;
            _note = note;
            textBoxNameNote.Text = _note.Name;
            textBoxTextNote.Text = _note.TextNote;
            comboBoxCategory.SelectedItem = _note.Category;
        }

        private void textBoxNameNote_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxNameNote.BackColor = Color.White;
                _note.Name = textBoxNameNote.Text;
                if(_errors.ContainsKey("Note title"))
                {
                    _errors.Remove("Note title");
                }
            }
            catch (Exception ex)
            {
                _errors.TryGetValue("Note title", out var noteError);
                if (!_errors.ContainsKey("Note title"))
                {
                    _errors.Add("Note title", ex.Message);
                }
                else if(noteError != ex.Message)
                {
                    _errors.Remove("Note title");
                    _errors.Add("Note title", ex.Message);
                }
                textBoxNameNote.BackColor = Color.FromArgb(0xFF, 0x55, 0x55);
            }
        }

        private void textBoxTextNote_TextChanged(object sender, EventArgs e)
        {
            if (_note != null)
            {
                _note.TextNote = textBoxTextNote.Text;
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_note != null)
            {
                _note.Category = (Category)comboBoxCategory.SelectedItem;
            }
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_errors.Count == 0)
            {
                _note.TimeLastEdit = DateTime.Now;
            }
            else if(DialogResult == DialogResult.OK)
            {
                _errors.TryGetValue("Note title", out var noteError);
                MessageBox.Show(noteError, "Input error",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}