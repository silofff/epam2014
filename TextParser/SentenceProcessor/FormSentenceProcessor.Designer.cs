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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(185, 12);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(522, 359);
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
            this.buttonDeleteWord.Location = new System.Drawing.Point(12, 70);
            this.buttonDeleteWord.Name = "buttonDeleteWord";
            this.buttonDeleteWord.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteWord.TabIndex = 3;
            this.buttonDeleteWord.Text = "Delete Word";
            this.buttonDeleteWord.UseVisualStyleBackColor = true;
            this.buttonDeleteWord.Click += new System.EventHandler(this.buttonDeleteWord_Click);
            // 
            // textBoxWordLength
            // 
            this.textBoxWordLength.Location = new System.Drawing.Point(93, 72);
            this.textBoxWordLength.Name = "textBoxWordLength";
            this.textBoxWordLength.Size = new System.Drawing.Size(75, 20);
            this.textBoxWordLength.TabIndex = 4;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(12, 118);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 5;
            this.buttonReplace.Text = "Replace Word";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxSubstring
            // 
            this.textBoxSubstring.Location = new System.Drawing.Point(93, 120);
            this.textBoxSubstring.Name = "textBoxSubstring";
            this.textBoxSubstring.Size = new System.Drawing.Size(75, 20);
            this.textBoxSubstring.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Substring";
            // 
            // FormSentenceProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

