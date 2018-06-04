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

        private void btnD_Click(object sender, EventArgs e)
        {
            MyNoteEntities7 db = new MyNoteEntities7();
            if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < this.lstNotes.SelectedRows.Count; i++)
                {
                    var row = this.lstNotes.SelectedRows[i];
                    var item = (Note)row.DataBoundItem;
                    try
                    {
                        Note @student = db.Notes.Find(item.id);
                        db.Notes.Remove(@student);
                        db.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete class: " + item);
                    }
                }
            }
            this.ShowNoteList();
        }
    }
}
