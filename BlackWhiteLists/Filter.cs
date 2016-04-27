using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackWhiteLists
{
    class Filter
    {
        string fileNameInput = "Input.txt";
        string fileNameWhiteList = "Whitelist.txt";
        string fileNameBlackList = "Blacklist.txt";

        string fileNameOutputWhiteList = "Output_whitelist.txt";
        string fileNameOutputBlackList = "Output_blacklist.txt";
        string fileNameOutputBlackWhiteList = "Output_black_and_white.txt";

        HashSet<string> inputList = new HashSet<string>();
        HashSet<string> whiteList = new HashSet<string>();
        HashSet<string> blackList = new HashSet<string>();

        HashSet<string> outputWhiteList = new HashSet<string>();
        HashSet<string> outputBlackList = new HashSet<string>();
        HashSet<string> outputBlackWhiteList = new HashSet<string>();



        public void StartTheProgram()
        {
            ReadFile(fileNameInput, inputList);
            ReadFile(fileNameWhiteList, whiteList);
            ReadFile(fileNameBlackList, blackList);

            FilterData();

            WriteDataToFile(fileNameOutputWhiteList, outputWhiteList);
            WriteDataToFile(fileNameOutputBlackList, outputBlackList);
            WriteDataToFile(fileNameOutputBlackWhiteList, outputBlackWhiteList);

        }

        // Reading data from file
        private HashSet<string> ReadFile(string fileName, HashSet<string> hashSetList)
        {
            // Creating stream reader method
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    hashSetList.Add(line);
                }
            }
            return hashSetList;
        }

        // Filter data
        private void FilterData()
        {
            foreach (var inputValue in inputList)
            {
                if (whiteList.Contains(inputValue))
                {
                    outputWhiteList.Add(inputValue);
                }

                if (!blackList.Contains(inputValue))
                {
                    outputBlackList.Add(inputValue);
                }

                if ((whiteList.Contains(inputValue)) && (!blackList.Contains(inputValue)))
                {
                    outputBlackWhiteList.Add(inputValue);
                }
            }
        }

        // Writing data to file
        private void WriteDataToFile(string fileName, HashSet<string> outputHashSetList)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var hashSetData in outputHashSetList)
                {
                    writer.WriteLine(hashSetData);
                }
            }
        }
    }
}
