using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobProgramming1Final
{
    public partial class NewBookForm : Form
    {

        private MainForm _mainForm;

        public NewBookForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            
        }
    }



}
