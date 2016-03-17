using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TableLib;

namespace ScriptTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string StartOffset
        {
            get
            {
                return OffsetStartBox.Text;
            }
        }

        public string EndOffset
        {
            get
            {
                return OffsetEndBox.Text;
            }
        }

        private void LoadROMButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog rom = new OpenFileDialog();
            rom.Title = "Please select a rom.";
            rom.Filter = "NES ROMs (*.nes)|*.nes|PC Engine ROMs (*.pce)|*.pce|SNES ROMs (*.smc)|*.smc|Genesis ROMs (*.gen)|*.gen|Executable Files (*.exe)|*.exe";
            rom.CheckFileExists = true;
            rom.CheckPathExists = true;

            if (rom.ShowDialog(this) == DialogResult.OK)
            {
                BinaryReader br = new BinaryReader(File.Open(rom.FileName, FileMode.Open));
                br.ReadBytes(0xffffff);
                ROMPathBox.Text = rom.FileName;
                ScriptExtractButton.Enabled = true;
                ScriptInsertButton.Enabled = true;
            }
        }

        //private void AboutButton_Click(object sender, EventArgs e)
        //{
        //    AboutDialog about = new AboutDialog();

        //    if (about.ShowDialog(this) == DialogResult.OK)
        //    {
        //        about.Close();
        //    }
        //}

        private void LoadScriptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog scriptl = new OpenFileDialog();
            scriptl.Title = "Load script.";
            scriptl.Filter = "Text Files (*.txt)|*.txt";
            scriptl.CheckPathExists = true;
            scriptl.CheckFileExists = true;

            if (scriptl.ShowDialog(this) == DialogResult.OK)
            {
                ScriptDisplay.LoadFile(scriptl.FileName, RichTextBoxStreamType.UnicodePlainText);
            }
        }

        private void SaveScriptButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog scripts = new SaveFileDialog();
            scripts.Title = "Save script.";
            scripts.Filter = "Text Files (*.txt)|*.txt";
            scripts.CheckFileExists = true;
            scripts.CheckPathExists = true;
            scripts.AddExtension = true;

            if (scripts.ShowDialog(this) == DialogResult.OK)
            {
                ScriptDisplay.SaveFile(scripts.FileName, RichTextBoxStreamType.UnicodePlainText);
            }
        }

        private void TBLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog tbl = new OpenFileDialog();
            tbl.Title = "Please select a table file.";
            tbl.Filter = "Table files (*.tbl)|*.tbl";
            tbl.CheckFileExists = true;
            tbl.CheckPathExists = true;

            if (tbl.ShowDialog(this) == DialogResult.OK)
            {
                TableReader table = new TableReader(TableReaderType.ReadTypeDump);
                table.OpenTable(tbl.FileName, Encoding.Unicode);
            }

        }

        private void CheckUpButton_Click(object sender, EventArgs e)
        {

        }

        private void ScriptExtractButton_Click(object sender, EventArgs e)
        {

        }

        private void ScriptInsertButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
