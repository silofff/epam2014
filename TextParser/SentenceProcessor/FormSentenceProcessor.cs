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

                var sentenceSeparator = new SentenceSeparator(fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't open file");
            }
        }
    }
}
