/*
 * Created by SharpDevelop.
 * User: April Horne
 * Date: 1/27/2015
 * Time: 12:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.IO;

namespace ScriptTool
{
	/// <summary>
	/// Description of ROMProperties.
	/// </summary>
	public class ROMProperties
	{
		[Category("File Operations")]
		[Browsable(true)]
		[Description("Load ROM to dump the script from")]
		[DisplayName("Editing")]
		[EditorAttribute(typeof(FileNameEditor), typeof(UITypeEditor))]
		public string CurrentROMLoaded
		{
			get
			{
				return game;
			}
			set
			{
				game = value;
			}
		}
		private string game;
		
		int StartOffset = 0x00000
		[Category("Dumping")]
		[Browsable(true)]
		[DisplayName("Start Offset")]
		public int OffestStart
		{
			get
			{
				return StartOffset;
			}
			set
			{
				StartOffset = value;
			}
		}
		
		int EndingOffset = 0x00000;
		[Category("Dumping")]
		[Browsable(true)]
		[DisplayName("Ending Offset")]
		public int OffsetEnd
		{
			get
			{
				return EndingOffset;
			}
			set
			{
				EndingOffset = value;
			}
		}
		
		Encoding enc;
		[DisplayName("Encoding")]
		[Description("Encoding the script is in")]
		[Category("Encoding")]
		[TypeConverter(typeof(EncodingConverter))]
		public Encoding encdr
		{
			get
			{
				return enc;
			}
			set
			{
				enc = value;
			}
		}
	}
}
