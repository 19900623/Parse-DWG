using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ConvertDwgXML
{
    public class generateXML
    {
        public string Execute(string path)
        {
            string result = "";
            try
            {
                localhost.Service1 myService = new localhost.Service1();
                result = myService.ParseDwg(path);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }

    }


}
