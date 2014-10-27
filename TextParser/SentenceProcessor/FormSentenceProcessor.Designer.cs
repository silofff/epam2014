namespace SentenceProcessor
{
    partial class FormSentenceProcessor
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonDeleteWord = new System.Windows.Forms.Button();
            this.textBoxWordLength = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.textBoxSubstring = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(93, 14);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(420, 359);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.Text = "";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(12, 41);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonDeleteWord
            // 
            this.buttonDeleteWord.Location = new System.Drawing.Point(12, 97);
            this.buttonDeleteWord.Name = "buttonDeleteWord";
            this.buttonDeleteWord.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteWord.TabIndex = 3;
            this.buttonDeleteWord.Text = "Delete Word";
            this.buttonDeleteWord.UseVisualStyleBackColor = true;
            this.buttonDeleteWord.Click += new System.EventHandler(this.buttonDeleteWord_Click);
            // 
            // textBoxWordLength
            // 
            this.textBoxWordLength.Location = new System.Drawing.Point(12, 71);
            this.textBoxWordLength.Name = "textBoxWordLength";
            this.textBoxWordLength.Size = new System.Drawing.Size(75, 20);
            this.textBoxWordLength.TabIndex = 4;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(12, 152);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 5;
            this.buttonReplace.Text = "Replace Word";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxSubstring
            // 
            this.textBoxSubstring.Location = new System.Drawing.Point(12, 126);
            this.textBoxSubstring.Name = "textBoxSubstring";
            this.textBoxSubstring.Size = new System.Drawing.Size(75, 20);
            this.textBoxSubstring.TabIndex = 6;
            // 
            // FormSentenceProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.textBoxSubstring);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.textBoxWordLength);
            this.Controls.Add(this.buttonDeleteWord);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonOpen);
            this.Name = "FormSentenceProcessor";
            this.Text = "Sentence Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonDeleteWord;
        private System.Windows.Forms.TextBox textBoxWordLength;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.TextBox textBoxSubstring;
    }
}

