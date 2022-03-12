using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            Author.Text = "Andrey Dozmolin";
            Vecrion.Text = " v.1.0.0";
            linkEmail.Text = "st_stereotype@mail.ru";
            linkGit.Text = "STStereotype/NoteApp.git";
            NameAndDate.Text = "2020 Andrey Dozmolin";
        }

        private void linkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/" + linkGit.Text);
        }

        private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:" + linkEmail.Text);
        }
    }
}
