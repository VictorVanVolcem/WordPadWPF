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
            UpdateTitle();
        }

        // File menu
        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            // Check if there is unsaved progress before closing
            if (!_document.Match)
            {
                var response = MessageBox.Show("Do you want to save your changes before closing?", "Unsaved changes", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);

                if (response == MessageBoxResult.No)
                {
                    NewDocument();
                }
                else if (response == MessageBoxResult.Yes)
                {
                    try
                    {
                        Save();
                        NewDocument();
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                NewDocument();
            }
        }
    
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
                    _document.Content = FileReader.ReadToEnd();
                    txtWordpad.Text = _document.Content;

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
            Save();
        }
        private void mnuSaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveAs();
        }
        private void MnuExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
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
        private void txtWordpad_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Check if we have unsaved content
            if(txtWordpad.Text != _document.Content)
            {
                _document.Match = false;
            }
            else
            {
                _document.Match = true;
            }

            // Check if the title needs to update
            UpdateTitle();
        }
        private void wndMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Check if there is unsaved progress before closing
            if (!_document.Match)
            {
                e.Cancel = true;
                var response = MessageBox.Show("Do you want to save your changes before closing?", "Unsaved changes", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);

                if (response == MessageBoxResult.No)
                {
                    Environment.Exit(0);
                }
                else if (response == MessageBoxResult.Yes)
                {
                    try
                    {
                        Save();
                        Environment.Exit(0);
                    }
                    catch
                    {
                    }
                }
            }
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
        private void Save()
        {
            // Check if the file already exists
            if (_document.Path != null)
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

            UpdateTitle();
        }
        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files | *.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.ShowDialog();

            try
            {
                if (saveFileDialog.FileName != null)
                {
                    // Save file data in document
                    _document.Path = saveFileDialog.FileName;
                    _document.Title = saveFileDialog.SafeFileName;
                    _document.Content = txtWordpad.Text;

                    // Save document in our system
                    StreamWriter sw = new StreamWriter(_document.Path);
                    sw.Write(_document.Content);

                    sw.Close();

                    _document.Match = true;
                }
            }
            catch
            {
            }
            
            UpdateTitle();
        }
        private void UpdateTitle()
        {
            if(_document.Match)
            {
                Title = _document.Title + " - NotePad";
            }
            else
            {
                Title = _document.Title + "* - NotePad";
            }
        }
        private void NewDocument()
        {
            _document = new Document();
            txtWordpad.Text = "";
            UpdateTitle();
        }
    }
}
