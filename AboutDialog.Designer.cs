/*
 * Created by SharpDevelop.
 * User: April Horne
 * Date: 1/26/2015
 * Time: 11:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ScriptTool
{
	partial class AboutDialog
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.AppNameBox = new System.Windows.Forms.TextBox();
			this.DeveloperBox = new System.Windows.Forms.TextBox();
			this.YupButton = new System.Windows.Forms.Button();
			this.VersionBox = new System.Windows.Forms.TextBox();
			this.ProductLabel = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.VendorLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ScriptTool.Properties.ScriptTool.selfie;
			this.pictureBox1.Location = new System.Drawing.Point(4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 300);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// AppNameBox
			// 
			this.AppNameBox.Location = new System.Drawing.Point(260, 4);
			this.AppNameBox.Name = "AppNameBox";
			this.AppNameBox.ReadOnly = true;
			this.AppNameBox.Size = new System.Drawing.Size(124, 20);
			this.AppNameBox.TabIndex = 1;
			// 
			// DeveloperBox
			// 
			this.DeveloperBox.Location = new System.Drawing.Point(260, 52);
			this.DeveloperBox.Name = "DeveloperBox";
			this.DeveloperBox.ReadOnly = true;
			this.DeveloperBox.Size = new System.Drawing.Size(124, 20);
			this.DeveloperBox.TabIndex = 2;
			// 
			// YupButton
			// 
			this.YupButton.Location = new System.Drawing.Point(284, 280);
			this.YupButton.Name = "YupButton";
			this.YupButton.Size = new System.Drawing.Size(99, 23);
			this.YupButton.TabIndex = 3;
			this.YupButton.Text = "Thanks Cutie!";
			this.YupButton.UseVisualStyleBackColor = true;
			this.YupButton.Click += new System.EventHandler(this.YupButton_Click);
			// 
			// VersionBox
			// 
			this.VersionBox.Location = new System.Drawing.Point(260, 28);
			this.VersionBox.Name = "VersionBox";
			this.VersionBox.ReadOnly = true;
			this.VersionBox.Size = new System.Drawing.Size(124, 20);
			this.VersionBox.TabIndex = 4;
			// 
			// ProductLabel
			// 
			this.ProductLabel.AutoSize = true;
			this.ProductLabel.Location = new System.Drawing.Point(209, 8);
			this.ProductLabel.Name = "ProductLabel";
			this.ProductLabel.Size = new System.Drawing.Size(47, 13);
			this.ProductLabel.TabIndex = 5;
			this.ProductLabel.Text = "Product:";
			// 
			// VersionLabel
			// 
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.Location = new System.Drawing.Point(211, 32);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(45, 13);
			this.VersionLabel.TabIndex = 6;
			this.VersionLabel.Text = "Version:";
			// 
			// VendorLabel
			// 
			this.VendorLabel.AutoSize = true;
			this.VendorLabel.Location = new System.Drawing.Point(212, 56);
			this.VendorLabel.Name = "VendorLabel";
			this.VendorLabel.Size = new System.Drawing.Size(44, 13);
			this.VendorLabel.TabIndex = 7;
			this.VendorLabel.Text = "Vendor:";
			// 
			// AboutDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 308);
			this.Controls.Add(this.VendorLabel);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.ProductLabel);
			this.Controls.Add(this.VersionBox);
			this.Controls.Add(this.YupButton);
			this.Controls.Add(this.DeveloperBox);
			this.Controls.Add(this.AppNameBox);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.ShowInTaskbar = false;
			this.Text = "About Script Tool";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label VendorLabel;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label ProductLabel;
		private System.Windows.Forms.TextBox VersionBox;
		private System.Windows.Forms.Button YupButton;
		private System.Windows.Forms.TextBox DeveloperBox;
		private System.Windows.Forms.TextBox AppNameBox;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
