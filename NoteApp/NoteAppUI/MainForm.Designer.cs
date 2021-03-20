namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.listNotes = new System.Windows.Forms.ListBox();
            this.textCurrentNote = new System.Windows.Forms.TextBox();
            this.ImageAddNote = new System.Windows.Forms.PictureBox();
            this.ImageRemoveNote = new System.Windows.Forms.PictureBox();
            this.ImageEditNote = new System.Windows.Forms.PictureBox();
            this.dateCreation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateModifiend = new System.Windows.Forms.DateTimePicker();
            this.labelNameCurrentCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNameCurrentNote = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAddNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRemoveNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageEditNote)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.exitToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.helpToolStripMenuItem1.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(160, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "1"});
            this.comboBoxCategory.Location = new System.Drawing.Point(118, 33);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(180, 24);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // listNotes
            // 
            this.listNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNotes.FormattingEnabled = true;
            this.listNotes.ItemHeight = 16;
            this.listNotes.Location = new System.Drawing.Point(3, 63);
            this.listNotes.Name = "listNotes";
            this.listNotes.Size = new System.Drawing.Size(295, 372);
            this.listNotes.TabIndex = 3;
            // 
            // textCurrentNote
            // 
            this.textCurrentNote.Location = new System.Drawing.Point(310, 117);
            this.textCurrentNote.Multiline = true;
            this.textCurrentNote.Name = "textCurrentNote";
            this.textCurrentNote.Size = new System.Drawing.Size(588, 384);
            this.textCurrentNote.TabIndex = 4;
            // 
            // ImageAddNote
            // 
            this.ImageAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageAddNote.Image = ((System.Drawing.Image)(resources.GetObject("ImageAddNote.Image")));
            this.ImageAddNote.Location = new System.Drawing.Point(6, 471);
            this.ImageAddNote.Name = "ImageAddNote";
            this.ImageAddNote.Size = new System.Drawing.Size(32, 30);
            this.ImageAddNote.TabIndex = 5;
            this.ImageAddNote.TabStop = false;
            // 
            // ImageRemoveNote
            // 
            this.ImageRemoveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageRemoveNote.Image = ((System.Drawing.Image)(resources.GetObject("ImageRemoveNote.Image")));
            this.ImageRemoveNote.Location = new System.Drawing.Point(94, 471);
            this.ImageRemoveNote.Name = "ImageRemoveNote";
            this.ImageRemoveNote.Size = new System.Drawing.Size(32, 30);
            this.ImageRemoveNote.TabIndex = 6;
            this.ImageRemoveNote.TabStop = false;
            // 
            // ImageEditNote
            // 
            this.ImageEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageEditNote.Image = ((System.Drawing.Image)(resources.GetObject("ImageEditNote.Image")));
            this.ImageEditNote.Location = new System.Drawing.Point(50, 471);
            this.ImageEditNote.Name = "ImageEditNote";
            this.ImageEditNote.Size = new System.Drawing.Size(32, 30);
            this.ImageEditNote.TabIndex = 7;
            this.ImageEditNote.TabStop = false;
            // 
            // dateCreation
            // 
            this.dateCreation.Enabled = false;
            this.dateCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCreation.Location = new System.Drawing.Point(383, 90);
            this.dateCreation.Name = "dateCreation";
            this.dateCreation.Size = new System.Drawing.Size(109, 22);
            this.dateCreation.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Created:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modified:";
            // 
            // dateModifiend
            // 
            this.dateModifiend.Enabled = false;
            this.dateModifiend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateModifiend.Location = new System.Drawing.Point(582, 90);
            this.dateModifiend.Name = "dateModifiend";
            this.dateModifiend.Size = new System.Drawing.Size(109, 22);
            this.dateModifiend.TabIndex = 11;
            // 
            // labelNameCurrentCategory
            // 
            this.labelNameCurrentCategory.AutoSize = true;
            this.labelNameCurrentCategory.Location = new System.Drawing.Point(383, 62);
            this.labelNameCurrentCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNameCurrentCategory.Name = "labelNameCurrentCategory";
            this.labelNameCurrentCategory.Size = new System.Drawing.Size(41, 17);
            this.labelNameCurrentCategory.TabIndex = 12;
            this.labelNameCurrentCategory.Text = "Work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category:";
            // 
            // labelNameCurrentNote
            // 
            this.labelNameCurrentNote.AutoSize = true;
            this.labelNameCurrentNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameCurrentNote.Location = new System.Drawing.Point(311, 29);
            this.labelNameCurrentNote.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNameCurrentNote.Name = "labelNameCurrentNote";
            this.labelNameCurrentNote.Size = new System.Drawing.Size(374, 26);
            this.labelNameCurrentNote.TabIndex = 14;
            this.labelNameCurrentNote.Text = "Требования к оформлению кода";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 504);
            this.Controls.Add(this.labelNameCurrentNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNameCurrentCategory);
            this.Controls.Add(this.dateModifiend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateCreation);
            this.Controls.Add(this.ImageEditNote);
            this.Controls.Add(this.ImageRemoveNote);
            this.Controls.Add(this.ImageAddNote);
            this.Controls.Add(this.textCurrentNote);
            this.Controls.Add(this.listNotes);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAddNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRemoveNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageEditNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textCurrentNote;
        private System.Windows.Forms.ListBox listNotes;
        private System.Windows.Forms.PictureBox ImageAddNote;
        private System.Windows.Forms.PictureBox ImageEditNote;
        private System.Windows.Forms.DateTimePicker dateCreation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateModifiend;
        private System.Windows.Forms.Label labelNameCurrentCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNameCurrentNote;
        private System.Windows.Forms.PictureBox ImageRemoveNote;
    }
}

