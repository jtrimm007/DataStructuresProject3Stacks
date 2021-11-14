///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Data Structures Project 3 Stacks
//	File Name:         Tool.cs
//	Description:       This tool class was pulled from a previous project and was mainly used to tokenize and evaluate strings. 
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           11/13/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Tools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Tool" />.
    /// </summary>
    public static class Tool
    {
        /// <summary>
        /// The RemoveAllSpacesFromList removes all the spaces from the list.
        /// </summary>
        /// <param name="words">The words<see cref="List{string}"/>.</param>
        /// <returns>A <see cref="List{string}"/> with no spaces in the list.</returns>
        private static List<string> RemoveAllSpacesFromList(List<string> words)
        {
            // Loop through the list of word to see if any spaces where defined as words
            for (var i = 0; i < words.Count; i++)
            {
                if (words[i] == " ")
                {
                    // Remove the space if found
                    words.RemoveAt(i);
                }
            }

            // Return the updated List of words. 
            return words;
        }

        /// <summary>
        /// The Tokenize method takes a string and breaks the string into words based on the delimiters parameter.
        /// </summary>
        /// <param name="original">The original<see cref="string"/>.</param>
        /// <param name="delimiters">The delimiters<see cref="string"/>.</param>
        /// <returns>A <see cref="List{String}"/> of words.</returns>
        public static List<String> Tokenize(string original, string delimiters)
        {
            // Make a shallow copy to work with. 
            string workTemp = original;


            // Instantiate a List to add the words to later
            List<string> words = new List<string>();

            // while there is still charters in the string; loop. 
            while (workTemp != string.Empty)
            {
                // Get the position of the next delimiter.
                int indexOfDelimiter = workTemp.IndexOfAny(delimiters.ToCharArray());

                // If workTemp does not start with a delimiter
                if (indexOfDelimiter > 0)
                {


                    // Add the word to the list of words
                    words.Add(workTemp.Substring(0, indexOfDelimiter));

                    // Add the delimiter as a word to the list of words
                    words.Add(workTemp.ElementAt(indexOfDelimiter).ToString());

                    // Remove the word and the delimiter
                    workTemp = workTemp.Substring(indexOfDelimiter + 1).Trim();
                }

                // If a delimiter is in index 0
                if (indexOfDelimiter == 0)
                {
                    // Add the delimiter as a string to the words list
                    words.Add(workTemp.ElementAt(0).ToString());

                    // Remove the delimiter from the workTemp string
                    workTemp = workTemp.Substring(1).Trim();
                }

                // If there are no more delimiters left
                if (indexOfDelimiter == -1)
                {
                    // add the remaining as one word to the list of words
                    words.Add(workTemp);

                    // remove the last characters from the string
                    workTemp = string.Empty;
                }
            }

            // Remove all the spaces that are listed in the List of strings. 
            words = RemoveAllSpacesFromList(words);

            // Return the List of words. 
            return words;
        }

        /// <summary>
        /// The CleanString returns a string that has been cleansed.
        /// </summary>
        /// <param name="work">The work<see cref="string"/>.</param>
        /// <returns>A cleaned <see cref="string"/>.</returns>
        public static string CleanString(ref string work)
        {

            // Remove all the whitespace
            work = work.Trim();

            // Remove any leading or trailing tabs
            work = work.Trim('\t');

            // Replace any carriage -return, new line combinations(“\r\n”) with a new line(“\n”) character.
            work = work.Replace(@"\r\n", @"\n");

            // Return the cleaned string
            return work;
        }

        /// <summary>
        /// The CleanList.
        /// </summary>
        /// <param name="list">The list<see cref="List{string}"/>.</param>
        /// <returns>The <see cref="List{string}"/>.</returns>
        public static List<string> CleanList(List<string> list)
        {
            list.RemoveAll(RemoveReturns);

            for (var i = 0; i < list.Count; i++)
            {
                string temp = list[i];
                list[i] = CleanString(ref temp);
            }

            return list;
        }

        /// <summary>
        /// The RemoveReturns.
        /// </summary>
        /// <param name="stringCheck">The stringCheck<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool RemoveReturns(string stringCheck)
        {
            return stringCheck == "\r";
        }
    }
}
