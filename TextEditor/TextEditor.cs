using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void Menu_File_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        #endregion
    }
}
