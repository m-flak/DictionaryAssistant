namespace DictionaryAssistant
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.alphabetSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.indicatorWordsBegin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.indicatorWordsEnd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.indicatorAverageChars = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxShortestWords = new System.Windows.Forms.ListBox();
            this.listBoxLongestWords = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.alphabetSelector);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.indicatorWordsBegin);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.indicatorWordsEnd);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.indicatorAverageChars);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.listBoxShortestWords);
            this.flowLayoutPanel1.Controls.Add(this.listBoxLongestWords);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(755, 426);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(755, 426);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a letter of the alphabet: ";
            // 
            // alphabetSelector
            // 
            this.alphabetSelector.FormattingEnabled = true;
            this.alphabetSelector.Location = new System.Drawing.Point(169, 3);
            this.alphabetSelector.Name = "alphabetSelector";
            this.alphabetSelector.Size = new System.Drawing.Size(280, 21);
            this.alphabetSelector.TabIndex = 1;
            this.alphabetSelector.SelectedIndexChanged += new System.EventHandler(this.alphabetSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "# of Words Beginning With Letter: ";
            // 
            // indicatorWordsBegin
            // 
            this.indicatorWordsBegin.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.indicatorWordsBegin, true);
            this.indicatorWordsBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicatorWordsBegin.Location = new System.Drawing.Point(708, 0);
            this.indicatorWordsBegin.Margin = new System.Windows.Forms.Padding(62, 0, 3, 0);
            this.indicatorWordsBegin.Name = "indicatorWordsBegin";
            this.indicatorWordsBegin.Padding = new System.Windows.Forms.Padding(4);
            this.indicatorWordsBegin.Size = new System.Drawing.Size(22, 21);
            this.indicatorWordsBegin.TabIndex = 3;
            this.indicatorWordsBegin.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(464, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "# of Words Ending With Letter: ";
            // 
            // indicatorWordsEnd
            // 
            this.indicatorWordsEnd.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.indicatorWordsEnd, true);
            this.indicatorWordsEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicatorWordsEnd.Location = new System.Drawing.Point(708, 27);
            this.indicatorWordsEnd.Margin = new System.Windows.Forms.Padding(76, 0, 3, 0);
            this.indicatorWordsEnd.Name = "indicatorWordsEnd";
            this.indicatorWordsEnd.Padding = new System.Windows.Forms.Padding(4);
            this.indicatorWordsEnd.Size = new System.Drawing.Size(22, 21);
            this.indicatorWordsEnd.TabIndex = 5;
            this.indicatorWordsEnd.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(464, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(238, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average # of Characters In Words With Letter: ";
            // 
            // indicatorAverageChars
            // 
            this.indicatorAverageChars.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.indicatorAverageChars, true);
            this.indicatorAverageChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicatorAverageChars.Location = new System.Drawing.Point(708, 48);
            this.indicatorAverageChars.Name = "indicatorAverageChars";
            this.indicatorAverageChars.Padding = new System.Windows.Forms.Padding(4);
            this.indicatorAverageChars.Size = new System.Drawing.Size(22, 21);
            this.indicatorAverageChars.TabIndex = 7;
            this.indicatorAverageChars.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(90, 24, 3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4);
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Shortest Words for This Letter: ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.label7, true);
            this.label7.Location = new System.Drawing.Point(435, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(180, 24, 3, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(4);
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Longest Words for This Letter: ";
            // 
            // listBoxShortestWords
            // 
            this.listBoxShortestWords.FormattingEnabled = true;
            this.listBoxShortestWords.Location = new System.Drawing.Point(24, 117);
            this.listBoxShortestWords.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.listBoxShortestWords.Name = "listBoxShortestWords";
            this.listBoxShortestWords.Size = new System.Drawing.Size(307, 303);
            this.listBoxShortestWords.TabIndex = 10;
            // 
            // listBoxLongestWords
            // 
            this.listBoxLongestWords.FormattingEnabled = true;
            this.listBoxLongestWords.Location = new System.Drawing.Point(358, 117);
            this.listBoxLongestWords.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.listBoxLongestWords.Name = "listBoxLongestWords";
            this.listBoxLongestWords.Size = new System.Drawing.Size(307, 303);
            this.listBoxLongestWords.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox alphabetSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label indicatorWordsBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label indicatorWordsEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label indicatorAverageChars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxShortestWords;
        private System.Windows.Forms.ListBox listBoxLongestWords;
    }
}

