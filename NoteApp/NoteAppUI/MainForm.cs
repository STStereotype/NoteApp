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
    /// Класс главной формы программы.
    /// </summary>
    public partial class MainForm : Form
    {
        private int _heightForm;
        private int _widthForm;
        /// <summary>
        /// Проект, в котором хранятся данные о заметках.
        /// </summary>
        private Project project;
        /// <summary>
        /// Переменная, для посчета, сколько заметок в категории,
        /// с одинакомыми названиями.
        /// </summary>
        private int DuplicateNoteNumber = 0;
        /// <summary>
        /// Создает экземпляр MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            comboBoxCategory.Items.Add(Category.Work);
            comboBoxCategory.Items.Add(Category.Home);
            comboBoxCategory.Items.Add(Category.HealthAndSports);
            comboBoxCategory.Items.Add(Category.People);
            comboBoxCategory.Items.Add(Category.Documents);
            comboBoxCategory.Items.Add(Category.Finance);
            comboBoxCategory.Items.Add(Category.Different);
            comboBoxCategory.SelectedIndex = 0;
            try
            {
                project = ProjectManager.LoadData(ProjectManager.DefaultFilename);
                if (project == null)
                {
                    project = new Project();
                    project.Notes = new List<Note>();
                }
            }
            catch
            {
                project = new Project();
                project.Notes = new List<Note>();
            }

    timer1.Start();
            FillingListBox();
        }

        #region Add Note

        private void ImageAddNote_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        #region Методы добавления заметок

        /// <summary>
        /// Метод создания новой формы AddEditeNote,
        /// для добавления новой заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote()
        {
            LoadingForm(new NoteForm(project), FormStartPosition.CenterParent);
            FillingListBox();
        }

        #endregion

        #endregion

        #region Edit Note

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void ImageEditNote_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        #region методы редактирования заметок

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
                for (int i = 0, j = 1; i < project.Notes.Count; i++)
                {
                    if (project.Notes[i].Name == listBoxNote.SelectedItem.ToString() && DuplicateNoteNumber == j
                        && project.Notes[i].Category == (Category)comboBoxCategory.SelectedItem)
                        LoadingForm(new NoteForm(project, i), FormStartPosition.CenterParent);
                    if (project.Notes[i].Name == listBoxNote.SelectedItem.ToString() && DuplicateNoteNumber + 1 != j
                        && project.Notes[i].Category == (Category)comboBoxCategory.SelectedItem)
                        j++;
                }
                FillingListBox();
            }
            else
            {
                MessageBox.Show("Note not selected");
            }
        }

        #endregion

        #endregion

        #region Remove Note

        private void ImageRemoveNote_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        #region Методы удаления заметок

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
                                                        "? \nThis action is not reversible!",
                                                        "Message",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question); ;
                if (result == DialogResult.OK)
                {
                    for (int i = 0, j = 1; i < project.Notes.Count; i++)
                    {
                        if (project.Notes[i].Name == listBoxNote.SelectedItem.ToString() && DuplicateNoteNumber == j
                            && project.Notes[i].Category == (Category)comboBoxCategory.SelectedItem)
                        {
                            project.Notes.RemoveAt(i);
                            i = project.Notes.Count;
                        }
                        else if (project.Notes[i].Name == listBoxNote.SelectedItem.ToString() && DuplicateNoteNumber + 1 != j
                            && project.Notes[i].Category == (Category)comboBoxCategory.SelectedItem)
                            j++;
                    }
                    ProjectManager.SaveData(project, ProjectManager.DefaultFilename);
                    FillingListBox();
                }
            }
            else
            {
                MessageBox.Show("Note not selected");
            }
        }

        #endregion

        #endregion

        #region Методы

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="form">Загрущаемая форма.</param>
        /// <param name="formStartPosition">Положение формы после загрузки.</param>
        private void LoadingForm(Form form, FormStartPosition formStartPosition)
        {
            form.StartPosition = formStartPosition;
            form.ShowDialog(this);
        }


        /// <summary>
        /// Метод замолнения ListBox заметками,
        /// которые относятся к текущей категории в
        /// comboBoxCategory
        /// </summary>
        private void FillingListBox()
        {
            if (project != null)
            {
                listBoxNote.Items.Clear();
                labelNameCurrentCategory.Text = comboBoxCategory.SelectedItem.ToString();
                for (int i = 0; i < project.Notes.Count; i++)
                {
                    if (project.Notes[i].Category == (Category)comboBoxCategory.SelectedItem)
                    {
                        listBoxNote.Items.Add(project.Notes[i].Name);
                    }
                }
            }
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBoxNote.SelectedItem == null && dateCreation.Visible == true)
            {
                textCurrentNote.Text = "";
                labelNameCurrentNote.Text = "";
                dateCreation.Visible = false;
                dateModifiend.Visible = false;
            }
        }

        private void listBoxNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNote.SelectedItem != null)
            {
                DuplicateNoteNumber = 0;
                labelNameCurrentNote.Text = listBoxNote.SelectedItem.ToString();
                dateCreation.Visible = true;
                dateModifiend.Visible = true;
                for(int i = 0; i < listBoxNote.Items.Count; i++)
                {
                    if(listBoxNote.SelectedItem.ToString() == listBoxNote.Items[i].ToString())
                    {
                        DuplicateNoteNumber++;
                    }
                    if(i == listBoxNote.SelectedIndex)
                    {
                        i = listBoxNote.Items.Count;
                    }
                }
                for (int i = 0, j = 1; i < project.Notes.Count; i++)
                {
                    if (j == DuplicateNoteNumber && project.Notes[i].Name == listBoxNote.SelectedItem.ToString() 
                        && project.Notes[i].Category == (Category)comboBoxCategory.SelectedItem)
                    {
                        dateCreation.Value = project.Notes[i].DateCreation;
                        dateModifiend.Value = project.Notes[i].TimeLastEdit;
                        textCurrentNote.Text = project.Notes[i].TextNote;
                    }
                    if( j != DuplicateNoteNumber + 1 && project.Notes[i].Name == listBoxNote.SelectedItem.ToString()
                        && project.Notes[i].Category == (Category)comboBoxCategory.SelectedItem)
                    {
                        j++;
                    }

                }
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillingListBox();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void listBoxNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveNote();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadingForm(new About(), FormStartPosition.CenterScreen);
        }
    }
}