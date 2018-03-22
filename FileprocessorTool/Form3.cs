using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileprocessorTool
{
    public partial class Form3 : Form
    {
        private string personalkey;
        private string userName;
        private string password;
        public string Personalkey
        {
            get { return this.personalkey; }
        }
        public string UserName
        {
            get { return userName; }
        }
        public string Password
        {
            get { return password; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName = this.userNametextBox.Text;
            password = this.passwordtextBox.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
