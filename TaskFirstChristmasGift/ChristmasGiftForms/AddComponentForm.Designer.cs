namespace ChristmasGiftForms
{
    partial class AddComponentForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.sugarBox = new System.Windows.Forms.TextBox();
            this.addCandyButton = new System.Windows.Forms.Button();
            this.componentBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.specialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 0;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(12, 38);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(121, 20);
            this.weightBox.TabIndex = 1;
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(12, 64);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(121, 20);
            this.costBox.TabIndex = 2;
            // 
            // sugarBox
            // 
            this.sugarBox.Location = new System.Drawing.Point(12, 90);
            this.sugarBox.Name = "sugarBox";
            this.sugarBox.Size = new System.Drawing.Size(121, 20);
            this.sugarBox.TabIndex = 3;
            // 
            // addCandyButton
            // 
            this.addCandyButton.Location = new System.Drawing.Point(12, 155);
            this.addCandyButton.Name = "addCandyButton";
            this.addCandyButton.Size = new System.Drawing.Size(121, 41);
            this.addCandyButton.TabIndex = 4;
            this.addCandyButton.Text = "Add Component";
            this.addCandyButton.UseVisualStyleBackColor = true;
            this.addCandyButton.Click += new System.EventHandler(this.addCandyButton_Click);
            // 
            // componentBox
            // 
            this.componentBox.FormattingEnabled = true;
            this.componentBox.Location = new System.Drawing.Point(12, 128);
            this.componentBox.Name = "componentBox";
            this.componentBox.Size = new System.Drawing.Size(121, 21);
            this.componentBox.TabIndex = 5;
            this.componentBox.SelectedIndexChanged += new System.EventHandler(this.componentBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(137, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(137, 41);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(137, 67);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Cost";
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.Location = new System.Drawing.Point(139, 93);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(0, 13);
            this.specialLabel.TabIndex = 9;
            // 
            // AddComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 208);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddComponentForm";
            this.Text = "AddComponentForm";
            this.Load += new System.EventHandler(this.AddComponentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox sugarBox;
        private System.Windows.Forms.Button addCandyButton;
        private System.Windows.Forms.ComboBox componentBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label specialLabel;
    }
}