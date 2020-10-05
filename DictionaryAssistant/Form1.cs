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
using DictionaryAssistantMVC.Dictionary;
using DictionaryAssistant.Properties;
using DictionaryAssistantMVC.Dictionary.Loader;

namespace DictionaryAssistant
{
    public partial class Form1 : Form
    {
        private class FormData
        {
            private readonly Dictionary<char, DictionaryLetter> letterData = new Dictionary<char, DictionaryLetter>();

            public ActiveDictionary LoadedDictionary { get; private set; } = null;
            public bool DictionaryLoaded { get; private set; } = false;

            public DictionaryLetter GetDictionaryLetter(char letter)
            {
                return letterData[letter];
            }

            public void LoadDictionary(Stream dictStream)
            {
                LoadedDictionary = Loader.LoadDictionary(dictStream);
                DictionaryLoaded = true;

                foreach (DictionaryLetter dl in LoadedDictionary.GetAllDictionaryLetters())
                {
                    letterData.Add(dl.Letter, dl);
                }
            }

            public void UnloadDictionary()
            {
                if (!DictionaryLoaded)
                {
                    return;
                }

                LoadedDictionary = null;
                DictionaryLoaded = false;
                this.letterData.Clear();
            }
        }
        private readonly FormData formData;

        public Form1()
        {
            InitializeComponent();

            this.formData = new FormData();
        }

        private void PopulateListBoxWithWords(ListBox listBox, Func<List<string>> wordGetter)
        {
            var words = wordGetter();
            listBox.Items.AddRange(words.ToArray());
        }

        private void ClearListBoxOfWords(ListBox listBox)
        {
            listBox.Items.Clear();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set title from our resources
            this.Text = Resources.ApplicationTitle;

            // Set up the alphabetical combobox
            foreach (char c in new Alphabet())
            {
                this.alphabetSelector.Items.Add(c);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    ofd.FilterIndex = 1;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        this.formData.LoadDictionary(ofd.OpenFile());
                    }
                }

                // Select the first item of `alphabetSelector` so the user sees something
                if (this.formData.DictionaryLoaded)
                {
                    this.alphabetSelector.SelectedIndex = 0;
                }

                // Enable close menu item
                this.closeToolStripMenuItem.Enabled = this.formData.DictionaryLoaded;
            }
            catch (FileLoadException flea)
            {
                MessageBox.Show(this, flea.ToString(), "Unable to Load File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear FormData subclass of state and disable this menu item.
            this.formData.UnloadDictionary();
            this.closeToolStripMenuItem.Enabled = this.formData.DictionaryLoaded;

            // Reset the GUI to initial state
            var zero = (0).ToString();
            this.indicatorWordsBegin.Text = zero;
            this.indicatorWordsEnd.Text = zero;
            this.indicatorAverageChars.Text = zero;

            ClearListBoxOfWords(this.listBoxLongestWords);
            ClearListBoxOfWords(this.listBoxShortestWords);
        }

        private void alphabetSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox theSelector = (ComboBox)sender;
            string letterString = theSelector.GetItemText(theSelector.SelectedItem);

            this.indicatorCurrentLetter.Text = letterString.ToUpper();

            if (this.formData.DictionaryLoaded)
            {
                // Get actual data for current label
                DictionaryLetter newLetter = this.formData.GetDictionaryLetter(letterString[0]);

                this.indicatorWordsBegin.Text = $"{newLetter.NumberWordsBeginningWith}";
                this.indicatorWordsEnd.Text = $"{newLetter.NumberWordsEndingWith}";
                this.indicatorAverageChars.Text = $"{newLetter.AverageCharacterCount}";

                // Clear the list boxes before populating them
                ClearListBoxOfWords(this.listBoxLongestWords);
                ClearListBoxOfWords(this.listBoxShortestWords);

                // Populate the list boxes
                PopulateListBoxWithWords(this.listBoxLongestWords, () => newLetter.GetLongestWords());
                PopulateListBoxWithWords(this.listBoxShortestWords, () => newLetter.GetShortestWords());
            }
        }
    }
}
