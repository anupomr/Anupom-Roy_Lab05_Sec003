using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex02
{
    public class FullStackException: Exception
    {
        // parameterless constructor
        public FullStackException() : base("Stack is full")
        {
            // empty constructor
        }

        // one-parameter constructor
        public FullStackException(string exception) : base(exception)
        {
            // empty constructor
        }

        // two-parameter constructor
        public FullStackException(string exception, Exception inner)
           : base(exception, inner)
        {
            // empty constructor
        }
    }
}
