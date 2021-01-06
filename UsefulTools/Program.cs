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
                Console.WriteLine("\nEntrez le numéro de l'option de votre choix: ");
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
                    new proxyGrabber();
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