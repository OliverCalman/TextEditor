using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        private string currentFile;
        private string currentUser;
        private string user;
        private string type;

        public string CurrentFile
        {
            get { return currentFile; }
            set { currentFile = value; }
        }
        public string CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private Boolean FileSaved { get; set; }

        public TextEditor(string currentuser, string name, string type)
        {
            InitializeComponent();

            //set user name in label
            userNameLabel.Text = "User Name: " + name;
            //set success label to blank 
            SuccessLabel.Text = "";

            //set user name and user type attributes
            User = name;
            Type = type;
            currentUser = currentuser;

            CheckUser();

        }

        private void CheckUser()
        {
            //check user type. If user type is not Edit then disable all controls except open, save as, help, copy
            if (Type != "Edit")
            {
                //set Filesaved bool to true so save functions are not hit
                FileSaved = true;

                //set all inputs to readonly/enabled false
                TextBox.ReadOnly = true;

                NewButton.Enabled = false;
                newToolStripMenuItem.Enabled = false;

                SaveButton.Enabled = false;
                saveToolStripMenuItem.Enabled = false;

                CutButton.Enabled = false;
                cutToolStripMenuItem.Enabled = false;

                PasteButton.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;

                //disable formatting buttons
                BoldButton.Enabled = false;
                ItalicButton.Enabled = false;
                UnderlineButton.Enabled = false;
                FontSizeComboBox.Enabled = false;
                ClearFormatButton.Enabled = false;
            }
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            //check if text is already bold
            if (TextBox.SelectionFont.Bold)
            {
                //check if text already has other formatting. Apply the existing formatting and remove the bold style
                if (TextBox.SelectionFont.Italic && TextBox.SelectionFont.Underline)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Italic | FontStyle.Underline);
                }
                else if (TextBox.SelectionFont.Italic)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Italic);
                }
                else if (TextBox.SelectionFont.Underline)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Underline);
                }
                else
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Regular);
                }
            }
            else
            {
                //check if the text already has other formatting, apply the existing formatting as well as the bold formatting
                if (TextBox.SelectionFont.Italic && TextBox.SelectionFont.Underline)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Italic | FontStyle.Underline | FontStyle.Bold);
                }
                else if (TextBox.SelectionFont.Italic)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Italic | FontStyle.Bold);
                }
                else if (TextBox.SelectionFont.Underline)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Underline | FontStyle.Bold);
                }
                else
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style | FontStyle.Bold);
                }
            }
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            //check if text is already italic
            if (TextBox.SelectionFont.Italic)
            {
                //check if text already has other formatting. Apply the existing formatting and remove the italic style
                if (TextBox.SelectionFont.Bold && TextBox.SelectionFont.Underline)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Bold | FontStyle.Underline);
                }
                else if (TextBox.SelectionFont.Bold)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Bold);
                }
                else if (TextBox.SelectionFont.Underline)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Underline);
                }
                else
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Regular);
                }
            }
            else
            {
                //check if the text already has other formatting, apply the existing formatting as well as the italic formatting
                if (TextBox.SelectionFont.Bold && TextBox.SelectionFont.Underline)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                else if (TextBox.SelectionFont.Bold)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Bold | FontStyle.Italic);
                }
                else if (TextBox.SelectionFont.Underline)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Underline | FontStyle.Italic);
                }
                else
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style | FontStyle.Italic);
                }
            }
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            //check if text is already Underline
            if (TextBox.SelectionFont.Underline)
            {
                //check if text already has other formatting. Apply the existing formatting and remove the Underline style
                if (TextBox.SelectionFont.Bold && TextBox.SelectionFont.Italic)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Bold | FontStyle.Italic);
                }
                else if (TextBox.SelectionFont.Bold)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Bold);
                }
                else if (TextBox.SelectionFont.Italic)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Italic);
                }
                else
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Regular);
                }
            }
            else
            {
                //check if the text already has other formatting, apply the existing formatting as well as the Underline formatting
                if (TextBox.SelectionFont.Bold && TextBox.SelectionFont.Italic)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                else if (TextBox.SelectionFont.Bold)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Bold | FontStyle.Underline);
                }
                else if (TextBox.SelectionFont.Italic)
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & FontStyle.Italic | FontStyle.Underline);
                }
                else
                {
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style | FontStyle.Underline);
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //if text changed then prompt then set unsaved boolean to true/saved bool to false to prompt save on exit
            FileSaved = false;
        }

        private void OpenHelpView(object sender, EventArgs e)
        {
            Help form = new Help();
            form.Show();
        }

        private void ChangeSelectedFontSize(object sender, EventArgs e)
        {
            int fontsize;

            try
            {
                //convert combobox text to int
                fontsize = Convert.ToInt32(FontSizeComboBox.Text);

                if (fontsize <= 6 || fontsize > 72)
                {
                    //set input to null if it's invalid
                    this.FontSizeComboBox.Text = null;
                }
                else
                {
                    // Update the selected text font size
                    TextBox.SelectionFont = new Font(TextBox.SelectionFont.FontFamily, fontsize, TextBox.SelectionFont.Style);
                }
            }
            catch
            {
                //set input to null if it's invalid
                this.FontSizeComboBox.Text = null;
            }

        }

        private void ClearSelectedFormat(object sender, EventArgs e)
        {
            //resets the formatting back to the base format for the selected text
            TextBox.SelectionFont = new Font("Times New Roman", 10, FontStyle.Regular);
            FontSizeComboBox.Text = "10";
        }

        //triggers use generic methods while also enabling subscription to events
        private void NewFileTrigger(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpenTrigger(object sender, EventArgs e)
        {
            Open();
        }
        private void SaveTrigger(object sender, EventArgs e)
        {
            Save();
        }
        private void SaveAsTrigger(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void NewFile()
        {
            //if checkbox has input already and is UNSAVED, prompt to save
            if (CurrentFile != null)
            {
                if (FileSaved == false)
                {
                    //prompt user to save
                    bool result = PromptSave();

                    if (result)
                    {
                        Save();
                    }
                }

                //then clear the file
                TextBox.Clear();

                //set currentfile path to null then refresh window to erase filename in title
                CurrentFile = null;
                this.Text = "TextEditor";
                this.Update();
            }
            else
            //prompt to save if the input isn't empty and there's no existing file open
            {
                if (!String.IsNullOrEmpty(TextBox.Text))
                {
                    //prompt user to save
                    bool result = PromptSave();

                    if (result)
                    {
                        Save();
                    }
                }

                TextBox.Clear();

            }
        }
        private void Open()
        {

            //show open dialog and restrict the available file types
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                        {
                            TextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                        }
                        if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                        {
                            TextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        }

                        FileSaved = true;
                        //get filename of opened file and set as a global attribute
                        CurrentFile = openFileDialog.FileName;
                        this.Text = "TextEditor | " + CurrentFile;
                        this.Update();

                    }
                }
                catch (IOException)
                {
                    //show error dialog if unable to read file
                    MessageBox.Show("Unable to read the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    //do nothing :)
                    //allows the user to cancel opening a file without breaking
                }
            }
        }

        private bool PromptSave()
        {
            var result = MessageBox.Show("The current file has unsaved changes. Would you like to save?", "Save File?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Save()
        {

            if (String.IsNullOrEmpty(CurrentFile))
            {
                SaveAs();              
            }
            else
            {
                if (FileSaved == false)
                {
                    try
                    {
                        if (Path.GetExtension(CurrentFile) == ".rtf")
                        {
                            TextBox.SaveFile(CurrentFile, RichTextBoxStreamType.RichText);
                        }
                        else if (Path.GetExtension(CurrentFile) == ".txt")
                        {
                            TextBox.SaveFile(CurrentFile, RichTextBoxStreamType.PlainText);
                        }

                        FileSaved = true;
                        RegisterSuccess();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("The file is in use by another process. Close the file and try again.", "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Error saving a blank file", "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }
        private void SaveAs()
        {
            //save as the text file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";

            try
            {

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                    {
                        TextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                    {
                        TextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    }

                    CurrentFile = saveFileDialog.FileName;
                    FileSaved = true;
                    this.Text = "TextEditor | " + CurrentFile;
                    this.Update();
                    RegisterSuccess();

                }
            }
            catch (ArgumentException)
            {
                //do nothing :)
                //allows the user to cancel saving a file without breaking
            }

        }

        private void RegisterSuccess()
        {
            //set label to show success message
            SuccessLabel.Text = "File was successfully saved";

            //create a timer and trigger change in success message after 3 seconds
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Enabled = true;
            timer.Tick += new System.EventHandler(this.ClearSuccessMessage);

            timer.Start();
        }

        private void ClearSuccessMessage(object sender, System.EventArgs e)
        {
            //change message text to null when timer tick event occurs
            SuccessLabel.Text = "";
        }

        private void Cut(object sender, EventArgs e)
        {
            //get the selected text, add it to the clipboard then remove the selected text from the file
            TextBox.Cut();
        }

        private void Copy(object sender, EventArgs e)
        {
            //get the selected text and add it to the clipboard
            TextBox.Copy();
        }

        private void Paste(object sender, EventArgs e)
        {
            //paste the contents of the clipboard here
            TextBox.Paste();
        }

        private void HotKey_Handler(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                Save();
                e.SuppressKeyPress = true;
            }
            else if(e.Control && e.KeyCode == Keys.N)       // Ctrl-N New
            {
                NewFile();
                e.SuppressKeyPress = true; 
            }
            else if(e.Control && e.KeyCode == Keys.O)       // Ctrl-O Open
            {
                Open();
                e.SuppressKeyPress = true;
            }

        }

        private void LogOut(object sender, EventArgs e)
        {

            if (FileSaved)
            {
                //show login form and close the current instance of the editor
                Login form = new Login();
                form.Show();
                this.Close();
            }
            else
            {
                if (String.IsNullOrEmpty(CurrentFile) && String.IsNullOrEmpty(TextBox.Text) == false)
                {
                    //prompt user to save
                    bool result = PromptSave();

                    if (result)
                    {
                        Save();
                    }
                }
                //show login form and close the current instance of the editor
                Login form = new Login();
                form.Show();
                this.Close();
            }


        }

        private void SystemExit(object sender, EventArgs e)
        {
            //prompt to save if changes made, otherwise exit
            if (FileSaved)
            {
                Application.Exit();
            }
            else
            {
                if (String.IsNullOrEmpty(CurrentFile) && String.IsNullOrEmpty(TextBox.Text) == false)
                {
                    //prompt user to save
                    bool result = PromptSave();

                    if (result)
                    {
                        Save();
                    }

                }
                //exit once save is complete or user has declined
                Application.Exit();
            }

        }
    }
}
