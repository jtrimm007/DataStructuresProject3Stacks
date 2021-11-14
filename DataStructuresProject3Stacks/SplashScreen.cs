///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Data Structures Project 3 Stacks
//	File Name:         SplashScreen.cs
//	Description:       This is the package for the GUIs, i.e., Windows Forms display classes.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           11/13/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace DataStructuresProject3Stacks
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="SplashScreen" />.
    /// </summary>
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashScreen"/> class.
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            this.Text = String.Format("Splash {0}", Application.ProductName);
        }

        /// <summary>
        /// The SplashScreen_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Version.Text = $"Version {Application.ProductVersion}";
            this.ProjectName.Text = $"{Application.ProductName}";
        }

        /// <summary>
        /// The timer1_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
