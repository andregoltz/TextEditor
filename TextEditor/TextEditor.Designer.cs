using System;

namespace TextEditor
{
    partial class TextEditor
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_Underline = new System.Windows.Forms.ToolStripMenuItem();
            this.alignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_Alignment_AlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_Alignment_AlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_Alignment_AlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_Alignment_Justified = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewFile = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.btnAlignCentered = new System.Windows.Forms.ToolStripButton();
            this.btnAlignRight = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 398);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_NewFile,
            this.Menu_File_OpenFile,
            this.Menu_File_SaveFile,
            this.Menu_File_Print,
            this.exitToolStripMenuItem,
            this.Menu_File_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Menu_File_NewFile
            // 
            this.Menu_File_NewFile.Name = "Menu_File_NewFile";
            this.Menu_File_NewFile.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_NewFile.Text = "New";
            this.Menu_File_NewFile.Click += new System.EventHandler(this.Menu_NewFile_Click);
            // 
            // Menu_File_OpenFile
            // 
            this.Menu_File_OpenFile.Name = "Menu_File_OpenFile";
            this.Menu_File_OpenFile.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_OpenFile.Text = "Open";
            // 
            // Menu_File_SaveFile
            // 
            this.Menu_File_SaveFile.Name = "Menu_File_SaveFile";
            this.Menu_File_SaveFile.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_SaveFile.Text = "Save";
            this.Menu_File_SaveFile.Click += new System.EventHandler(this.Menu_File_SaveFile_Click);
            // 
            // Menu_File_Print
            // 
            this.Menu_File_Print.Name = "Menu_File_Print";
            this.Menu_File_Print.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_Print.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // Menu_File_Exit
            // 
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_Exit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Edit_Copy,
            this.Menu_Edit_Paste,
            this.Menu_Edit_Undo,
            this.Menu_Edit_Redo});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // Menu_Edit_Copy
            // 
            this.Menu_Edit_Copy.Name = "Menu_Edit_Copy";
            this.Menu_Edit_Copy.Size = new System.Drawing.Size(103, 22);
            this.Menu_Edit_Copy.Text = "Copy";
            // 
            // Menu_Edit_Paste
            // 
            this.Menu_Edit_Paste.Name = "Menu_Edit_Paste";
            this.Menu_Edit_Paste.Size = new System.Drawing.Size(103, 22);
            this.Menu_Edit_Paste.Text = "Paste";
            // 
            // Menu_Edit_Undo
            // 
            this.Menu_Edit_Undo.Name = "Menu_Edit_Undo";
            this.Menu_Edit_Undo.Size = new System.Drawing.Size(103, 22);
            this.Menu_Edit_Undo.Text = "Undo";
            // 
            // Menu_Edit_Redo
            // 
            this.Menu_Edit_Redo.Name = "Menu_Edit_Redo";
            this.Menu_Edit_Redo.Size = new System.Drawing.Size(103, 22);
            this.Menu_Edit_Redo.Text = "Redo";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Format_Bold,
            this.Menu_Format_Italic,
            this.Menu_Format_Underline,
            this.alignToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // Menu_Format_Bold
            // 
            this.Menu_Format_Bold.Name = "Menu_Format_Bold";
            this.Menu_Format_Bold.Size = new System.Drawing.Size(130, 22);
            this.Menu_Format_Bold.Text = "Bold";
            // 
            // Menu_Format_Italic
            // 
            this.Menu_Format_Italic.Name = "Menu_Format_Italic";
            this.Menu_Format_Italic.Size = new System.Drawing.Size(130, 22);
            this.Menu_Format_Italic.Text = "Italic";
            // 
            // Menu_Format_Underline
            // 
            this.Menu_Format_Underline.Name = "Menu_Format_Underline";
            this.Menu_Format_Underline.Size = new System.Drawing.Size(130, 22);
            this.Menu_Format_Underline.Text = "Underline";
            // 
            // alignToolStripMenuItem
            // 
            this.alignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Format_Alignment_AlignCenter,
            this.Menu_Format_Alignment_AlignLeft,
            this.Menu_Format_Alignment_AlignRight,
            this.Menu_Format_Alignment_Justified});
            this.alignToolStripMenuItem.Name = "alignToolStripMenuItem";
            this.alignToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.alignToolStripMenuItem.Text = "Alignment";
            // 
            // Menu_Format_Alignment_AlignCenter
            // 
            this.Menu_Format_Alignment_AlignCenter.Name = "Menu_Format_Alignment_AlignCenter";
            this.Menu_Format_Alignment_AlignCenter.Size = new System.Drawing.Size(167, 22);
            this.Menu_Format_Alignment_AlignCenter.Text = "Align to Centered";
            // 
            // Menu_Format_Alignment_AlignLeft
            // 
            this.Menu_Format_Alignment_AlignLeft.Name = "Menu_Format_Alignment_AlignLeft";
            this.Menu_Format_Alignment_AlignLeft.Size = new System.Drawing.Size(167, 22);
            this.Menu_Format_Alignment_AlignLeft.Text = "Align to Left";
            // 
            // Menu_Format_Alignment_AlignRight
            // 
            this.Menu_Format_Alignment_AlignRight.Name = "Menu_Format_Alignment_AlignRight";
            this.Menu_Format_Alignment_AlignRight.Size = new System.Drawing.Size(167, 22);
            this.Menu_Format_Alignment_AlignRight.Text = "Align to Right";
            // 
            // Menu_Format_Alignment_Justified
            // 
            this.Menu_Format_Alignment_Justified.Name = "Menu_Format_Alignment_Justified";
            this.Menu_Format_Alignment_Justified.Size = new System.Drawing.Size(167, 22);
            this.Menu_Format_Alignment_Justified.Text = "Justified";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewFile,
            this.btnOpenFile,
            this.btnSaveFile,
            this.toolStripSeparator1,
            this.btnCopy,
            this.btnPaste,
            this.toolStripSeparator2,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.toolStripSeparator3,
            this.btnAlignLeft,
            this.btnAlignCentered,
            this.btnAlignRight});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewFile
            // 
            this.btnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewFile.Image = global::TextEditor.Properties.Resources.notepad_with_text_lines;
            this.btnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(23, 22);
            this.btnNewFile.Text = "New File";
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFile.Image = global::TextEditor.Properties.Resources.store_files;
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(23, 22);
            this.btnOpenFile.Text = "Open File";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveFile.Image = global::TextEditor.Properties.Resources.save_files;
            this.btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(23, 22);
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopy.Image = global::TextEditor.Properties.Resources.copy_text;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(23, 22);
            this.btnCopy.Text = "Copy";
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Image = global::TextEditor.Properties.Resources.paste_text;
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(23, 22);
            this.btnPaste.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = global::TextEditor.Properties.Resources.bold_button1;
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = global::TextEditor.Properties.Resources.italic_button;
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "Italic";
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = global::TextEditor.Properties.Resources.underline_button;
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Underline";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignLeft.Image = global::TextEditor.Properties.Resources.left_alignment_button;
            this.btnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.btnAlignLeft.Text = "Align Left";
            // 
            // btnAlignCentered
            // 
            this.btnAlignCentered.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignCentered.Image = global::TextEditor.Properties.Resources.center_alignment_button;
            this.btnAlignCentered.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignCentered.Name = "btnAlignCentered";
            this.btnAlignCentered.Size = new System.Drawing.Size(23, 22);
            this.btnAlignCentered.Text = "Align Centered";
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignRight.Image = global::TextEditor.Properties.Resources.right_alignment_button;
            this.btnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(23, 22);
            this.btnAlignRight.Text = "Align Right";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_NewFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Print;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Paste;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Redo;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_Bold;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_Italic;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_Underline;
        private System.Windows.Forms.ToolStripMenuItem alignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_Alignment_AlignCenter;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_Alignment_AlignLeft;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_Alignment_AlignRight;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_Alignment_Justified;
        private System.Windows.Forms.ToolStripButton btnNewFile;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAlignLeft;
        private System.Windows.Forms.ToolStripButton btnAlignCentered;
        private System.Windows.Forms.ToolStripButton btnAlignRight;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

