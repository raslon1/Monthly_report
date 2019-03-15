using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Monthly_report
{
    class Choosefile
    {
        public Choosefile() { }

        public string choosefile(string file, string pattern)
        {

            //string pattern = @"(?<=ТАБЕЛ.N:)(\d+)";
            MatchCollection matchs = Regex.Matches(file, pattern);
            if (matchs.Count > 0)
                foreach (Match match in matchs)
                {
                    return (match.Value);
                }
            else
            {
                return null;
            }
            return null;
        }
    }
}