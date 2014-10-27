using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextParser;

namespace SentenceProcessor
{
    public partial class FormSentenceProcessor : Form
    {
        private SentenceSeparator _sentenceSeparator;
        public FormSentenceProcessor()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
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
                if (fileName == null) return;

                _sentenceSeparator = new SentenceSeparator();
                _sentenceSeparator.Create(fileName);
                textBoxOutput.Text = _sentenceSeparator.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't open file");
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            if (_sentenceSeparator == null) return;
            _sentenceSeparator.Sort();
            textBoxOutput.Text = _sentenceSeparator.ToString();
        }

        private void buttonDeleteWord_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            int length = Int16.Parse(textBoxWordLength.Text);
            if (_sentenceSeparator == null || length == 0) return;
            _sentenceSeparator.RemoveConsonant(length);
            textBoxOutput.Text = _sentenceSeparator.ToString();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            int length = Int16.Parse(textBoxWordLength.Text);
            if (_sentenceSeparator == null || length == 0 || textBoxSubstring.Text == "") return;
            _sentenceSeparator.ReplaceWords(length, textBoxSubstring.Text);
            textBoxOutput.Text = _sentenceSeparator.ToString();
        }
    }
}
