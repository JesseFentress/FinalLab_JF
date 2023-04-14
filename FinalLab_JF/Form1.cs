namespace FinalLab_JF
{
    public partial class Form1 : Form
    {
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
                selectedFileTxt.Text = Path.GetFileName(openFileDialog.FileName);
                toggle_Enable_readFileBtn();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}