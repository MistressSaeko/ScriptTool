/*
 * Created by SharpDevelop.
 * User: April Horne
 * Date: 1/26/2015
 * Time: 11:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScriptTool
{
	/// <summary>
	/// Description of AboutDialog.
	/// </summary>
	public partial class AboutDialog : Form
	{
		public AboutDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			AppNameBox.Text   = Application.ProductName;
			VersionBox.Text   = Application.ProductVersion;
			DeveloperBox.Text = Application.CompanyName;
		}
		
		void YupButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
