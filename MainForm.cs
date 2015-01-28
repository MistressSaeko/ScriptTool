/*
 * Created by SharpDevelop.
 * User: April Horne
 * Date: 1/26/2015
 * Time: 9:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScriptTool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			ROMProperties prop = new ROMProperties();
			ROMPropertiesGrid.SelectedObject = prop;
		}
		
		void AboutButton_Click(object sender, EventArgs e)
		{
			AboutDialog sexy = new AboutDialog();
			
			if (sexy.ShowDialog(this) == DialogResult.OK)
			{
				sexy.Close();
			}
		}
		
		void SaveScript_Click(object sender, EventArgs e)
		{
			SaveFileDialog script = new SaveFileDialog();
			
		}
	}
}
