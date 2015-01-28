/*
 * Created by SharpDevelop.
 * User: April Horne
 * Date: 1/26/2015
 * Time: 9:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ScriptTool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ROMPropertiesGrid = new System.Windows.Forms.PropertyGrid();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.LoadScript = new System.Windows.Forms.Button();
			this.SaveScript = new System.Windows.Forms.Button();
			this.AboutButton = new System.Windows.Forms.Button();
			this.ScriptDisplay = new System.Windows.Forms.RichTextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.splitContainer1.Size = new System.Drawing.Size(792, 573);
			this.splitContainer1.SplitterDistance = 280;
			this.splitContainer1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.ROMPropertiesGrid, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.42211F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57789F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 573);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ROMPropertiesGrid
			// 
			this.ROMPropertiesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ROMPropertiesGrid.Location = new System.Drawing.Point(3, 3);
			this.ROMPropertiesGrid.Name = "ROMPropertiesGrid";
			this.tableLayoutPanel1.SetRowSpan(this.ROMPropertiesGrid, 2);
			this.ROMPropertiesGrid.Size = new System.Drawing.Size(274, 515);
			this.ROMPropertiesGrid.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.LoadScript);
			this.flowLayoutPanel1.Controls.Add(this.SaveScript);
			this.flowLayoutPanel1.Controls.Add(this.AboutButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 524);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(274, 46);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// LoadScript
			// 
			this.LoadScript.Image = global::ScriptTool.Properties.ScriptTool.folder;
			this.LoadScript.Location = new System.Drawing.Point(3, 3);
			this.LoadScript.Name = "LoadScript";
			this.LoadScript.Size = new System.Drawing.Size(41, 41);
			this.LoadScript.TabIndex = 0;
			this.toolTip1.SetToolTip(this.LoadScript, "Loads a script to insert.");
			this.LoadScript.UseVisualStyleBackColor = true;
			// 
			// SaveScript
			// 
			this.SaveScript.Image = global::ScriptTool.Properties.ScriptTool.disk;
			this.SaveScript.Location = new System.Drawing.Point(50, 3);
			this.SaveScript.Name = "SaveScript";
			this.SaveScript.Size = new System.Drawing.Size(42, 41);
			this.SaveScript.TabIndex = 1;
			this.toolTip1.SetToolTip(this.SaveScript, "Saves a script to a file.");
			this.SaveScript.UseVisualStyleBackColor = true;
			this.SaveScript.Click += new System.EventHandler(this.SaveScript_Click);
			// 
			// AboutButton
			// 
			this.AboutButton.Image = global::ScriptTool.Properties.ScriptTool.help;
			this.AboutButton.Location = new System.Drawing.Point(98, 3);
			this.AboutButton.Name = "AboutButton";
			this.AboutButton.Size = new System.Drawing.Size(42, 41);
			this.AboutButton.TabIndex = 2;
			this.toolTip1.SetToolTip(this.AboutButton, "About this program.");
			this.AboutButton.UseVisualStyleBackColor = true;
			this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
			// 
			// ScriptDisplay
			// 
			this.ScriptDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ScriptDisplay.Location = new System.Drawing.Point(0, 0);
			this.ScriptDisplay.Name = "ScriptDisplay";
			this.ScriptDisplay.Size = new System.Drawing.Size(508, 573);
			this.ScriptDisplay.TabIndex = 0;
			this.ScriptDisplay.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.Add(this.splitContainer1);
			this.Icon = global::ScriptTool.Properties.ScriptTool.princess;
			this.Name = "MainForm";
			this.Text = "Script Tool";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button AboutButton;
		private System.Windows.Forms.RichTextBox ScriptDisplay;
		private System.Windows.Forms.Button SaveScript;
		private System.Windows.Forms.Button LoadScript;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.PropertyGrid ROMPropertiesGrid;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
