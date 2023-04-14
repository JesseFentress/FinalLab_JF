namespace FinalLab_JF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foundWordsBox = new System.Windows.Forms.ListBox();
            this.wordsFoundLabel = new System.Windows.Forms.Label();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.assembleMessageBtn = new System.Windows.Forms.Button();
            this.messageCountLbl = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.messageChoiceDrop = new System.Windows.Forms.ComboBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.selectedFileTxt = new System.Windows.Forms.TextBox();
            this.selectedFileLbl = new System.Windows.Forms.Label();
            this.reasembledMessageTxt = new System.Windows.Forms.TextBox();
            this.selectMessageLbl = new System.Windows.Forms.Label();
            this.reasembeledMessageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foundWordsBox
            // 
            this.foundWordsBox.FormattingEnabled = true;
            this.foundWordsBox.ItemHeight = 15;
            this.foundWordsBox.Location = new System.Drawing.Point(373, 70);
            this.foundWordsBox.Name = "foundWordsBox";
            this.foundWordsBox.Size = new System.Drawing.Size(146, 289);
            this.foundWordsBox.TabIndex = 0;
            // 
            // wordsFoundLabel
            // 
            this.wordsFoundLabel.AutoSize = true;
            this.wordsFoundLabel.Location = new System.Drawing.Point(373, 49);
            this.wordsFoundLabel.Name = "wordsFoundLabel";
            this.wordsFoundLabel.Size = new System.Drawing.Size(91, 15);
            this.wordsFoundLabel.TabIndex = 1;
            this.wordsFoundLabel.Text = "Detected Words";
            // 
            // readFileBtn
            // 
            this.readFileBtn.Enabled = false;
            this.readFileBtn.Location = new System.Drawing.Point(189, 156);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(101, 38);
            this.readFileBtn.TabIndex = 2;
            this.readFileBtn.Text = "Read File";
            this.readFileBtn.UseVisualStyleBackColor = true;
            // 
            // assembleMessageBtn
            // 
            this.assembleMessageBtn.Enabled = false;
            this.assembleMessageBtn.Location = new System.Drawing.Point(189, 267);
            this.assembleMessageBtn.Name = "assembleMessageBtn";
            this.assembleMessageBtn.Size = new System.Drawing.Size(101, 38);
            this.assembleMessageBtn.TabIndex = 3;
            this.assembleMessageBtn.Text = "Assemble Message";
            this.assembleMessageBtn.UseVisualStyleBackColor = true;
            this.assembleMessageBtn.Click += new System.EventHandler(this.assembleMessageBtn_Click);
            // 
            // messageCountLbl
            // 
            this.messageCountLbl.AutoSize = true;
            this.messageCountLbl.Location = new System.Drawing.Point(33, 168);
            this.messageCountLbl.Name = "messageCountLbl";
            this.messageCountLbl.Size = new System.Drawing.Size(98, 15);
            this.messageCountLbl.TabIndex = 4;
            this.messageCountLbl.Text = "Message Count : ";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(137, 168);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(13, 15);
            this.countLbl.TabIndex = 5;
            this.countLbl.Text = "0";
            // 
            // messageChoiceDrop
            // 
            this.messageChoiceDrop.Enabled = false;
            this.messageChoiceDrop.FormattingEnabled = true;
            this.messageChoiceDrop.Location = new System.Drawing.Point(29, 276);
            this.messageChoiceDrop.Name = "messageChoiceDrop";
            this.messageChoiceDrop.Size = new System.Drawing.Size(121, 23);
            this.messageChoiceDrop.TabIndex = 6;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(189, 49);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(101, 38);
            this.selectFileBtn.TabIndex = 7;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // selectedFileTxt
            // 
            this.selectedFileTxt.Location = new System.Drawing.Point(33, 58);
            this.selectedFileTxt.Name = "selectedFileTxt";
            this.selectedFileTxt.ReadOnly = true;
            this.selectedFileTxt.Size = new System.Drawing.Size(150, 23);
            this.selectedFileTxt.TabIndex = 9;
            this.selectedFileTxt.Text = "No File Selected";
            // 
            // selectedFileLbl
            // 
            this.selectedFileLbl.AutoSize = true;
            this.selectedFileLbl.Location = new System.Drawing.Point(33, 40);
            this.selectedFileLbl.Name = "selectedFileLbl";
            this.selectedFileLbl.Size = new System.Drawing.Size(78, 15);
            this.selectedFileLbl.TabIndex = 10;
            this.selectedFileLbl.Text = "Selected File :";
            // 
            // reasembledMessageTxt
            // 
            this.reasembledMessageTxt.Location = new System.Drawing.Point(33, 390);
            this.reasembledMessageTxt.Name = "reasembledMessageTxt";
            this.reasembledMessageTxt.ReadOnly = true;
            this.reasembledMessageTxt.Size = new System.Drawing.Size(486, 23);
            this.reasembledMessageTxt.TabIndex = 11;
            // 
            // selectMessageLbl
            // 
            this.selectMessageLbl.AutoSize = true;
            this.selectMessageLbl.Location = new System.Drawing.Point(29, 258);
            this.selectMessageLbl.Name = "selectMessageLbl";
            this.selectMessageLbl.Size = new System.Drawing.Size(102, 15);
            this.selectMessageLbl.TabIndex = 12;
            this.selectMessageLbl.Text = "Select a Message :";
            // 
            // reasembeledMessageLbl
            // 
            this.reasembeledMessageLbl.AutoSize = true;
            this.reasembeledMessageLbl.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.reasembeledMessageLbl.Location = new System.Drawing.Point(33, 372);
            this.reasembeledMessageLbl.Name = "reasembeledMessageLbl";
            this.reasembeledMessageLbl.Size = new System.Drawing.Size(138, 15);
            this.reasembeledMessageLbl.TabIndex = 13;
            this.reasembeledMessageLbl.Text = "Re-Assembeled Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.reasembeledMessageLbl);
            this.Controls.Add(this.selectMessageLbl);
            this.Controls.Add(this.reasembledMessageTxt);
            this.Controls.Add(this.selectedFileLbl);
            this.Controls.Add(this.selectedFileTxt);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.messageChoiceDrop);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.messageCountLbl);
            this.Controls.Add(this.assembleMessageBtn);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.wordsFoundLabel);
            this.Controls.Add(this.foundWordsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox foundWordsBox;
        private Label wordsFoundLabel;
        private Button readFileBtn;
        private Button assembleMessageBtn;
        private Label messageCountLbl;
        private Label countLbl;
        private ComboBox messageChoiceDrop;
        private Button selectFileBtn;
        private TextBox selectedFileTxt;
        private Label selectedFileLbl;
        private TextBox reasembledMessageTxt;
        private Label selectMessageLbl;
        private Label reasembeledMessageLbl;
    }
}