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
    /// Класс главной формы программы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Проект, в котором хранятся данные о заметках.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Заметки, которые в данный момент находятся в listBoxNote.
        /// </summary>
        private List<Note> _notes;

        /// <summary>
        /// Создает экземпляр MainForm.
        /// </summary>  
        public MainForm()
        {
            InitializeComponent();
            InitializationComboBox();
            _project = ProjectManager.LoadData(ProjectManager.DefaultFilename);
            FillingListBox();   
        }

        /// <summary>
        /// Метод заполнение ComboBoxCategory.
        /// </summary>
        private void InitializationComboBox()
        {
            var valuesAsList = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
            comboBoxCategory.Items.Add("All");
            foreach (var obj in valuesAsList)
                comboBoxCategory.Items.Add(obj);
            comboBoxCategory.SelectedIndex = 0;
        }

        /// <summary>
        /// Метод удаления заметки,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveNote()
        {
            if (listBoxNote.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Remove note: " + listBoxNote.SelectedItem +
                                                        "?",
                                                        "Message",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question); ;
                if (result == DialogResult.OK)
                {
                    foreach (var note in _project.Notes)
                        if (_notes[listBoxNote.SelectedIndex] == note)
                        {
                            _notes.RemoveAt(listBoxNote.SelectedIndex);
                            _project.Notes.Remove(note);
                            break;
                        }
                    ProjectManager.SaveData(_project, ProjectManager.DefaultFilename);
                    FillingListBox();
                }
            }
            else
            {
                MessageBox.Show("Note not selected");
            }
        }

        /// <summary>
        /// Метод создания новой формы AddEditeNote,
        /// для редактирования заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNote()
        {
            if (listBoxNote.SelectedItem != null)
            {
                foreach (var note in _project.Notes)
                    if (_notes[listBoxNote.SelectedIndex] == note)
                    {
                        LoadingForm(new NoteForm(note));
                        break;
                    }
                FillingListBox();
            }
            else
            {
                MessageBox.Show("Note not selected");
            }
        }

        /// <summary>
        /// Метод создания новой формы AddEditeNote,
        /// для добавления новой заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote()
        {
            Note note = new Note();
            LoadingForm(new NoteForm(note));
            _project.Notes.Add(note);
            FillingListBox();
        }

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="form">Загрущаемая форма.</param>
        private void LoadingForm(Form form)
        {
            form.ShowDialog();
        }

        /// <summary>
        /// Метод замолнения ListBox заметками,
        /// которые относятся к текущей категории в
        /// comboBoxCategory
        /// </summary>
        private void FillingListBox()
        {
            if (_project != null)
            {
                ClearingAllFields();
                listBoxNote.Items.Clear();
                _notes = new List<Note>();
                for (int i = 0; i < _project.Notes.Count; i++)
                {
                    if (comboBoxCategory.SelectedItem.ToString() == "All" || 
                        _project.Notes[i].Category == (Category)comboBoxCategory.SelectedItem)
                    {
                        listBoxNote.Items.Add(_project.Notes[i].Name);
                        _notes.Add(_project.Notes[i]);
                    }
                }
            }
        }

        /// <summary>
        /// Метод очищения всех информационных полей о заметке.
        /// </summary>
        private void ClearingAllFields()
        {
            textCurrentNote.Text = "";
            labelNameCurrentNote.Text = "";
            dateCreation.Visible = false;
            dateModifiend.Visible = false;
        }

        private void listBoxNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note tempNote = new Note();
            if (listBoxNote.SelectedIndex >= 0)
            {
                if (comboBoxCategory.SelectedItem.ToString() == "All")
                {
                    tempNote = _project.Notes[listBoxNote.SelectedIndex];
                }
                else
                {
                    foreach (var note in _project.Notes)
                    {
                        if (_notes[listBoxNote.SelectedIndex] == note)
                        {
                            tempNote = note;
                            break;
                        }
                    }
                }
                labelNameCurrentNote.Text = tempNote.Name;
                textCurrentNote.Text = tempNote.TextNote;
                dateModifiend.Visible = dateCreation.Visible = true;
                dateCreation.Value = tempNote.DateCreation;
                dateModifiend.Value = tempNote.TimeLastEdit;
                labelNameCurrentCategory.Text = Enum.GetName(typeof(Category), tempNote.Category);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillingListBox();
        }

        private void listBoxNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveNote();
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadingForm(new About());
        }

        private void ImageAddNote_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void ImageEditNote_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void ImageRemoveNote_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }
    }
}