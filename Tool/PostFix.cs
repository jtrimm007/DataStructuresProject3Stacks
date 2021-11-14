///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Data Structures Project 3 Stacks
//	File Name:         PostFix.cs
//	Description:       YOUR DESCRIPTION HERE
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           11/13/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Tool
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="PostFix" />.
    /// </summary>
    public class PostFix
    {
        //private char[] StringOperations = { '+', '-', '*', '/', '(', ')', '='};
        /// <summary>
        /// Defines the StringOperations.
        /// </summary>
        private string StringOperations = "+-*/()=";

        /// <summary>
        /// Gets or sets the InfixExpression.
        /// </summary>
        public string InfixExpression { get; set; }

        /// <summary>
        /// Gets or sets the PostFixExpression.
        /// </summary>
        public string PostFixExpression { get; set; } = null;

        /// <summary>
        /// Gets or sets the InfixAsCharArray.
        /// </summary>
        private char[] InfixAsCharArray { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFix"/> class.
        /// </summary>
        public PostFix()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFix"/> class.
        /// </summary>
        /// <param name="input">The input<see cref="string"/>.</param>
        public PostFix(string input)
        {
            this.InfixExpression = input;
        }

        /// <summary>
        /// The Convert.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string Convert()
        {
            Stack<string> operatorStack = new Stack<string>();
            var tokenizeExpression = Tools.Tool.Tokenize(this.InfixExpression, StringOperations);

            if (tokenizeExpression.Where<string>(x => x == "(").Count() != tokenizeExpression.Where<string>(x => x == ")").Count())
                return "***Error*** Unpaired open parenthesis";


            foreach (var item in tokenizeExpression)
            {
                if (!StringOperations.Contains(item))
                {
                    this.PostFixExpression += $"{item} ";
                }
                else
                {
                    if (item == ")" && !operatorStack.Contains("("))
                    {
                        return "***Error*** Unpaired parenthesis";
                    }

                    if (item == ")" && operatorStack.Contains("("))
                    {
                        while (operatorStack.Peek() != "(")
                        {
                            this.PostFixExpression += $"{operatorStack.Pop()} ";
                        }
                    }
                    else
                    {
                        operatorStack.Push(item);
                    }
                }
            }



            while (operatorStack.Count != 0)
            {

                if (operatorStack.Peek() != "(" && operatorStack.Peek() != ")")
                    this.PostFixExpression += $"{operatorStack.Pop()} ";
                else
                    operatorStack.Pop();
            }

            return this.PostFixExpression;
        }

        /// <summary>
        /// The IsOperatorSymbol.
        /// </summary>
        /// <param name="token">The token<see cref="char"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsOperatorSymbol(char token)
        {
            return StringOperations.Contains(token);
        }
    }
}
