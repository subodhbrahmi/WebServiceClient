using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceClient.ServiceReference1;

namespace WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DelayedStockQuoteSoapClient();
            var resp = service.GetQuickQuote("NBG","0");

            Console.WriteLine(resp.ToString());
        }
    }
}
