using ChristmasGiftLibrary;

namespace ChristmasGiftForms
{
    partial class ChristmasGiftForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.saveGift = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.specialLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.componentBox = new System.Windows.Forms.ComboBox();
            this.addCandyButton = new System.Windows.Forms.Button();
            this.sugarBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.findSugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.AutoSize = true;
            this.OpenButton.Location = new System.Drawing.Point(12, 14);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(148, 46);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Load File";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Location = new System.Drawing.Point(178, 14);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(474, 491);
            this.InfoTextBox.TabIndex = 1;
            this.InfoTextBox.Text = "";
            // 
            // saveGift
            // 
            this.saveGift.Location = new System.Drawing.Point(12, 66);
            this.saveGift.Name = "saveGift";
            this.saveGift.Size = new System.Drawing.Size(148, 43);
            this.saveGift.TabIndex = 3;
            this.saveGift.Text = "Save Gift";
            this.saveGift.UseVisualStyleBackColor = true;
            this.saveGift.Click += new System.EventHandler(this.saveGift_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(12, 115);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(148, 45);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort By Weight";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.Location = new System.Drawing.Point(139, 402);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(0, 13);
            this.specialLabel.TabIndex = 19;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(137, 376);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 18;
            this.costLabel.Text = "Cost";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(137, 350);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 17;
            this.weightLabel.Text = "Weight";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(137, 324);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name";
            // 
            // componentBox
            // 
            this.componentBox.FormattingEnabled = true;
            this.componentBox.Location = new System.Drawing.Point(12, 437);
            this.componentBox.Name = "componentBox";
            this.componentBox.Size = new System.Drawing.Size(121, 21);
            this.componentBox.TabIndex = 15;
            this.componentBox.SelectedIndexChanged += new System.EventHandler(this.componentBox_SelectedIndexChanged);
            // 
            // addCandyButton
            // 
            this.addCandyButton.Location = new System.Drawing.Point(12, 464);
            this.addCandyButton.Name = "addCandyButton";
            this.addCandyButton.Size = new System.Drawing.Size(148, 41);
            this.addCandyButton.TabIndex = 14;
            this.addCandyButton.Text = "Add Component";
            this.addCandyButton.UseVisualStyleBackColor = true;
            this.addCandyButton.Click += new System.EventHandler(this.addCandyButton_Click);
            // 
            // sugarBox
            // 
            this.sugarBox.Location = new System.Drawing.Point(12, 399);
            this.sugarBox.Name = "sugarBox";
            this.sugarBox.Size = new System.Drawing.Size(121, 20);
            this.sugarBox.TabIndex = 13;
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(12, 373);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(121, 20);
            this.costBox.TabIndex = 12;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(12, 347);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(121, 20);
            this.weightBox.TabIndex = 11;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 321);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 10;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(12, 223);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(55, 20);
            this.minBox.TabIndex = 20;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(85, 223);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(54, 20);
            this.maxBox.TabIndex = 21;
            // 
            // findSugar
            // 
            this.findSugar.Location = new System.Drawing.Point(12, 249);
            this.findSugar.Name = "findSugar";
            this.findSugar.Size = new System.Drawing.Size(148, 45);
            this.findSugar.TabIndex = 22;
            this.findSugar.Text = "Find By Sugar";
            this.findSugar.UseVisualStyleBackColor = true;
            this.findSugar.Click += new System.EventHandler(this.findSugar_Click);
            // 
            // ChristmasGiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(664, 515);
            this.Controls.Add(this.findSugar);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.specialLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.componentBox);
            this.Controls.Add(this.addCandyButton);
            this.Controls.Add(this.sugarBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.saveGift);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.OpenButton);
            this.Name = "ChristmasGiftForm";
            this.Text = "Chtistmas Gift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button saveGift;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label specialLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox componentBox;
        private System.Windows.Forms.Button addCandyButton;
        private System.Windows.Forms.TextBox sugarBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox nameBox;
        private readonly ChristmasGift _gift = new ChristmasGift();
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Button findSugar;
    }
}

