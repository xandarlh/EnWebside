using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebrequestExample
{
    public class Manager
    {
        IRequest request;

        public string MakeWebRequest(string input)
        {
            request = new Webrequest();
            return request.SendRequest(input);
        }

        public string MakeFileRequest(string input)
        {
            request = new Filerequest();
            return request.SendRequest(input);
        }

    }
}
