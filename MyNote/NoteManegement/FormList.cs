using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNote.NoteManegement
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            this.ShowNoteList();
        }

        private void ShowNoteList()
        {
            MyNoteEntities7 db = new MyNoteEntities7();
            this.lstNotes.DataSource = db.Notes.ToList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAdd();
            form.ShowDialog();
            this.ShowNoteList();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNoteList();
        }


    }
}
