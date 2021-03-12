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
    public partial class MainForm : Form
    {
        Note note;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            note.TimeLastEdit = DateTime.MaxValue;
            dateTimePicker1.MinDate = dateTimePicker1.MaxDate = dateTimePicker1.Value = note.TimeLastEdit;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            note = new Note();
            note.DateCreation = DateTime.Now;
            dateTimePicker1.MinDate = dateTimePicker1.MaxDate = dateTimePicker1.Value = note.DateCreation;
        }
    }
}
