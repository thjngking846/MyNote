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
    public partial class FormEdit : Form
    {
        public FormEdit(Note @note)
        {
            InitializeComponent();
            this.@note = note;
        }

        private Note @note;

        private void FormEdit_Load(object sender, EventArgs e)
        {
            var db = new MyNoteEntities7();
            this.txTitle.Text = this.@note.title;
            this.txContent.Text = this.@note.notecontent;
            this.dtpDate.Value = (DateTime)this.@note.Datetodo;
            if (this.@note.status == "TODO")
            {
                this.radioButton1.Checked = true;
            }
            if (this.@note.status == "DONE")
            {
                this.radioButton2.Checked = true;
            }
            if (this.@note.status == "MISSED")
            {
                this.radioButton3.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String sStatus = "";
                if (radioButton1.Checked)
                {
                    sStatus = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    sStatus = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    sStatus = radioButton3.Text;
                }

                var db = new MyNoteEntities7();
                var newNote = db.Notes.Find(this.@note.id);
                newNote.title = this.txTitle.Text;
                newNote.notecontent = this.txContent.Text;
                newNote.Datetodo = this.dtpDate.Value;
                newNote.status = sStatus;
                db.Entry(newNote).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
