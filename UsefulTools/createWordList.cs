using System;
using System.IO;
using System.Text;

namespace UsefulTools
{
    internal class createWordList
    {
        public createWordList()
        {
            Console.WriteLine("Entrez les mots que vous voulez ajouter à la WordList (F2 pour arreter) : \n");

            var dataBuilder = new StringBuilder();
            int keyCode = 0;

            while (keyCode != 7405568)
            {
                var readData = Console.ReadKey();
                keyCode = readData.GetHashCode();

                if (keyCode == 851981)
                {
                    dataBuilder.Append(" ");
                    Console.WriteLine();
                }
                else if (keyCode == 2097184)
                {
                    dataBuilder.Append("+");
                }
                else if (keyCode != 7405568)
                {
                    string streamData = readData.KeyChar.ToString();
                    dataBuilder.Append(streamData);
                }
                else
                {
                    Console.WriteLine("\nFin de la WordList");
                }

            }

            string dataToConvert = dataBuilder.ToString().ToLower();
            string[] dataSplit = dataToConvert.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Entrez le nom de votre WordList: ");
            string fileNameTemp = Console.ReadLine() + "-wordlist.txt";

            string directory = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(directory + "\\export");

            string fileName = "export\\" + fileNameTemp;

            using (StreamWriter sw = File.CreateText(fileName))
            {
                foreach (var dataToWrite in dataSplit)
                {
                    sw.WriteLine(dataToWrite);
                }

            }

            Console.WriteLine("\nLa WordList a bien été créée. Elle se trouve dans : " + directory + "\\" + fileName + "\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();

            return;
        }
    }
}