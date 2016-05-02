using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackWhiteLists
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ReadWriteData readWriteList = new ReadWriteData();

            List<string> inputList = readWriteList.ReadData("Input.txt");
            List<string> whiteList = readWriteList.ReadData("WhiteList.txt");
            List<string> blackList = readWriteList.ReadData("Blacklist.txt");

            Filters filter = new Filters();
            HashSet<string> fileteredByWhiteList = filter.FilterByWhiteList(inputList, whiteList);
            HashSet<string> fileteredByBlackList = filter.FilterByBlackList(inputList, blackList);
            HashSet<string> fileteredByWhiteBlackList = filter.FilterByWhiteBlackList(inputList, whiteList, blackList);

            readWriteList.SaveData(fileteredByWhiteList, "Output_whitelist.txt");
            readWriteList.SaveData(fileteredByBlackList, "Output_blacklist.txt");
            readWriteList.SaveData(fileteredByWhiteBlackList, "Output_white_and_blacklist.txt");
        }
    }
}
