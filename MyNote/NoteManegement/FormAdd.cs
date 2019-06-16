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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            var db = new MyNoteEntities7();
            radioButton1.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
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

            Note @note = new Note();
            @note.title = this.txTitle.Text;
            @note.notecontent = this.txContent.Text;
            @note.Datetodo = this.dtpDate.Value;
            @note.status = sStatus;
            try
            {
                var db = new MyNoteEntities7();
                db.Notes.Add(@note);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //comment demo here OK
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
