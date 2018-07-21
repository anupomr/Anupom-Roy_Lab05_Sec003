using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex02._1
{
    public class ArgumentException :Exception
    {
        public ArgumentException() : base("Arguments never be a negative number")
        { }
        public ArgumentException(string exception) : base(exception)
        { }

    }
}
