/*
 * Created by SharpDevelop.
 * User: April Horne
 * Date: 1/27/2015
 * Time: 5:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Collections;
using System.Text;

namespace ScriptTool
{
	/// <summary>
	/// Description of EncodingEnum.
	/// </summary>
	public enum Encoding
		{
			[Description("ASCII")]
			ascii,
			[Description("Shift JIS")]
			sjis,
			[Description("EUC-KR")]
			kr,
			[Description("Unicode UTF-8")]
			utf8
		}
}
