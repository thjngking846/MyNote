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

        private void lstNotes_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstNotes.SelectedRows.Count == 1)
            {
                var row = this.lstNotes.SelectedRows[0];
                var item = (Note)row.DataBoundItem;

                var form = new FormEdit(item);
                form.ShowDialog();
                this.ShowNoteList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.lstNotes.SelectedRows.Count == 1)
            {
                var row = this.lstNotes.SelectedRows[0];
                var item = (Note)row.DataBoundItem;

                var form = new FormEdit(item);
                form.ShowDialog();
                this.ShowNoteList();
            }
        }

        private void dtpS_ValueChanged_1(object sender, EventArgs e)
        {
            MyNoteEntities7 db = new MyNoteEntities7();
            lstNotes.DataSource = db.Notes.Where(x => x.Datetodo == dtpS.Value).ToList();
        }



        private void tbFind_TextChanged(object sender, EventArgs e)
        {
        }
        private void dtpS_ValueChanged(object sender, EventArgs e)
        {
        }
        private void mcS_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

    }
}
