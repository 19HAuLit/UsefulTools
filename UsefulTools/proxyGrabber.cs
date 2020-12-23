using System;
using System.Net;
using System.IO;

namespace UsefulTools
{
    internal class proxyGrabber
    {
        public proxyGrabber()
        {
            try
            {
                var request = WebRequest.Create("https://api.proxyscrape.com?request=getproxies&proxytype=http&timeout=5000");
                var response = request.GetResponse();
                var stream = response.GetResponseStream();
                var reader = new StreamReader(stream);

                Console.WriteLine("Entrez le nom de votre ProxyList: ");
                string fileNameTemp = Console.ReadLine() + "-proxy.txt";

                string directory = Directory.GetCurrentDirectory();
                Directory.CreateDirectory(directory + "\\export");

                string fileName = "export\\" + fileNameTemp;

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.Write(reader.ReadToEnd());
                }
                Console.WriteLine("\nLa ProxyList a bien été créée. Elle se trouve dans : " + directory + "\\" + fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
            return;
        }
    }
}