using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;

namespace FileprocessorTool
{
    public partial class Form2 : Form
    {
        const String c_collectionUri = @"https://skype.visualstudio.com";
        const String c_projectName = "SCONSUMER";
        const String c_repoName = "async_messaging_engagementtranslations";
        private List<string> checklang = new List<string>();
        private List<string> exceMark = new List<string>();
        private List<string> aud = new List<string>();
        private List<string> des = new List<string>();
        private List<string> cop = new List<string>();
        private List<string> cta = new List<string>();


        public bool flag = false;
        public Form2()
        {
            InitializeComponent();

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.ChampaignNamelabel1.Text = "";
            Form1 pareForm = (Form1)this.Owner;
            //pareForm.getcheckedLanguage();
            pareForm.getExceptionMarket();
            this.ChampaignNamelabel1.Text = pareForm.ChName;
            checklang = pareForm.CheckedLanguage;
            exceMark = pareForm.ExceptionMarket;
            aud = pareForm.Aud;
            des = pareForm.Des;
            cop = pareForm.Cop;
            cta = pareForm.CTAs;
            writeLanguage();
            writeRecord();

        }
        private void writeRecord()
        {
            for (var c = 0; c < cop.Count; c++)
            {
                this.tableLayoutPanel1.RowCount++;
                Label Audlabel = new Label();
                Label deslabel = new Label();
                Label copLabel = new Label();
                Label chaLabel = new Label();
                Label ctaLabel = new Label();
                Audlabel.AutoSize = true;
                Audlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                Audlabel.Name = "Audiencelabel" + c;
                Audlabel.Size = new System.Drawing.Size(52, 17);
                Audlabel.TabIndex = 0;
                Audlabel.Text = aud[c];
                deslabel.AutoSize = true;
                deslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                deslabel.Name = "descriptionlabel" + c;
                deslabel.Size = new System.Drawing.Size(52, 17);
                deslabel.TabIndex = 0;
                deslabel.Text = des[c];
                copLabel.AutoSize = true;
                copLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                copLabel.Name = "copylabel" + c;
                copLabel.Size = new System.Drawing.Size(52, 17);
                copLabel.TabIndex = 0;
                copLabel.Text = cop[c];
                chaLabel.AutoSize = true;
                chaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                chaLabel.Name = "characterlabel" + c;
                chaLabel.Size = new System.Drawing.Size(52, 17);
                chaLabel.TabIndex = 0;
                chaLabel.Text = cop[c].Length.ToString();
                ctaLabel.AutoSize = true;
                ctaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                ctaLabel.Name = "ctalabel" + c;
                ctaLabel.Size = new System.Drawing.Size(52, 17);
                ctaLabel.TabIndex = 0;
                ctaLabel.Text = cta[c];
                this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                this.tableLayoutPanel1.Controls.Add(Audlabel, 0, c + 1);
                this.tableLayoutPanel1.Controls.Add(deslabel, 1, c + 1);
                this.tableLayoutPanel1.Controls.Add(copLabel, 2, c + 1);
                this.tableLayoutPanel1.Controls.Add(chaLabel, 3, c + 1);
                this.tableLayoutPanel1.Controls.Add(ctaLabel, 4, c + 1);
            }
        }

        private void writeLanguage()
        {
            for (var i = 0; i < checklang.Count; i++)
            {
                this.LanguagePanel.RowCount++;
                Label lalabel = new Label();
                Label delabel = new Label();
                lalabel.AutoSize = true;
                lalabel.Name = checklang[i];
                lalabel.Text = checklang[i];
                lalabel.Size = new Size(193, 23);
                for (var a = 0; a < exceMark.Count; a++)
                {
                    string[] sname = exceMark[a].Split(':');
                    if (lalabel.Name == sname[0])
                    {
                        delabel.AutoSize = true;
                        delabel.Text = sname[1];
                        delabel.Size = new Size(193, 23);
                        this.LanguagePanel.Controls.Add(delabel, 1, i + 1);
                    }
                }
                this.LanguagePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                this.LanguagePanel.Controls.Add(lalabel, 0, i + 1);

            }
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            uploadFile();
            this.Close();
           
        }
        private string writeToXml()
        {
            string xmlString;
            xmlString = @"<?xml version='1.0' encoding='UTF-8'?>" + Environment.NewLine + @"<Root>" + Environment.NewLine;
            xmlString += @"<CampaignName name=" + "\"" + ChampaignNamelabel1.Text + "\"" + @"/>" + Environment.NewLine;
            xmlString += @"<MarketReference>" + Environment.NewLine;
            for (var i = 0; i < checklang.Count; i++)
            {
                string[] sname = exceMark[i].Split(':');
                xmlString += @"<Language name=" + "\"" + checklang[i] + "\"" + " exceptionMarkets=" + "\"" + sname[1] + "\"" + @"/>" + Environment.NewLine;
            }
            xmlString += @"</MarketReference>" + Environment.NewLine + @"</Root>";
            return xmlString;
        }
        private string writeToJson()
        {

            List<string> copylist = aud;
            //check if audience is duplicated,

            for (var a = 0; a < aud.Count; a++)
            {
                for (var b = a + 1; b < aud.Count; b++)
                {

                    if (aud[a] == aud[b])
                    {
                        aud[b] = aud[b] + "_" + (b - a);
                    }

                }

            }

            string jsonstr = "{" + Environment.NewLine + "\"" + ChampaignNamelabel1.Text + "\":{" + Environment.NewLine;
            for (var i = 0; i < cop.Count; i++)
            {
                string recordstr;
                if (i == cop.Count - 1 && des[i] == "null")
                {
                    jsonstr += "\"" + aud[i] + "\":\"" + cop[i] + "\"" + Environment.NewLine;

                }
                else
                {
                    jsonstr += "\"" + aud[i] + "\":\"" + cop[i] + "\"," + Environment.NewLine;

                }

                if (des[i] == "null")
                {

                    continue;
                }
                else
                {
                    jsonstr += "\"_" + aud[i] + ".comment\":\"" + des[i] + "\"," + Environment.NewLine;
                    if (i == cop.Count - 1)
                    {
                        jsonstr += "\"_" + aud[i] + ".comment\":\"" + des[i] + "\"" + Environment.NewLine;
                    }
                    // sw.Write(str);
                }
            }
            jsonstr += "}" + Environment.NewLine + "}";
            return jsonstr;
        }

      
        private void uploadFile(string userName,string password)
        {
 
                NetworkCredential netCred = new NetworkCredential(userName, password);
                WindowsCredential winCred = new WindowsCredential(netCred);
                VssCredentials creds = new VssClientCredentials(winCred);
                creds.Storage = new VssClientCredentialStorage();


                // Connect to VSTS
                VssConnection connection = new VssConnection(new Uri(c_collectionUri), creds);

                // Get a GitHttpClient to talk to the Git endpoints
                GitHttpClient gitClient = connection.GetClient<GitHttpClient>();

                // Get data about a specific repository
                var repo = gitClient.GetRepositoryAsync(c_projectName, c_repoName).GetAwaiter().GetResult();


                GitRef branch = gitClient.GetRefsAsync(repo.Id, filter: "heads/OfficeMarketing").GetAwaiter().GetResult().First();
                GitRefUpdate refUpdate = new GitRefUpdate()
                {
                    Name = $"refs/heads/OfficeMarketing",
                    OldObjectId = branch.ObjectId,
                };
                GitCommitRef newCommit = new GitCommitRef()
                {
                    Comment = "add Json and xml file",
                    Changes = new GitChange[]
                  {
                    new GitChange()
                    {
                        ChangeType = VersionControlChangeType.Add,
                        Item = new GitItem() {Path = $"IRIS/Chatbot/Source/"+ChampaignNamelabel1.Text+"/"+ChampaignNamelabel1.Text+".en-US.json" },
                        NewContent = new ItemContent()
                        {
                            Content = writeToJson(),
                            ContentType = ItemContentType.RawText,
                        }
                    },
                    new GitChange()
                    {
                        ChangeType = VersionControlChangeType.Add,
                        Item = new GitItem() {Path = $"IRIS/Chatbot/Source/"+ChampaignNamelabel1.Text+"/ExceptionMarketReference.xml" },
                        NewContent = new ItemContent()
                        {
                            Content = writeToXml(),
                            ContentType = ItemContentType.RawText,
                        }
                    }
                  },
                };
                // create the push with the new branch and commit
                GitPush push = gitClient.CreatePushAsync(new GitPush()

                {

                    RefUpdates = new GitRefUpdate[] { refUpdate },

                    Commits = new GitCommitRef[] { newCommit },

                }, repo.Id).GetAwaiter().GetResult();                
        }
        private void uploadFile()
        {
            try
            {

                //VssCredentials creds = new VssClientCredentials();
                //creds.Storage = new VssClientCredentialStorage();
                 VssBasicCredential creds = new VssBasicCredential(@"fareast\v-shgao", @"2wsx@WSX");

                // Connect to VSTS
                VssConnection connection = new VssConnection(new Uri(c_collectionUri), creds);

                // Get a GitHttpClient to talk to the Git endpoints
                GitHttpClient gitClient = connection.GetClient<GitHttpClient>();

                // Get data about a specific repository
                var repo = gitClient.GetRepositoryAsync(c_projectName, c_repoName).GetAwaiter().GetResult();
                GitRef branch = gitClient.GetRefsAsync(repo.Id, filter: "heads/OfficeMarketing").GetAwaiter().GetResult().First();
                GitRefUpdate refUpdate = new GitRefUpdate()
                {
                    Name = $"refs/heads/OfficeMarketing",
                    OldObjectId = branch.ObjectId,
                };
                GitCommitRef newCommit = new GitCommitRef()
                {
                    Comment = "add Json and xml file",
                    Changes = new GitChange[]
                   {
                    new GitChange()
                    {
                        ChangeType = VersionControlChangeType.Add,
                        Item = new GitItem() {Path = $"IRIS/Chatbot/Source/"+ChampaignNamelabel1.Text+"/"+ChampaignNamelabel1.Text+".en-US.json" },
                        NewContent = new ItemContent()
                        {
                            Content = writeToJson(),
                            ContentType = ItemContentType.RawText,
                        }
                    },
                    new GitChange()
                    {
                        ChangeType = VersionControlChangeType.Add,
                        Item = new GitItem() {Path = $"IRIS/Chatbot/Source/"+ChampaignNamelabel1.Text+"/ExceptionMarketReference.xml" },
                        NewContent = new ItemContent()
                        {
                            Content = writeToXml(),
                            ContentType = ItemContentType.RawText,
                        }
                    }
                   },
                };
                // create the push with the new branch and commit
                GitPush push = gitClient.CreatePushAsync(new GitPush()

                {

                    RefUpdates = new GitRefUpdate[] { refUpdate },

                    Commits = new GitCommitRef[] { newCommit },

                }, repo.Id).GetAwaiter().GetResult();
               
            }
            catch (VssUnauthorizedException e)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                if (f3.DialogResult == DialogResult.OK)
                {
                    try {
                        uploadFile(f3.UserName, f3.Password);
                        MessageBox.Show("Upload Successfully");
                    } 
                   catch(Exception ex)
                    {
                        MessageBox.Show("Upload Fail:"+ex.Message);
                    }
                }

            }

            catch (Exception ex)
            {
                
                MessageBox.Show("UpLoad Fail:"+ex.Message);
                
            }
            
        }
      

    }
}
