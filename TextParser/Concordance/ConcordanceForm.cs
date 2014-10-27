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

namespace Concordance
{
    public partial class ConcordanceForm : Form
    {
        private readonly TextParser.Concordance _concordance = new TextParser.Concordance();

        public ConcordanceForm()
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
                _concordance.Create(fileName);
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
