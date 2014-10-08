using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChristmasGiftLibrary;
using ChristmasGiftLibrary.Components;

namespace ChristmasGiftForms
{
    public partial class AddComponentForm : Form
    {
        private ChristmasGift _gift = new ChristmasGift();
        
        public AddComponentForm()
        {
            InitializeComponent();
            componentBox.Items.Add("Candy");
            componentBox.Items.Add("Fruit");
            componentBox.SelectedItem = "Candy";
        }



        public void GiftInitialize(ref ChristmasGift gift)
        {
            _gift = gift;
        }
        

        private void AddComponentForm_Load(object sender, EventArgs e)
        {

        }

        private void addCandyButton_Click(object sender, EventArgs e)
        {
            switch ((string)componentBox.SelectedItem)
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

            Close();
        }

        private void componentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string) componentBox.SelectedItem)
            {
                case "Candy":
                    specialLabel.Text = "Sugar";
                    break;
                case "Fruit":
                    specialLabel.Text = "Color";
                    break;
            }
        }
    }
}
