///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Data Structures Project 3 Stacks
//	File Name:         PostFix.cs
//	Description:       The PostFix class provides the helper methods to convert a Infix express to a Postfix express. 
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

        /// <summary>
        /// The private StringOperations field is set to a string of operation characters that are predefined in the project specifications.
        /// </summary>
        private string StringOperations = "+-*/()=";

        /// <summary>
        /// The InfixExpression property is set in the constrictor method.
        /// </summary>
        public string InfixExpression { get; set; }

        /// <summary>
        /// The PostFixExpression is set to null on the creation of this class. It is used to store variables and constants as the expression is evaluated. 
        /// </summary>
        public string PostFixExpression { get; set; } = null;


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
        /// The Convert method evaluates the InfixExpression property. It tokenize's the InfixExpression string and then evaluates the expression. 
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string Convert()
        {

            // instantiate a stack to hold the operators.
            Stack<string> operatorStack = new Stack<string>();

            // tokenize the InfexExpression string property
            var tokenizeExpression = Tools.Tool.Tokenize(this.InfixExpression, StringOperations);

            // Before starting the evaluation process, make sure that there are an equal amount of open and closing parenthesis. 
            if (tokenizeExpression.Where<string>(x => x == "(").Count() != tokenizeExpression.Where<string>(x => x == ")").Count())
                return "***Error*** Unpaired open parenthesis"; // Display an error if there isn't an equal amount of open and closing parenthesis. 

            // evaluate each token
            foreach (var item in tokenizeExpression)
            {
                // If the item being evaluated is not an operator, add it to the PostFixExpression string.
                if (!StringOperations.Contains(item))
                {
                    this.PostFixExpression += $"{item} ";
                }
                else // if the item is an operator, evaluate what it is and remove it from the stack.
                {
                    // If the item is a closing parenthesis and there isn't an opening parenthesis on the stack, display an error. 
                    if (item == ")" && !operatorStack.Contains("("))
                    {
                        return "***Error*** Unpaired parenthesis";
                    }

                    // if the item is a closing parenthesis and the operator stack contains an opening parenthesis, then pop operators off the stack until the opening parenthesis is found.
                    if (item == ")" && operatorStack.Contains("("))
                    {
                        // While the next item on the stack isn't an opening parenthesis, add the operator to the PostFixExpression string. 
                        while (operatorStack.Peek() != "(")
                        {
                            this.PostFixExpression += $"{operatorStack.Pop()} ";
                        }
                    }
                    else // if the item is an operator and is not an open or closing parenthesis add it to the operator stack. 
                    {
                        operatorStack.Push(item);
                    }
                }
            }


            // this while loop handles the remaining stack items. While the operator stack has items, evaluate the stack to concatenate the operations to the PostFixExpression string. 
            while (operatorStack.Count != 0)
            {
                // if the operator is now an opening or closing parenthesis, pop the operator off of the stack and concatenate it to the PostFixExpression string. 
                if (operatorStack.Peek() != "(" && operatorStack.Peek() != ")")
                    this.PostFixExpression += $"{operatorStack.Pop()} ";
                else // if it is and opening or closing parenthesis, just pop it off the stack. 
                    operatorStack.Pop();
            }

            // return the PostFixExpression string and the conversion process is finished. 
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
