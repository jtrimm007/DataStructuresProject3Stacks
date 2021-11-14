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
            this.Text = String.Format("About {0}", Application.ProductName);
        }

        /// <summary>
        /// The aboutInfixToPostfixToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void aboutInfixToPostfixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox = new About();
            aboutBox.Show(this);
        }

        /// <summary>
        /// The exitToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The GeneratePostfixButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void GeneratePostfixButton_Click(object sender, EventArgs e)
        {

            PostFix postFix = new PostFix(this.InfixInputBox.Text);
            this.PostFixInputBox.Text = postFix.Convert();
        }

        /// <summary>
        /// The ExitButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The iNputInfixDataFileToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void iNputInfixDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.OpenFileAndSetTextToGlobalProperty();
            var text = FileManager.TextFromFile;

            var listOfEquasions = Tools.Tool.Tokenize(FileManager.TextFromFile, System.Environment.NewLine);

            var cleanedList = Tools.Tool.CleanList(listOfEquasions);
            this.InfixDataField.Items.AddRange(cleanedList.ToArray());
        }

        /// <summary>
        /// The InfixDataField_Click.
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
        /// The ClearButton_Click.
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
