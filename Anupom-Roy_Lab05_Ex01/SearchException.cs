using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex01
{
    public class SearchException :Exception
    {
        public SearchException() : base("Empt Search") {
        }
        public SearchException(string exp) : base(exp)
        {
        }
    }
}
