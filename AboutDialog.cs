﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptTool
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            ProductLabel.Text = Application.ProductName;
            VersionLabel.Text = Application.ProductVersion;
            VendorLabel.Text = Application.CompanyName;
        }
    }
}
