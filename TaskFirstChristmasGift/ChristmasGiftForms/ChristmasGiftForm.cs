using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ChristmasGiftForms.Properties;
using ChristmasGiftLibrary;
using ChristmasGiftLibrary.Components;

namespace ChristmasGiftForms
{
    public partial class ChristmasGiftForm : Form
    {
        public ChristmasGiftForm()
        {
            InitializeComponent();
            componentBox.Items.Add("Candy");
            componentBox.Items.Add("Fruit");
            componentBox.SelectedItem = "Candy";
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

        private void sortButton_Click(object sender, EventArgs e)
        {
            _gift.SortGiftByWeight();
            WriteInfo(_gift);
        }

        private void componentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)componentBox.SelectedItem)
            {
                case "Candy":
                    specialLabel.Text = "Sugar";
                    break;
                case "Fruit":
                    specialLabel.Text = "Color";
                    break;
            }
        }

        private void addCandyButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch ((string) componentBox.SelectedItem)
                {
                    case "Candy":
                        _gift.Add(new Candy(nameBox.Text, Double.Parse(weightBox.Text),
                            Int32.Parse(sugarBox.Text), Double.Parse(costBox.Text)));
                        break;

                    case "Fruit":
                        _gift.Add(new Fruit(nameBox.Text, Double.Parse(weightBox.Text),
                            sugarBox.Text, Double.Parse(costBox.Text)));
                        break;
                }
                WriteInfo(_gift);
            }

            catch (Exception)
            {
                MessageBox.Show("Can't added");
            }
        }

        private void findSugar_Click(object sender, EventArgs e)
        {
            try
            {
                var sugars = _gift.FindComponentsBySugar(int.Parse(minBox.Text), int.Parse(maxBox.Text));

                InfoTextBox.Text += "\nComponents with sugar: \n";
                foreach (var sugar in sugars)
                {
                    InfoTextBox.Text += sugar.ComponentDescription() + "\n";
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Can't find");
            }
        }
    }
}
