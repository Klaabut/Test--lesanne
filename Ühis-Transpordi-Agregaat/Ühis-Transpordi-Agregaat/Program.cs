using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ühis_Transpordi_Agregaat
{
    class Program
    {
        static void Main(string[] args)
        {
            string transportListUrl = ("https://transport.tallinn.ee/gps.txt");
            List<string> listOfVehicles = new List<string>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(transportListUrl);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            using(var responseReader = new StreamReader(webStream))
            {
                string response = responseReader.ReadToEnd();
                listOfVehicles.Add(response);
                
            }

           /* foreach(string line in listOfVehicles)
            {
                Console.WriteLine(line);
            }*/
            Console.ReadLine();
        }
    }
}
