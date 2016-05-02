using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackWhiteLists
{
    class ReadWriteData
    {
        // Reading Data.
        public List<string> ReadData(string filename)
        {
            List<string> inputData = new List<string>();

            //Creating stream reader method.
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    inputData.Add(line);
                }
            }
            return inputData;
        }

        //Writing Data.
        public void SaveData(HashSet<string> outputData, string outputFilename)
        {
            using(StreamWriter writer = new StreamWriter(outputFilename))
            {
                foreach (string line in outputData)
                {
                    writer.WriteLine(line);
                }
            }
        }

    }
}
