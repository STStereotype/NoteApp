using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        private Project project;
        private List<Note> _listNotes = new List<Note>();

        public MainForm()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                comboBoxCategory.Items.Add(item);
            }
            comboBoxCategory.SelectedIndex = 0;
            project = ProjectManager.LoadData(ProjectManager.DefaultFilename);

            UpdateListBox();
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
            DeleteNote();
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void listBoxNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteNote();
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void listBoxNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNoteFields();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApplication();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNewForm(new AboutForm(), FormStartPosition.CenterScreen);
        }

        /// <summary>
        /// Метод добавления заметки.
        /// </summary>
        private void AddNote()
        {
            var note = new Note();
            var result = ShowNewForm(new NoteForm(note), FormStartPosition.CenterParent);
            if (result == DialogResult.OK)
            {
                project.Notes.Add(note);
                ProjectManager.SaveData(project, ProjectManager.DefaultFilename);
                UpdateListBox();
            }
        }

        /// <summary>
        /// Метод редактирования заметки.
        /// </summary>
        private void EditNote()
        {
            if (listBoxNote.SelectedItem != null)
            {
                var note = (Note)_listNotes[listBoxNote.SelectedIndex].Clone();
                var result = ShowNewForm(new NoteForm(note), FormStartPosition.CenterParent);
                if (result == DialogResult.OK)
                {
                    var selectedNote = _listNotes[listBoxNote.SelectedIndex];
                    var index = project.Notes.IndexOf(selectedNote);
                    project.Notes[index] = note;
                    ProjectManager.SaveData(project, ProjectManager.DefaultFilename);
                    UpdateListBox();
                }
            }
            else
            {
                MessageBox.Show("Note not selected");
            }
        }

        /// <summary>
        /// Метод удаления заметки.
        /// </summary>
        private void DeleteNote()
        {
            if (listBoxNote.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Remove note: " + listBoxNote.SelectedItem +
                                                        "? \nThis action is not reversible!",
                                                        "Message",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question); ;
                if (result == DialogResult.OK)
                {
                    var selectedNote = _listNotes[listBoxNote.SelectedIndex];
                    var index = project.Notes.IndexOf(selectedNote);
                    project.Notes.RemoveAt(index);
                    ProjectManager.SaveData(project, ProjectManager.DefaultFilename);
                    UpdateListBox();
                }
            }
            else
            {
                MessageBox.Show("Note not selected");
            }
        } 

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="form">Загрущаемая форма.</param>
        /// <param name="formStartPosition">Положение формы после загрузки.</param>
        private DialogResult ShowNewForm(Form form, FormStartPosition formStartPosition)
        {
            form.StartPosition = formStartPosition;
            form.ShowDialog(this);
            return form.DialogResult;
        }

        /// <summary>
        /// Метод обновления списка заметок.
        /// </summary>
        private void UpdateListBox()
        {
            if (project != null)
            {
                listBoxNote.Items.Clear();
                _listNotes.Clear();
                labelNameCurrentCategory.Text = comboBoxCategory.SelectedItem.ToString();
                foreach(Note item in project.Notes)
                {
                    if (item.Category == (Category)comboBoxCategory.SelectedItem)
                    {
                        listBoxNote.Items.Add(item.Name);
                        _listNotes.Add(item);
                    }
                }
                UpdateNoteFields();
            }
        }

        /// <summary>
        /// Метод обновления полей заметки.
        /// </summary>
        private void UpdateNoteFields()
        {
            if (listBoxNote.SelectedItem == null )
            {
                textCurrentNote.Text = labelNameCurrentNote.Text = "";
                dateCreation.Visible = dateModifiend.Visible = false;
            }
            else
            {
                var note =  _listNotes[listBoxNote.SelectedIndex];
                labelNameCurrentNote.Text = note.Name;
                dateCreation.Value = note.DateCreation;
                dateModifiend.Value = note.TimeLastEdit;
                textCurrentNote.Text = note.TextNote;
                dateCreation.Visible = dateModifiend.Visible = true;
            }
        }

        /// <summary>
        /// Метод выхода из приоржения.
        /// </summary>
        private void ExitApplication()
        {
            DialogResult result = MessageBox.Show("Do you really want to finish the job?",
                          "Message",
                          MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                ProjectManager.SaveData(project, ProjectManager.DefaultFilename);
                components.Dispose();
                base.Dispose(true);
            }
        }
    }
}