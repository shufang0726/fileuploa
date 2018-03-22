namespace FileprocessorTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChampaignName = new System.Windows.Forms.Label();
            this.champaignNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Audience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Characters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.LanguagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.languagecheckBox = new System.Windows.Forms.CheckBox();
            this.IndianCheckbox = new System.Windows.Forms.CheckBox();
            this.standardCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LanguagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChampaignName
            // 
            this.ChampaignName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChampaignName.AutoSize = true;
            this.ChampaignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChampaignName.Location = new System.Drawing.Point(19, 21);
            this.ChampaignName.Name = "ChampaignName";
            this.ChampaignName.Size = new System.Drawing.Size(107, 13);
            this.ChampaignName.TabIndex = 0;
            this.ChampaignName.Text = "Champaign name:";
            // 
            // champaignNameTextBox
            // 
            this.champaignNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.champaignNameTextBox.Location = new System.Drawing.Point(22, 49);
            this.champaignNameTextBox.Name = "champaignNameTextBox";
            this.champaignNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.champaignNameTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Audience,
            this.Description,
            this.Copy,
            this.Characters,
            this.CTA});
            this.dataGridView1.Location = new System.Drawing.Point(31, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(728, 224);
            this.dataGridView1.TabIndex = 5;
            // 
            // Audience
            // 
            this.Audience.HeaderText = "Audience";
            this.Audience.Name = "Audience";
            // 
            // Description
            // 
            this.Description.HeaderText = "Descriptioin";
            this.Description.Name = "Description";
            // 
            // Copy
            // 
            this.Copy.HeaderText = "Copy";
            this.Copy.Name = "Copy";
            // 
            // Characters
            // 
            this.Characters.HeaderText = "Characters";
            this.Characters.Name = "Characters";
            this.Characters.ReadOnly = true;
            // 
            // CTA
            // 
            this.CTA.HeaderText = "CTA Drivring To";
            this.CTA.Name = "CTA";
            // 
            // Submitbutton
            // 
            this.Submitbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Submitbutton.Location = new System.Drawing.Point(677, 426);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(75, 23);
            this.Submitbutton.TabIndex = 6;
            this.Submitbutton.Text = "Submit";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // LanguagePanel
            // 
            this.LanguagePanel.AutoScroll = true;
            this.LanguagePanel.ColumnCount = 2;
            this.LanguagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.15068F));
            this.LanguagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.84932F));
            this.LanguagePanel.Controls.Add(this.label1, 1, 0);
            this.LanguagePanel.Controls.Add(this.label2, 0, 0);
            this.LanguagePanel.Location = new System.Drawing.Point(271, 12);
            this.LanguagePanel.Name = "LanguagePanel";
            this.LanguagePanel.RowCount = 1;
            this.LanguagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LanguagePanel.Size = new System.Drawing.Size(365, 153);
            this.LanguagePanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Exception Markets to exclude";
            // 
            // languagecheckBox
            // 
            this.languagecheckBox.AutoSize = true;
            this.languagecheckBox.Location = new System.Drawing.Point(652, 114);
            this.languagecheckBox.Name = "languagecheckBox";
            this.languagecheckBox.Size = new System.Drawing.Size(88, 17);
            this.languagecheckBox.TabIndex = 8;
            this.languagecheckBox.Tag = "language";
            this.languagecheckBox.Text = "All Language";
            this.languagecheckBox.UseVisualStyleBackColor = true;
            this.languagecheckBox.Click += new System.EventHandler(this.languagecheckBox_Click);
            // 
            // IndianCheckbox
            // 
            this.IndianCheckbox.AutoSize = true;
            this.IndianCheckbox.Location = new System.Drawing.Point(652, 36);
            this.IndianCheckbox.Name = "IndianCheckbox";
            this.IndianCheckbox.Size = new System.Drawing.Size(106, 17);
            this.IndianCheckbox.TabIndex = 11;
            this.IndianCheckbox.Text = "Indian Language";
            this.IndianCheckbox.UseVisualStyleBackColor = true;
            this.IndianCheckbox.Click += new System.EventHandler(this.IndianCheckbox_Click);
            // 
            // standardCheckbox
            // 
            this.standardCheckbox.AutoSize = true;
            this.standardCheckbox.Location = new System.Drawing.Point(652, 77);
            this.standardCheckbox.Name = "standardCheckbox";
            this.standardCheckbox.Size = new System.Drawing.Size(120, 17);
            this.standardCheckbox.TabIndex = 12;
            this.standardCheckbox.Text = "Standard Language";
            this.standardCheckbox.UseVisualStyleBackColor = true;
            this.standardCheckbox.Click += new System.EventHandler(this.standardCheckbox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 448);
            this.Controls.Add(this.languagecheckBox);
            this.Controls.Add(this.standardCheckbox);
            this.Controls.Add(this.IndianCheckbox);
            this.Controls.Add(this.LanguagePanel);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.champaignNameTextBox);
            this.Controls.Add(this.ChampaignName);
            this.Name = "Form1";
            this.Text = "SkypeRichTextInput";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LanguagePanel.ResumeLayout(false);
            this.LanguagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChampaignName;
        private System.Windows.Forms.TextBox champaignNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Audience;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Characters;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTA;
        private System.Windows.Forms.TableLayoutPanel LanguagePanel;
        private System.Windows.Forms.CheckBox languagecheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IndianCheckbox;
        private System.Windows.Forms.CheckBox standardCheckbox;
        private System.Windows.Forms.Label label2;
    }
}

