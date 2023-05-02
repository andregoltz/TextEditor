using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {

        #region Properties
        private StreamReader Reader { get; set; } = null;
        #endregion

        #region Constructor
        public TextEditor()
        {
            InitializeComponent();
        }
        #endregion

        #region PrivateMethods
        private void NewFile()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        private void SaveFile()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                    FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);
                    writer.Flush();
                    writer.BaseStream.Seek(0, SeekOrigin.Begin);
                    writer.Write(richTextBox1.Text);
                    writer.Flush();
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenFile()
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "(*.TXT)|*.TXT";

            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file);
                    reader.BaseStream.Seek(0, SeekOrigin.Begin);
                    richTextBox1.Clear();
                    richTextBox1.Text = reader.ReadToEnd();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void Copy()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Paste()
        {
            richTextBox1.Paste();
        }
        private void Bold()
        {
            FontStyleFormat(FontStyle.Bold);
        }
        private void Italic()
        {
            FontStyleFormat(FontStyle.Italic);
        }
        private void Underline()
        {
            FontStyleFormat(FontStyle.Underline);
        }
        private void FontStyleFormat(FontStyle fontStyle)
        {
            string fontName = richTextBox1.Font.Name;
            float fontSize = richTextBox1.Font.Size;

            richTextBox1.SelectionFont = new Font(fontName, fontSize, richTextBox1.SelectionFont.Style ^ fontStyle);
        }
        #endregion

        #region ButtonEvents
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void Menu_NewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void Menu_File_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void Menu_File_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void Menu_Edit_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        private void Menu_Edit_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        private void btnBold_Click(object sender, EventArgs e)
        {
            Bold();
        }
        private void Menu_Format_Bold_Click(object sender, EventArgs e)
        {
            Bold();
        }
        private void btnItalic_Click(object sender, EventArgs e)
        {
            Italic();
        }
        private void Menu_Format_Italic_Click(object sender, EventArgs e)
        {
            Italic();
        }
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Underline();
        }
        private void Menu_Format_Underline_Click(object sender, EventArgs e)
        {
            Underline();
        }
        #endregion

    }
}
