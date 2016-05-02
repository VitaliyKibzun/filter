using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackWhiteLists
{
    class Filters
    {
        //Filter by White list
        public HashSet<string> FilterByWhiteList(List<string> inputList, List<string> whiteList )
        {
            HashSet<string> fiteredByWhiteList = new HashSet<string>();
            foreach (string dataInLine in inputList)
            {
                if (whiteList.Contains(dataInLine))
                {
                    fiteredByWhiteList.Add(dataInLine);
                }
            }
            return fiteredByWhiteList;
        }

        //Filter by Black list
        public HashSet<string> FilterByBlackList(List<string> inputList, List<string> blackList)
        {
            HashSet<string> fiteredByBlackList = new HashSet<string>();
            foreach (string dataInLine in inputList)
            {
                if (!blackList.Contains(dataInLine))
                {
                    fiteredByBlackList.Add(dataInLine);
                }
            }
            return fiteredByBlackList;
        }

        //Filter by White and Black list
        public HashSet<string> FilterByWhiteBlackList(List<string> inputList, List<string> whiteList,
            List<string> blackList)
        {
            HashSet<string> fiteredByWhiteBlackList = new HashSet<string>();
            foreach (string dataInLine in inputList)
            {
                if ((whiteList.Contains(dataInLine)) && (!blackList.Contains(dataInLine)))
                {
                    fiteredByWhiteBlackList.Add(dataInLine);
                }
            }
            return fiteredByWhiteBlackList;
        }
    }
}
