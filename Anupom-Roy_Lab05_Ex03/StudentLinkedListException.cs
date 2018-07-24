using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex03
{
    public class StudentLinkedListException : Exception
    {
        public StudentLinkedListException(string msg) : base(msg)
        {
            //empty body
        }

        public StudentLinkedListException() : base(" Student List is Empty")
        {
            //empty body
        }
    }
}
