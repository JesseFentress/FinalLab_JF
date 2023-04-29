namespace FinalLab_JF
{
    public partial class Form1 : Form
    {

        // Dict for holding entire encodes messages
        Dictionary<int, List<int>> encodedMessages = new Dictionary<int, List<int>>();

        // Dict for holding unique words that can be accessed by their code
        Dictionary<int, string> uniqueWords = new Dictionary<int, string>();

        // Dict for holding unique word codes that be accesssed by their word
        Dictionary<string, int> uniqueWordCodes = new Dictionary<string, int>();

        // Holds the selected files path
        string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void assembleMessageBtn_Click(object sender, EventArgs e)
        {

        }

        private void toggle_Enable_selectFileBtn()
        {
            selectFileBtn.Enabled = !selectFileBtn.Enabled;
        }

        private void toggle_Enable_readFileBtn()
        {
            readFileBtn.Enabled = !readFileBtn.Enabled;
        }

        private void toggle_Enable_assembleMessageBtn()
        {
            assembleMessageBtn.Enabled = !assembleMessageBtn.Enabled;
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text|*.txt|All|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                selectedFileTxt.Text = Path.GetFileName(openFileDialog.FileName);
                toggle_Enable_readFileBtn();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readAllMessages()
        {
            // Read the file using a StreamReader
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string messageLine; // An individual lines message
                int lineCount = 1;  // The line currently being read
                int wordCount = 0;  // The word count used to encode words

                // Continue while there are still message to read
                while ((messageLine = streamReader.ReadLine()) != null)
                {
                    // Grab all the words from a message
                    List<string> words = messageLine.ToLower().Split(" ").ToList();

                    // List to store codes for message
                    List<int> encodedMessageLine = new List<int>();

                    // Iterate for all words in the message
                    foreach (string word in words)
                    {
                        // The encountered word is new
                        if (!uniqueWordCodes.ContainsKey(word))
                        {
                            uniqueWords.Add(wordCount, word);       // Add the new word to the dict with a code value
                            uniqueWordCodes.Add(word, wordCount);   // Add the code and the word to the dict
                            wordCount++;                            // Incrememnt the word count
                        }

                        // Add the words code value to the message list
                        encodedMessageLine.Add(uniqueWordCodes[word]);
                    }

                    // Add the entire message to the dict of encoded messages
                    encodedMessages.Add(lineCount, encodedMessageLine);
                    
                    lineCount++;    //  Increment the line count
                }
            }
        }

        private void fillListBox_FoundWordsBox()
        {
            // Iterate for all words
            foreach (string word in  uniqueWords.Values)
            {
                foundWordsBox.Items.Add(word);  // Add the word
            }
        }

        private void fillChoiceBox_MessageChoiceBox()
        {
            // Iterate for all messages
            foreach(int num in encodedMessages.Keys)
            {
                messageChoiceDrop.Items.Add(num);   // Add the message num
            }
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            // Read the text file for messages
            readAllMessages();
  
            // Update the message count displayed to the user
            countLbl.Text = encodedMessages.Count.ToString();

            // Fill the text box with  all the detected words
            fillListBox_FoundWordsBox();

            // Fill the drop down box with options to select the messages
            fillChoiceBox_MessageChoiceBox();

            // Enable the assemble messages button
            toggle_Enable_assembleMessageBtn();          
        }

    }
}