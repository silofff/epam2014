using System;
using System.Windows.Forms;
using ChristmasGiftForms.Properties;
using ChristmasGiftLibrary;

namespace ChristmasGiftForms
{
    public partial class ChristmasGiftForm : Form
    {
        private ChristmasGift _gift = new ChristmasGift();
        private readonly AddComponentForm _form = new AddComponentForm();

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
                _gift.Load(fileName);

                if (_gift == null) return;
                WriteInfo(_gift);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    Resources.ChristmasGiftForm_OpenButton_Click_Error__Could_not_read_file_from_disk__Original_error__ +
                    ex.Message);
            }
        }

        public void WriteInfo(ChristmasGift gift)
        {
            InfoTextBox.Clear();
            foreach (var c in gift)
            {
                InfoTextBox.Text += c.ComponentDescription();
                InfoTextBox.Text += "\n";
            }

            InfoTextBox.Text += "Total Cost: " + gift.TotalCost;
            InfoTextBox.Text += "\n";
            InfoTextBox.Text += "Total Weight: " + gift.TotalWeight;
            InfoTextBox.Text += "\n";
            InfoTextBox.Text += "Total Sugar: " + gift.TotalSugar;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _form.GiftInitialize(ref _gift);
            _form.Show(this);
        }

        private void saveGift_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog {FilterIndex = 1, RestoreDirectory = true};

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var fileName = saveFileDialog.FileName;

                if (fileName == null) return;
                _gift.Save(fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChristmasGiftForm_Activated(object sender, EventArgs e)
        {
            WriteInfo(_gift);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            _gift.SortGiftByWeight();
            WriteInfo(_gift);
        }
    }
}
