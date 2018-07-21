using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex02
{
   public class EmptyStackException : Exception
    {
        // parameterless constructor
        public EmptyStackException() : base("Stack is empty")
        {
            // empty constructor
        }

        // one-parameter constructor
        public EmptyStackException(string exception) : base(exception)
        {
            // empty constructor
        }

        // two-parameter constructor
        public EmptyStackException(string exception, Exception inner)
           : base(exception, inner)
        {
            // empty constructor
        }
    }
}
