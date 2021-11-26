using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookUICrud.Data
{
    public class Response
    {
        public int Success { get; set; }
        public String Message { get; set; }
        public List<Book> Data { get; set; }
    }
}
