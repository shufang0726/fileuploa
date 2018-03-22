using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FileprocessorTool
{

    public partial class Form1 : Form
    {
        private string chName;
        private List<string> checkedLanguage = new List<string>();
        private List<string> exceptionMarket = new List<string>();
        private List<string> audience = new List<string>();
        private List<string> description = new List<string>();
        private List<string> copy = new List<string>();
        private List<int> characters = new List<int>();
        private List<string> cTA = new List<string>();

        public string ChName
        {
            get { return this.chName; }
        }
        public List<string> CheckedLanguage
        {
            get { return this.checkedLanguage; }
        }
        public List<string> ExceptionMarket
        {
            get { return this.exceptionMarket; }
        }
        public List<string> Aud
        {
            get { return this.audience; }
        }
        public List<string> Des
        {
            get { return this.description; }
        }
        public List<string> Cop
        {
            get { return this.copy; }
        }
        public List<int> Cha
        {
            get { return this.characters; }
        }
        public List<string> CTAs
        {
            get { return this.cTA; }
        }

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            drawLanguagePanel();
        }

        private void drawLanguagePanel()
        {
            CheckBox Encheck = new CheckBox();
            TextBox Entextbox = new TextBox();
            Encheck.AutoSize = true;
            Encheck.Name = "en-US";
            Encheck.Text = "en-US";
            Encheck.Tag = "standardLanguage";
            Encheck.Size = new Size(270, 17);
            Entextbox.Size = new Size(193, 17);
            Entextbox.Text = "";
            Entextbox.Tag = "en-US";
            Entextbox.Multiline = true;
            this.LanguagePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.LanguagePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.LanguagePanel.Controls.Add(Encheck, 0, 1);
            this.LanguagePanel.Controls.Add(Entextbox, 1, 1);

            Language language = new Language();
            for (var i = 0; i < language.standardLanguage.Length; i++)
            {
                this.LanguagePanel.RowCount++;
                CheckBox check = new CheckBox();
                TextBox textbox = new TextBox();
                check.AutoSize = true;
                check.Name = language.standardLanguage[i];
                check.Text = language.standardLanguage[i];
                check.Tag = "standardLanguage";
                check.Size = new Size(270, 17);
                textbox.Size = new Size(193, 17);
                textbox.Text = "";
                textbox.Tag = check.Name;
                textbox.Multiline = true;
                this.LanguagePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                this.LanguagePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                this.LanguagePanel.Controls.Add(check, 0, i + 2);
                this.LanguagePanel.Controls.Add(textbox, 1, i + 2);

            }
            for (var i = language.standardLanguage.Length; i < language.standardLanguage.Length + language.IndiaLanguage.Length; i++)
            {
                this.LanguagePanel.RowCount++;
                CheckBox check1 = new CheckBox();
                TextBox textbox1 = new TextBox();
                check1.Name = language.IndiaLanguage[i - language.standardLanguage.Length];
                check1.Text = language.IndiaLanguage[i - language.standardLanguage.Length];
                check1.Tag = "IndianLanguage";
                check1.Size = new Size(193, 17);
                textbox1.Size = new Size(193, 17);
                textbox1.Text = "";
                textbox1.Tag = check1.Name;
                this.LanguagePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                this.LanguagePanel.Controls.Add(check1, 0, i + 2);
                this.LanguagePanel.Controls.Add(textbox1, 1, i + 2);

            }

        }
        public bool getcheckedLanguage()
        {
            checkedLanguage.Clear();
            var result = false;

            foreach (Control ck in LanguagePanel.Controls)
            {
                if (ck is CheckBox)
                {
                    if (((CheckBox)ck).Checked == true && ((CheckBox)ck).Tag != "language")
                    {
                        checkedLanguage.Add(ck.Text);
                        result = true;
                    }
                }
                else
                {
                    continue;
                }
            }
            return result;
        }
        public void getExceptionMarket()
        {
            exceptionMarket.Clear();
            foreach (Control tb in LanguagePanel.Controls)
            {
                if (tb is TextBox)
                {
                    foreach (Control ck in LanguagePanel.Controls)
                    {
                        if (ck is CheckBox)
                        {
                            if (((CheckBox)ck).Name == tb.Tag && ((CheckBox)ck).Checked)
                            {
                                exceptionMarket.Add(ck.Name + ":" + tb.Text);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }

        }
        private void getRecordFromGridView()
        {
            audience.Clear();
            description.Clear();
            copy.Clear();
            cTA.Clear();
            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
            {

                if (this.dataGridView1[0, i].Value == null)
                {
                    audience.Add("Nullstring");
                }
                else
                {
                    audience.Add(this.dataGridView1[0, i].Value.ToString());
                }
                if (this.dataGridView1[1, i].Value == null)
                {
                    description.Add("null");
                }
                else
                {
                    description.Add(this.dataGridView1[1, i].Value.ToString());
                }
                if (this.dataGridView1[2, i].Value == null)
                {
                    copy.Add("null");
                }
                else
                {
                    copy.Add(this.dataGridView1[2, i].Value.ToString());
                    characters.Add(this.dataGridView1[2, i].Value.ToString().Length);
                }
                if (this.dataGridView1[4, i].Value == null)
                {
                    cTA.Add("null");
                }
                else
                {
                    cTA.Add(this.dataGridView1[4, i].Value.ToString());
                }
            }

        }
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            chName = this.champaignNameTextBox.Text.ToString();
            getRecordFromGridView();

            if (chName == null || chName == "")
            {
                MessageBox.Show("Error:Champaingn Name cannot be null", "Error", MessageBoxButtons.OK);
            }
            else if (copy.Contains("null"))
            {
                MessageBox.Show("Error:Copy cannot be null", "Error", MessageBoxButtons.OK);
            }
            else if (!getcheckedLanguage())
            {
                MessageBox.Show("Error:You must choose at least one language", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Form2 form = new Form2();
                form.Owner = this;
                form.Show();
            }
        }

        private void languagecheckBox_Click(object sender, EventArgs e)
        {
            if (languagecheckBox.CheckState == CheckState.Checked)
            {
                foreach (Control ck in LanguagePanel.Controls)
                {
                    if (ck is CheckBox)
                    {
                        ((CheckBox)ck).Checked = true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                foreach (Control ck in LanguagePanel.Controls)
                {
                    if (ck is CheckBox)
                    {
                        ((CheckBox)ck).Checked = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }

        private void IndianCheckbox_Click(object sender, EventArgs e)
        {
            foreach (Control ck in LanguagePanel.Controls)
            {
                if (ck is CheckBox && ((CheckBox)ck).Tag == "IndianLanguage")
                {
                    if (!IndianCheckbox.Checked)
                    {
                        ((CheckBox)ck).Checked = false;

                    }
                    else
                    {
                        ((CheckBox)ck).Checked = true;

                    }
                }
                else
                {
                    continue;
                }
            }
        }

        private void standardCheckbox_Click(object sender, EventArgs e)
        {
            foreach (Control ck in LanguagePanel.Controls)
            {
                if (ck is CheckBox && ((CheckBox)ck).Tag == "standardLanguage")
                {
                    if (!standardCheckbox.Checked)
                    {
                        ((CheckBox)ck).Checked = false;

                    }
                    else
                    {
                        ((CheckBox)ck).Checked = true;

                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
