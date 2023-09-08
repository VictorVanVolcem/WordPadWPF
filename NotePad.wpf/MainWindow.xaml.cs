using Microsoft.Win32;
using NotePad.wpf.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace NotePad.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Document _document = new Document();
        public MainWindow()
        {
            InitializeComponent();
        }

        // File menu
        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            // Open a file dialog so we can select our text doc
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            try
            {
                // If a correct file is selected
                if (openFileDialog.FileName != null)
                {
                    // Save document data
                    _document.Path = openFileDialog.FileName;
                    _document.Title = openFileDialog.SafeFileName;
                    _document.Match = true;

                    // Show the file text in the notepad area
                    StreamReader FileReader = new StreamReader(openFileDialog.FileName);
                    var documentContent = FileReader.ReadToEnd();
                    txtWordpad.Text = documentContent;

                    // Set the window title to the text doc title
                    wndMainWindow.Title = _document.Title + " - NotePad";

                    FileReader.Close();
                }
            }
            catch
            {
            }

        }
        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            // Check if the file already exists
            if(_document.Path != string.Empty)
            {
                // If so, get the path
                StreamWriter saveFileStream = new StreamWriter(_document.Path);
                // Overwrite the current content with the text in the notepad
                _document.Content = txtWordpad.Text;
                // Save the new file
                saveFileStream.Write(_document.Content);
                saveFileStream.Close();
            }
            else
            {
                SaveAs();
            }
        }
        private void mnuSaveAs_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MnuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // View menu
        private void MnuWordWrap_Click(object sender, RoutedEventArgs e)
        {
            //txtWordpad.TextWrapping = txtWordpad.TextWrapping == TextWrapping.Wrap ? TextWrapping.NoWrap : TextWrapping.Wrap;
            
            if (txtWordpad.TextWrapping == TextWrapping.Wrap)
                txtWordpad.TextWrapping = TextWrapping.NoWrap;
            else
                txtWordpad.TextWrapping = TextWrapping.Wrap;
        }
        private void MnuStatusBar_Click(object sender, RoutedEventArgs e)
        {
            if (rowFooter.Height == new GridLength(0))
                rowFooter.Height = new GridLength(32);
            else
                rowFooter.Height = new GridLength(0);
        }


        // Wordpad events
        private void txtWordpad_KeyUp(object sender, KeyEventArgs e)
        {
            CheckWordpadLineIndex();
            CheckWordpadColumnIndex();
        }
        private void txtWordpad_MouseMove(object sender, MouseEventArgs e)
        {
            CheckWordpadLineIndex();
            CheckWordpadColumnIndex();
        }


        // Custom methodes
        private void CheckWordpadLineIndex()
        {
            // get the lenght of the current text 
            int intLine = txtWordpad.LineCount - 1;

            // set it as the new line index
            lblLineCount.Text = intLine.ToString();
        }
        private void CheckWordpadColumnIndex()
        {
            // get the lenght of the current text 
            int intColumn = txtWordpad.CaretIndex;

            // set it as the new line index
            lblColumnCount.Text = intColumn.ToString();
        }
        private void SaveAs()
        {

        }

    }
}
