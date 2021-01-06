using System;

namespace UsefulTools
{
    class Program
    {
        static void Main()
        {
            new discordStatue("Do somethings");
            bool isFinish = false;

            while (isFinish == false)
            {
                Console.WriteLine("#####################################\n#####################################\n#############UseFulTools#############\n#############By 19HAuLit#############\n#####################################\n#####################################\n"); 
                Console.WriteLine(" 1- Création d'une nouvelle WordList\n 2- Dorks Generator (En dev - ne fonctionne pas)\n 3- Proxy Grabber\n 0- Exit");
                Console.WriteLine("\nEntrez le numéro d'une des options: ");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    new createWordList();
                }
                else if (choose == "2")
                {
                    new createDorksList();
                }
                else if (choose == "3")
                {
                    bool taskFinish = false;

                    while (taskFinish == false)
                    {
                        Console.Clear();
                        Console.WriteLine("     ProxyGrabber    \n\n 1- Proxy http (api.proxyscrape.com)\n 2- Proxy socks4 (api.proxyscrape.com)\n 3- Proxy socks5 (api.proxyscrape.com)\n 4- Proxy avec API Custom\n 0- Exit");
                        Console.WriteLine("\nEntrez le numéro d'une des options: ");
                        string taskChoose = Console.ReadLine();
                        if (taskChoose == "1")
                        {
                            new proxyGrabber("https://api.proxyscrape.com?request=getproxies&proxytype=http&timeout=5000");
                            taskFinish = true;
                        }
                        else if (taskChoose == "2")
                        {
                            new proxyGrabber("https://api.proxyscrape.com?request=getproxies&proxytype=socks4&timeout=5000");
                            taskFinish = true;
                        }
                        else if (taskChoose == "3")
                        {
                            new proxyGrabber("https://api.proxyscrape.com?request=getproxies&proxytype=socks5&timeout=5000");
                            taskFinish = true;
                        }
                        else if (taskChoose == "4")
                        {
                            Console.WriteLine("Entrez le lien de votre API: ");
                            string apiUrl = Console.ReadLine();
                            new proxyGrabber(apiUrl);
                            taskFinish = true;
                        }
                        else if (taskChoose == "0")
                        {
                            taskFinish = true;
                        }
                    }
                }
                else if (choose == "0")
                {
                    isFinish = true;
                }
                Console.Clear();
            }
        }
    }
}