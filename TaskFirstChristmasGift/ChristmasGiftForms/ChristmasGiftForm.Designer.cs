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
            this.addButton = new System.Windows.Forms.Button();
            this.saveGift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.AutoSize = true;
            this.OpenButton.Location = new System.Drawing.Point(12, 14);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(148, 46);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open File";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Location = new System.Drawing.Point(166, 14);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(358, 301);
            this.InfoTextBox.TabIndex = 1;
            this.InfoTextBox.Text = "";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 270);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(148, 43);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            // ChristmasGiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(536, 325);
            this.Controls.Add(this.saveGift);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.OpenButton);
            this.Name = "ChristmasGiftForm";
            this.Text = "Chtistmas Gift";
            this.Activated += new System.EventHandler(this.ChristmasGiftForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveGift;
    }
}

