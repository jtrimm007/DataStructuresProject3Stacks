///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Data Structures Project 3 Stacks
//	File Name:         Operator.cs
//	Description:       This class helps evaluate operators. 
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           11/13/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Tool
{
    using System;

    /// <summary>
    /// Defines the <see cref="Operator" />.
    /// </summary>
    public class Operator : IComparable<Operator>, IEquatable<Operator>
    {
        /// <summary>
        /// Gets or sets the Precedence.
        /// </summary>
        public int Precedence { get; set; }

        /// <summary>
        /// Gets or sets the Symbol.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operator"/> class.
        /// </summary>
        public Operator()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operator"/> class.
        /// </summary>
        /// <param name="operatorToHandle">The operatorToHandle<see cref="string"/>.</param>
        public Operator(string operatorToHandle)
        {
            this.Symbol = operatorToHandle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operator"/> class.
        /// </summary>
        /// <param name="operatorToHandle">The operatorToHandle<see cref="char"/>.</param>
        public Operator(char operatorToHandle)
        {
            this.Symbol = operatorToHandle.ToString();
        }


        public static bool operator <(Operator leftHandSymbol, Operator rightHandSymbol)
        {
            return leftHandSymbol.CompareTo(rightHandSymbol) < 0 ? true : false;
        }

        public static bool operator >(Operator leftHandSymbol, Operator rightHandSymbol)
        {
            return leftHandSymbol.CompareTo(rightHandSymbol) > 0 ? true : false;
        }
        /// <summary>
        /// The CompareTo.
        /// </summary>
        /// <param name="other">The other<see cref="Operator"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CompareTo(Operator other)
        {
            return this.Symbol.CompareTo(other.Symbol);
        }

        /// <summary>
        /// The Equals.
        /// </summary>
        /// <param name="other">The other<see cref="Operator"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Equals(Operator other)
        {
            return this.Precedence == other.Precedence;
        }

        /// <summary>
        /// The Equals.
        /// </summary>
        /// <param name="obj">The obj<see cref="object"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public override bool Equals(object obj)
        {
            // Check if the object is null
            if (obj == null)
                return base.Equals(obj);

            // If the object isn't a operator symbol, throw an exception.
            if (!(obj is Operator))
                throw new ArgumentException($"{obj} is not an Operator");

            // return the obj as a Operator
            return Equals(obj as Operator);
        }
    }
}
