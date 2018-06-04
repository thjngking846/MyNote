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

        
    }
}
