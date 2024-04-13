using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bypassCaptchaBrightData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            var client = new WebClient();
            client.Proxy = new WebProxy("###");
            client.Proxy.Credentials = new NetworkCredential("productId", "productPass");
            HtmlWeb web = new HtmlWeb();
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(client.DownloadString("siteurl"));
            if (htmlDocument != null)
            {


            }
            Console.ReadLine();
        }
    }
}
