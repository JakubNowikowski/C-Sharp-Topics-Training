using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Book : IBook
    {
        public int SerialNumber { get; set; }
        public string Title { get; set; }
    }
}
