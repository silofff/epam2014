using System;
using System.Windows.Forms;

namespace Concordance
{
    public partial class ConcordanceForm : Form
    {
        private TextParser.Concordance _concordance;

        public ConcordanceForm()
        {
            InitializeComponent();
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
			richTextBoxOutput.Clear ();
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "d:\\",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var fileName = openFileDialog.FileName;
                if (fileName == null && textBoxPage.Text == "") return;
                _concordance = new TextParser.Concordance();
                _concordance.Create(fileName, Int16.Parse(textBoxPage.Text));
                _concordance.GetConcordance();
                richTextBoxOutput.Text += _concordance.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't open file");
            }
        }
    }
}
