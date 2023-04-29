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
            foundWordsBox = new ListBox();
            wordsFoundLabel = new Label();
            readFileBtn = new Button();
            assembleMessageBtn = new Button();
            messageCountLbl = new Label();
            countLbl = new Label();
            messageChoiceDrop = new ComboBox();
            selectFileBtn = new Button();
            selectedFileTxt = new TextBox();
            selectedFileLbl = new Label();
            reasembledMessageTxt = new TextBox();
            selectMessageLbl = new Label();
            reasembeledMessageLbl = new Label();
            SuspendLayout();
            // 
            // foundWordsBox
            // 
            foundWordsBox.FormattingEnabled = true;
            foundWordsBox.ItemHeight = 15;
            foundWordsBox.Location = new Point(373, 70);
            foundWordsBox.Name = "foundWordsBox";
            foundWordsBox.Size = new Size(146, 289);
            foundWordsBox.TabIndex = 0;
            // 
            // wordsFoundLabel
            // 
            wordsFoundLabel.AutoSize = true;
            wordsFoundLabel.Location = new Point(373, 49);
            wordsFoundLabel.Name = "wordsFoundLabel";
            wordsFoundLabel.Size = new Size(91, 15);
            wordsFoundLabel.TabIndex = 1;
            wordsFoundLabel.Text = "Detected Words";
            // 
            // readFileBtn
            // 
            readFileBtn.Enabled = false;
            readFileBtn.Location = new Point(189, 156);
            readFileBtn.Name = "readFileBtn";
            readFileBtn.Size = new Size(101, 38);
            readFileBtn.TabIndex = 2;
            readFileBtn.Text = "Read File";
            readFileBtn.UseVisualStyleBackColor = true;
            readFileBtn.Click += readFileBtn_Click;
            // 
            // assembleMessageBtn
            // 
            assembleMessageBtn.Enabled = false;
            assembleMessageBtn.Location = new Point(189, 267);
            assembleMessageBtn.Name = "assembleMessageBtn";
            assembleMessageBtn.Size = new Size(101, 38);
            assembleMessageBtn.TabIndex = 3;
            assembleMessageBtn.Text = "Assemble Message";
            assembleMessageBtn.UseVisualStyleBackColor = true;
            assembleMessageBtn.Click += assembleMessageBtn_Click;
            // 
            // messageCountLbl
            // 
            messageCountLbl.AutoSize = true;
            messageCountLbl.Location = new Point(33, 168);
            messageCountLbl.Name = "messageCountLbl";
            messageCountLbl.Size = new Size(98, 15);
            messageCountLbl.TabIndex = 4;
            messageCountLbl.Text = "Message Count : ";
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.Location = new Point(137, 168);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(13, 15);
            countLbl.TabIndex = 5;
            countLbl.Text = "0";
            // 
            // messageChoiceDrop
            // 
            messageChoiceDrop.Enabled = false;
            messageChoiceDrop.FormattingEnabled = true;
            messageChoiceDrop.Location = new Point(29, 276);
            messageChoiceDrop.Name = "messageChoiceDrop";
            messageChoiceDrop.Size = new Size(121, 23);
            messageChoiceDrop.TabIndex = 6;
            // 
            // selectFileBtn
            // 
            selectFileBtn.Location = new Point(189, 49);
            selectFileBtn.Name = "selectFileBtn";
            selectFileBtn.Size = new Size(101, 38);
            selectFileBtn.TabIndex = 7;
            selectFileBtn.Text = "Select File";
            selectFileBtn.UseVisualStyleBackColor = true;
            selectFileBtn.Click += selectFileBtn_Click;
            // 
            // selectedFileTxt
            // 
            selectedFileTxt.Location = new Point(33, 58);
            selectedFileTxt.Name = "selectedFileTxt";
            selectedFileTxt.ReadOnly = true;
            selectedFileTxt.Size = new Size(150, 23);
            selectedFileTxt.TabIndex = 9;
            selectedFileTxt.Text = "No File Selected";
            // 
            // selectedFileLbl
            // 
            selectedFileLbl.AutoSize = true;
            selectedFileLbl.Location = new Point(33, 40);
            selectedFileLbl.Name = "selectedFileLbl";
            selectedFileLbl.Size = new Size(78, 15);
            selectedFileLbl.TabIndex = 10;
            selectedFileLbl.Text = "Selected File :";
            // 
            // reasembledMessageTxt
            // 
            reasembledMessageTxt.Location = new Point(33, 390);
            reasembledMessageTxt.Name = "reasembledMessageTxt";
            reasembledMessageTxt.ReadOnly = true;
            reasembledMessageTxt.Size = new Size(486, 23);
            reasembledMessageTxt.TabIndex = 11;
            // 
            // selectMessageLbl
            // 
            selectMessageLbl.AutoSize = true;
            selectMessageLbl.Location = new Point(29, 258);
            selectMessageLbl.Name = "selectMessageLbl";
            selectMessageLbl.Size = new Size(102, 15);
            selectMessageLbl.TabIndex = 12;
            selectMessageLbl.Text = "Select a Message :";
            // 
            // reasembeledMessageLbl
            // 
            reasembeledMessageLbl.AutoSize = true;
            reasembeledMessageLbl.ImageAlign = ContentAlignment.BottomRight;
            reasembeledMessageLbl.Location = new Point(33, 372);
            reasembeledMessageLbl.Name = "reasembeledMessageLbl";
            reasembeledMessageLbl.Size = new Size(138, 15);
            reasembeledMessageLbl.TabIndex = 13;
            reasembeledMessageLbl.Text = "Re-Assembeled Message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(reasembeledMessageLbl);
            Controls.Add(selectMessageLbl);
            Controls.Add(reasembledMessageTxt);
            Controls.Add(selectedFileLbl);
            Controls.Add(selectedFileTxt);
            Controls.Add(selectFileBtn);
            Controls.Add(messageChoiceDrop);
            Controls.Add(countLbl);
            Controls.Add(messageCountLbl);
            Controls.Add(assembleMessageBtn);
            Controls.Add(readFileBtn);
            Controls.Add(wordsFoundLabel);
            Controls.Add(foundWordsBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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