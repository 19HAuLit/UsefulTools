using System;
using System.IO;
using System.Text;

namespace UsefulTools
{
    internal class createDorksList
    {
        public createDorksList()
        {
            var wordList = new StringBuilder();
            var pageType = new StringBuilder();
            var pageFormat = new StringBuilder();

            int isFinish = 0;

            while (isFinish == 0)
            {
                Console.WriteLine("\nEntrez le chemin de votre WordList (ou 0 pour annuler): ");
                string filePath = Console.ReadLine();
                if (filePath == "0")
                {
                    return;
                }
                else if (File.Exists(filePath))
                {
                    wordList.Append(File.ReadAllText(filePath));

                    isFinish = 1;
                }
                else
                {
                    Console.WriteLine("Entrez un chemin valide (Ex: C:\\Directory\\file.txt)");
                }

            }

            while (isFinish == 1)
            {
                Console.WriteLine("\nEntrez le chemin de votre pageType (ou 0 pour annuler) :");
                string filePath = Console.ReadLine();
                if (filePath == "0")
                {
                    return;
                }
                else if (File.Exists(filePath))
                {
                    pageType.Append(File.ReadAllText(filePath));

                    isFinish = 0;
                }
                else
                {
                    Console.WriteLine("Entrez un chemin valide (Ex: C:\\Directory\\file.txt)");
                }
            }

            while (isFinish == 0)
            {
                Console.WriteLine("\nEntrez le chemin de votre pageFormat (ou 0 pour annuler): ");
                string filePath = Console.ReadLine();
                if (filePath == "0")
                {
                    return;
                }
                else if (File.Exists(filePath))
                {
                    pageFormat.Append(File.ReadAllText(filePath));

                    isFinish = 1;
                }
                else
                {
                    Console.WriteLine("Entrez un chemin valide (Ex: C:\\Directory\\file.txt)");
                }

            }

            string[] wordListSplit = wordList.ToString().Split();
            string[] pageTypeSplit = pageType.ToString().Split();
            string[] pageFormatSplit = pageFormat.ToString().Split();

            Console.WriteLine("Entrez le nom de votre DorksList: ");
            string fileNameTemp = Console.ReadLine() + "-dorks.txt";

            string directory = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(directory + "\\export");

            string fileName = "export\\" + fileNameTemp;

            using (StreamWriter sw = File.CreateText(fileName))
            {
                foreach (var keyword in wordListSplit)
                {
                    foreach (var type in pageTypeSplit)
                    {
                        foreach (var format in pageFormatSplit)
                        {
                            sw.WriteLine(keyword + type + format);
                        }
                    }
                }
            }

            Console.WriteLine("\nLa DorksList a bien été créée. Elle se trouve dans : " + directory + "\\" + fileName + "\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();

            return;
        }
    }
}