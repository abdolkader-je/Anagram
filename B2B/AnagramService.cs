using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2B
{
    public sealed class AnagramService
    {     
        public static Task< List<string>> FileReader(string inputreader)
        {
            List<string> fileContent = new();
            if (File.Exists(inputreader))
            {
                Process.Start("explorer.exe", inputreader);
            }

            foreach (string line in File.ReadLines(inputreader, Encoding.UTF8))
            {

                fileContent.Add(line);
            }
            return Task.Run(() => fileContent);
        }

        public static void WriteTheOutPut(List<string> anagramsList)
        {

            string outputfile = "Output.txt";
            File.WriteAllLines(outputfile, anagramsList);
            if (File.Exists(outputfile))
            {
                Process.Start("explorer.exe", outputfile);
            }

        }

        public static List<string> FileContentSplitter(List<string> fileContent, out List<int> _allNumbersInFile)
        {
            List<string> allWordsInFile = new();
            List<int> allNumbersInFile = new();

            foreach (string str in fileContent)
            {
                string[] word = str.Split(' ');
                for (int index = 0; index < word.Length; index++)
                {
                    _ = word[index].Replace(' ', '0');

                    string sameWord = string.Concat(word[index].Where(c => !char.IsWhiteSpace(c)));

                    bool thisIsANumber = int.TryParse(sameWord, out int number);
                    if (thisIsANumber)
                    {
                        allNumbersInFile.Add(number);
                    }
                    else
                    {
                        allWordsInFile.Add(sameWord);
                    }
                }

            }

            allWordsInFile.Sort((a, b) => a.Length.CompareTo(b.Length));
            _allNumbersInFile = allNumbersInFile;
            return allWordsInFile;
        }

        public static bool IsAnagram(string a, string b)
        {
            string aa = string.Concat(a.OrderBy(c => c));
            string bb = string.Concat(b.OrderBy(c => c));

            if (a != b)
            {
                if (aa.Contains(bb))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;

        }
        public static List<string> anagramresult(List<string> inputread)
        {
            List<string> finalresult = new();

            List<int> index1 = new();
            List<int> index2 = new();
            List<string> ircopy = inputread;


            for (int i = 0; i < inputread.Count; i++)
            {
                for (int j = 0; j < inputread.Count; j++)
                {
                    if (IsAnagram(inputread[i], ircopy[j]) == true)
                    {

                        if (ircopy[j].Length == inputread[i].Length)
                        {
                            index1.Add(i);
                            index2.Add(j);
                        }
                    }
                }
            }

            List<List<string>> list = new List<List<string>>();
            foreach (string x in inputread)
            {
                List<string> temp = new();
                temp.Add(x);
                list.Add(temp);
            }

            for (int v = 0; v < list.Count; v++)
            {
                for (int b = 0; b < list[v].Count; b++)
                {
                    int cindex = inputread.IndexOf(list[v][b]);


                    for (int i = 0; i < index1.Count; i++)
                    {

                        if (cindex == index1[i])
                        {

                            int ind = index2[i];
                            string temp = inputread[ind];

                            list[v][b] += "," + inputread[ind];

                        }

                    }

                }
            }

            List<string> finalresult1 = new();  

            foreach (List<string> a in list)
            {
                foreach (string b in a)
                {

                    finalresult.Add("[" + b + "]");
                }
            }

            finalresult1 = finalresult;

            for (int i = 0; i < finalresult1.Count; i++)
            {
                for (int j = 0; j < finalresult.Count; j++)
                {
                    if (finalresult[i].Length == finalresult1[j].Length)
                    {

                        if (IsAnagram(finalresult[i], finalresult1[j]) == true)
                        {
                            finalresult.RemoveAt(finalresult.IndexOf(finalresult1[j]));
                        }

                    }

                }

            }

            return finalresult;

        }
        public static void IsAnagramOutput(List<string> allAnagarams)
        {

            WriteTheOutPut(allAnagarams);
        }

    }
}
