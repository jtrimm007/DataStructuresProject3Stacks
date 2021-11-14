///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Data Structures Project 3 Stacks
//	File Name:         Program.cs
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
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Add the splash screen.
            Application.Run(new SplashScreen());
            Application.Run(new MainScreen());
        }
    }
}
