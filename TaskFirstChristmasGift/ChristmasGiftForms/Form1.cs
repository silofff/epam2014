using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChristmasGiftForms.Properties;
using ChristmasGiftLibrary;
using Component = ChristmasGiftLibrary.Components.Component;

namespace ChristmasGiftForms
{
    public partial class ChristmasGiftForm : Form
    {
        private readonly ChristmasGift _gift = new ChristmasGift();
        public ChristmasGiftForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            
            try
            {
                var fileName = openFileDialog.FileName;
                
                if (fileName == null) return;
                _gift.Open(fileName);
                
                if (_gift == null) return;
                WriteInfo(_gift);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ChristmasGiftForm_OpenButton_Click_Error__Could_not_read_file_from_disk__Original_error__ + ex.Message);
            }
        }

        private void WriteInfo(IEnumerable<Component> gift)
        {
            foreach (var c in gift)
            {
                InfoTextBox.Text += c.ComponentDescription();
                InfoTextBox.Text += "\n";
            }
        }


    }
}
