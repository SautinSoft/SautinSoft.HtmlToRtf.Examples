﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SautinSoft;
using System.IO;
using static SautinSoft.HtmlToRtf;

namespace Convert_HTML_to_WPF_RichTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Converts HTML document to RTF format; Places this RTF in RichTextBox;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            string htmlFile = @"..\..\Sample.html";
            string rtfString = String.Empty;

            // Create an instance of the converter.
            SautinSoft.HtmlToRtf h = new HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf;

            opt.TextSetup.DefaultFontFamily = "Calibri";

            // Convert HTML to RTF.
            using (FileStream fs = new FileStream(htmlFile, FileMode.Open, FileAccess.Read))
            { 
                using (MemoryStream msRtf = new MemoryStream())
                {
                    // Convert HTML to RTF.
                    if (h.Convert(fs, msRtf, opt))
                    {
                        // Place the RTF into RichTextBox.
                        System.Windows.Documents.TextRange tr = new System.Windows.Documents.TextRange(
                           RtfControl.Document.ContentStart, RtfControl.Document.ContentEnd);
                        tr.Load(msRtf, DataFormats.Rtf);
                    }
                }                
            }            
        }
    }
}
