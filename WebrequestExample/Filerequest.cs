using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebrequestExample
{
    public class Filerequest : IRequest
    {
        public string SendRequest(string input)
        {
            string text = System.IO.File.ReadAllText(input);

            return text;
        }
    }
}
