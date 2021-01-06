using System;
using System.IO;
using System.Net;

namespace UsefulTools
{
    internal class proxyGrabber
    {
        public proxyGrabber()
        {
            bool isFinish = false;
            
            while(isFinish == false)
            {
                Console.Clear();
                Console.WriteLine("ProxyGrabber: \n\n 1- HTTP \n 2- SOCKS4 \n 3- SOCKS5 \n 4- CUSTOM API \n 0- Exit \n\nEntrez le numéro de l'option de votre choix: ");
                string choose = Console.ReadLine();

                if(choose == "1")
                {
                    startGrabber("https://api.proxyscrape.com/?request=getproxies&proxytype=http&timeout=5000&country=US&anonymity=elite&ssl=yes");
                    isFinish = true;
                }
                else if(choose == "2")
                {
                    startGrabber("https://api.proxyscrape.com/?request=getproxies&proxytype=socks4&timeout=5000&country=US&anonymity=elite&ssl=yes");
                    isFinish = true;
                }
                else if(choose == "3")
                {
                    startGrabber("https://api.proxyscrape.com/?request=getproxies&proxytype=socks5&timeout=5000&country=US&anonymity=elite&ssl=yes");
                    isFinish = true;
                }
                else if(choose == "4")
                {
                    Console.WriteLine("Entrez le lien de vote api: ");
                    string url = Console.ReadLine();
                    startGrabber(url);
                    isFinish = true;
                }
                else if(choose == "0")
                {
                    isFinish = true;
                }
            }
        }

        public void startGrabber(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
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