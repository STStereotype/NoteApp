﻿using System;
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
        /// <summary>
        /// Редактируемая заметка.
        /// </summary>
        private Note _note;

        /// <summary>
        /// Клон редактируемой заметки.
        /// </summary>
        private Note _tempNote;

        /// <summary>
        /// Создает экземпляр AddEditNote добавления новой заметки.
        /// </summary>
        /// <param name="project">Прокет, в котором хранятся заметки.</param>
        public NoteForm(Note note)
        {
            InitializeComponent();
            InitializationComboBox();
            _note = note;
            _tempNote = (Note)_note.Clone();
            comboBoxCategory.SelectedIndex = (int)_tempNote.Category;
            textBoxNameNote.Text = _tempNote.Name;
            textBoxTextNote.Text = _tempNote.TextNote;
        }

        /// <summary>
        /// Метод заполнение ComboBoxCategory.
        /// </summary>
        private void InitializationComboBox()
        {
            var valuesAsList = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
            foreach (var obj in valuesAsList)
                comboBoxCategory.Items.Add(obj);
            comboBoxCategory.SelectedIndex = 0;
        }

        private void textBoxNameNote_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxNameNote.BackColor = Color.White;
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
                _note.Name = _tempNote.Name;
                _note.TextNote = _tempNote.TextNote;
                _note.Category = _tempNote.Category;
                _note.TimeLastEdit = DateTime.Now;
                Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Input error",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information);
            }
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
