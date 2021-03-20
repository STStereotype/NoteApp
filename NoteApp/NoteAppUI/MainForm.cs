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
        public MainForm()
        {
            InitializeComponent();
            textCurrentNote.ReadOnly = true;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Project project = new Project();
            ProjectManager.SaveData(project, ProjectManager.DefaultFilename);
            textCurrentNote.Text = ProjectManager.DefaultFilename;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
