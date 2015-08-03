namespace ScriptTool
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FilesGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LoadROMButton = new System.Windows.Forms.Button();
            this.SaveROMButton = new System.Windows.Forms.Button();
            this.SaveScriptButton = new System.Windows.Forms.Button();
            this.LoadScriptButton = new System.Windows.Forms.Button();
            this.ROMPathBox = new System.Windows.Forms.TextBox();
            this.EncodingGroup = new System.Windows.Forms.GroupBox();
            this.KRRadio = new System.Windows.Forms.RadioButton();
            this.TBLButton = new System.Windows.Forms.Button();
            this.CustomRadio = new System.Windows.Forms.RadioButton();
            this.JISRadio = new System.Windows.Forms.RadioButton();
            this.ASCIIRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndLabel = new System.Windows.Forms.Label();
            this.OffsetEndBox = new System.Windows.Forms.TextBox();
            this.OffsetStartBox = new System.Windows.Forms.TextBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ScriptExtractButton = new System.Windows.Forms.Button();
            this.ScriptInsertButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.CheckUpButton = new System.Windows.Forms.Button();
            this.ScriptDisplay = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.FilesGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.EncodingGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ScriptDisplay);
            this.splitContainer1.Size = new System.Drawing.Size(792, 371);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FilesGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EncodingGroup, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.08982F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.91018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FilesGroup
            // 
            this.FilesGroup.Controls.Add(this.flowLayoutPanel1);
            this.FilesGroup.Controls.Add(this.ROMPathBox);
            this.FilesGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesGroup.Location = new System.Drawing.Point(3, 3);
            this.FilesGroup.Name = "FilesGroup";
            this.FilesGroup.Size = new System.Drawing.Size(200, 87);
            this.FilesGroup.TabIndex = 0;
            this.FilesGroup.TabStop = false;
            this.FilesGroup.Text = "File Operations";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LoadROMButton);
            this.flowLayoutPanel1.Controls.Add(this.SaveROMButton);
            this.flowLayoutPanel1.Controls.Add(this.SaveScriptButton);
            this.flowLayoutPanel1.Controls.Add(this.LoadScriptButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // LoadROMButton
            // 
            this.LoadROMButton.Image = global::ScriptTool.Properties.Resources.folder;
            this.LoadROMButton.Location = new System.Drawing.Point(3, 3);
            this.LoadROMButton.Name = "LoadROMButton";
            this.LoadROMButton.Size = new System.Drawing.Size(41, 41);
            this.LoadROMButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.LoadROMButton, "Open a ROM for editing.");
            this.LoadROMButton.UseVisualStyleBackColor = true;
            this.LoadROMButton.Click += new System.EventHandler(this.LoadROMButton_Click);
            // 
            // SaveROMButton
            // 
            this.SaveROMButton.Image = global::ScriptTool.Properties.Resources.disk;
            this.SaveROMButton.Location = new System.Drawing.Point(50, 3);
            this.SaveROMButton.Name = "SaveROMButton";
            this.SaveROMButton.Size = new System.Drawing.Size(42, 41);
            this.SaveROMButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.SaveROMButton, "Saves current ROM.");
            this.SaveROMButton.UseVisualStyleBackColor = true;
            // 
            // SaveScriptButton
            // 
            this.SaveScriptButton.Image = global::ScriptTool.Properties.Resources.page_save;
            this.SaveScriptButton.Location = new System.Drawing.Point(98, 3);
            this.SaveScriptButton.Name = "SaveScriptButton";
            this.SaveScriptButton.Size = new System.Drawing.Size(42, 41);
            this.SaveScriptButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.SaveScriptButton, "Saves the script to a file.");
            this.SaveScriptButton.UseVisualStyleBackColor = true;
            this.SaveScriptButton.Click += new System.EventHandler(this.SaveScriptButton_Click);
            // 
            // LoadScriptButton
            // 
            this.LoadScriptButton.Image = global::ScriptTool.Properties.Resources.page_load;
            this.LoadScriptButton.Location = new System.Drawing.Point(146, 3);
            this.LoadScriptButton.Name = "LoadScriptButton";
            this.LoadScriptButton.Size = new System.Drawing.Size(42, 41);
            this.LoadScriptButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.LoadScriptButton, "Load script for insertion.");
            this.LoadScriptButton.UseVisualStyleBackColor = true;
            this.LoadScriptButton.Click += new System.EventHandler(this.LoadScriptButton_Click);
            // 
            // ROMPathBox
            // 
            this.ROMPathBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ROMPathBox.Location = new System.Drawing.Point(3, 16);
            this.ROMPathBox.Name = "ROMPathBox";
            this.ROMPathBox.ReadOnly = true;
            this.ROMPathBox.Size = new System.Drawing.Size(194, 20);
            this.ROMPathBox.TabIndex = 0;
            // 
            // EncodingGroup
            // 
            this.EncodingGroup.Controls.Add(this.KRRadio);
            this.EncodingGroup.Controls.Add(this.TBLButton);
            this.EncodingGroup.Controls.Add(this.CustomRadio);
            this.EncodingGroup.Controls.Add(this.JISRadio);
            this.EncodingGroup.Controls.Add(this.ASCIIRadio);
            this.EncodingGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodingGroup.Location = new System.Drawing.Point(3, 171);
            this.EncodingGroup.Name = "EncodingGroup";
            this.EncodingGroup.Size = new System.Drawing.Size(200, 144);
            this.EncodingGroup.TabIndex = 1;
            this.EncodingGroup.TabStop = false;
            this.EncodingGroup.Text = "Encoding";
            // 
            // KRRadio
            // 
            this.KRRadio.AutoSize = true;
            this.KRRadio.Location = new System.Drawing.Point(8, 68);
            this.KRRadio.Name = "KRRadio";
            this.KRRadio.Size = new System.Drawing.Size(59, 17);
            this.KRRadio.TabIndex = 6;
            this.KRRadio.TabStop = true;
            this.KRRadio.Text = "Korean";
            this.KRRadio.UseVisualStyleBackColor = true;
            // 
            // TBLButton
            // 
            this.TBLButton.Enabled = false;
            this.TBLButton.Location = new System.Drawing.Point(8, 116);
            this.TBLButton.Name = "TBLButton";
            this.TBLButton.Size = new System.Drawing.Size(95, 23);
            this.TBLButton.TabIndex = 5;
            this.TBLButton.Text = "Load TBL File";
            this.TBLButton.UseVisualStyleBackColor = true;
            this.TBLButton.Click += new System.EventHandler(this.TBLButton_Click);
            // 
            // CustomRadio
            // 
            this.CustomRadio.AutoSize = true;
            this.CustomRadio.Location = new System.Drawing.Point(8, 92);
            this.CustomRadio.Name = "CustomRadio";
            this.CustomRadio.Size = new System.Drawing.Size(60, 17);
            this.CustomRadio.TabIndex = 4;
            this.CustomRadio.Text = "Custom";
            this.CustomRadio.UseVisualStyleBackColor = true;
            // 
            // JISRadio
            // 
            this.JISRadio.AutoSize = true;
            this.JISRadio.Location = new System.Drawing.Point(8, 44);
            this.JISRadio.Name = "JISRadio";
            this.JISRadio.Size = new System.Drawing.Size(64, 17);
            this.JISRadio.TabIndex = 1;
            this.JISRadio.TabStop = true;
            this.JISRadio.Text = "Shift JIS";
            this.JISRadio.UseVisualStyleBackColor = true;
            // 
            // ASCIIRadio
            // 
            this.ASCIIRadio.AutoSize = true;
            this.ASCIIRadio.Checked = true;
            this.ASCIIRadio.Location = new System.Drawing.Point(8, 20);
            this.ASCIIRadio.Name = "ASCIIRadio";
            this.ASCIIRadio.Size = new System.Drawing.Size(52, 17);
            this.ASCIIRadio.TabIndex = 0;
            this.ASCIIRadio.TabStop = true;
            this.ASCIIRadio.Text = "ASCII";
            this.ASCIIRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EndLabel);
            this.groupBox1.Controls.Add(this.OffsetEndBox);
            this.groupBox1.Controls.Add(this.OffsetStartBox);
            this.groupBox1.Controls.Add(this.StartLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offsets";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(7, 48);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(29, 13);
            this.EndLabel.TabIndex = 3;
            this.EndLabel.Text = "End:";
            // 
            // OffsetEndBox
            // 
            this.OffsetEndBox.Location = new System.Drawing.Point(40, 44);
            this.OffsetEndBox.Name = "OffsetEndBox";
            this.OffsetEndBox.Size = new System.Drawing.Size(156, 20);
            this.OffsetEndBox.TabIndex = 2;
            // 
            // OffsetStartBox
            // 
            this.OffsetStartBox.Location = new System.Drawing.Point(40, 20);
            this.OffsetStartBox.Name = "OffsetStartBox";
            this.OffsetStartBox.Size = new System.Drawing.Size(156, 20);
            this.OffsetStartBox.TabIndex = 1;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(4, 24);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(32, 13);
            this.StartLabel.TabIndex = 0;
            this.StartLabel.Text = "Start:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ScriptExtractButton);
            this.flowLayoutPanel2.Controls.Add(this.ScriptInsertButton);
            this.flowLayoutPanel2.Controls.Add(this.AboutButton);
            this.flowLayoutPanel2.Controls.Add(this.CheckUpButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 321);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 47);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // ScriptExtractButton
            // 
            this.ScriptExtractButton.Image = global::ScriptTool.Properties.Resources.document_export;
            this.ScriptExtractButton.Location = new System.Drawing.Point(3, 3);
            this.ScriptExtractButton.Name = "ScriptExtractButton";
            this.ScriptExtractButton.Size = new System.Drawing.Size(41, 41);
            this.ScriptExtractButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ScriptExtractButton, "Extracts script from the ROM.");
            this.ScriptExtractButton.UseVisualStyleBackColor = true;
            // 
            // ScriptInsertButton
            // 
            this.ScriptInsertButton.Image = global::ScriptTool.Properties.Resources.document_import;
            this.ScriptInsertButton.Location = new System.Drawing.Point(50, 3);
            this.ScriptInsertButton.Name = "ScriptInsertButton";
            this.ScriptInsertButton.Size = new System.Drawing.Size(42, 41);
            this.ScriptInsertButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.ScriptInsertButton, "Insert script into the ROM.");
            this.ScriptInsertButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Image = global::ScriptTool.Properties.Resources.help;
            this.AboutButton.Location = new System.Drawing.Point(98, 3);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(42, 41);
            this.AboutButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.AboutButton, "About this program.");
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // CheckUpButton
            // 
            this.CheckUpButton.Enabled = false;
            this.CheckUpButton.Image = global::ScriptTool.Properties.Resources.update;
            this.CheckUpButton.Location = new System.Drawing.Point(146, 3);
            this.CheckUpButton.Name = "CheckUpButton";
            this.CheckUpButton.Size = new System.Drawing.Size(42, 41);
            this.CheckUpButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.CheckUpButton, "Check for updates.");
            this.CheckUpButton.UseVisualStyleBackColor = true;
            this.CheckUpButton.Click += new System.EventHandler(this.CheckUpButton_Click);
            // 
            // ScriptDisplay
            // 
            this.ScriptDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptDisplay.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScriptDisplay.Location = new System.Drawing.Point(0, 0);
            this.ScriptDisplay.Name = "ScriptDisplay";
            this.ScriptDisplay.ReadOnly = true;
            this.ScriptDisplay.Size = new System.Drawing.Size(582, 371);
            this.ScriptDisplay.TabIndex = 0;
            this.ScriptDisplay.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 371);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Script Tool";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.FilesGroup.ResumeLayout(false);
            this.FilesGroup.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.EncodingGroup.ResumeLayout(false);
            this.EncodingGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox FilesGroup;
        private System.Windows.Forms.TextBox ROMPathBox;
        private System.Windows.Forms.RichTextBox ScriptDisplay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button LoadROMButton;
        private System.Windows.Forms.Button SaveROMButton;
        private System.Windows.Forms.Button SaveScriptButton;
        private System.Windows.Forms.Button LoadScriptButton;
        private System.Windows.Forms.GroupBox EncodingGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OffsetEndBox;
        private System.Windows.Forms.TextBox OffsetStartBox;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button ScriptExtractButton;
        private System.Windows.Forms.Button ScriptInsertButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton ASCIIRadio;
        private System.Windows.Forms.RadioButton CustomRadio;
        private System.Windows.Forms.RadioButton JISRadio;
        private System.Windows.Forms.Button TBLButton;
        private System.Windows.Forms.RadioButton KRRadio;
        private System.Windows.Forms.Button CheckUpButton;
    }
}

