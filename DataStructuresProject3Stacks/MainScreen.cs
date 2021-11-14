///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Data Structures Project 3 Stacks
//	File Name:         MainScreen.cs
//	Description:       This is the package for the GUIs, i.e., Windows Forms display classes.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           11/13/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace DataStructuresProject3Stacks
{
    using LibraryManagement;
    using System;
    using System.Windows.Forms;
    using Tool;

    /// <summary>
    /// Defines the <see cref="MainScreen" />.
    /// </summary>
    public partial class MainScreen : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainScreen"/> class.
        /// </summary>
        public MainScreen()
        {
            InitializeComponent();

            // Label the window in the top right corner. 
            this.Text = String.Format("Joshua Trimm - {0}", Application.ProductName);
        }

        /// <summary>
        /// The aboutInfixToPostfixToolStripMenuItem_Click is an event listener that listens for the user to click on the about selection.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void aboutInfixToPostfixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate a new About window.
            About aboutBox = new About();

            // then show the about window. 
            aboutBox.Show(this);
        }

        /// <summary>
        /// The exitToolStripMenuItem_Click is an event listener that evaluates if a user click to exit the program from the Tool Strip Menu.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The GeneratePostfixButton_Click is an event listener that evaluates if the user click to evaluate an expression.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void GeneratePostfixButton_Click(object sender, EventArgs e)
        {
            // Instantiate the PostFix class by passing in the express to be evaluated.
            PostFix postFix = new PostFix(this.InfixInputBox.Text);

            // convert the expression into a PostFix string and display it in the PostFixInputBox.
            this.PostFixInputBox.Text = postFix.Convert();
        }

        /// <summary>
        /// The ExitButton_Click evaluates when a user click the exit button to close the program.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The iNputInfixDataFileToolStripMenuItem_Click is an event listener that evaluates when a user click to open a file. This method opens the Open File Dialog box for the user to chose an Infix file.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void iNputInfixDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display to open file dialog box
            FileManager.OpenFileAndSetTextToGlobalProperty();

            // Tokenize the text from the opened file and store the list of tokens in the listOfEquasions variable.
            var listOfEquasions = Tools.Tool.Tokenize(FileManager.TextFromFile, System.Environment.NewLine);

            // clean the list by removing all the \r. 
            var cleanedList = Tools.Tool.CleanList(listOfEquasions);
            this.InfixDataField.Items.AddRange(cleanedList.ToArray());
        }

        /// <summary>
        /// The InfixDataField_Click evaluates when a user click on an express in the Infix Data Field and displays the selected equation in the InfixInputBox.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void InfixDataField_Click(object sender, EventArgs e)
        {
            if (InfixDataField.SelectedIndex == -1 || InfixDataField.SelectedIndex == null)
                return;

            this.InfixInputBox.Text = InfixDataField.SelectedItem.ToString();
        }

        /// <summary>
        /// The ClearButton_Click is an event listener that evaluates when the user click the clear button. Upon click text in the PostFixInputBox and InfixInputBox are removed.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.PostFixInputBox.Text = String.Empty;
            this.InfixInputBox.Text = String.Empty;
        }
    }
}
