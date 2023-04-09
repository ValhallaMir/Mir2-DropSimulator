using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropSimulator
{
    public class DropInfo
    {
        public string Name;
        public int Chance;

        public static DropInfo FromLine(string s)
        {
            string[] parts = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2)
            {
                return null;
            }

            DropInfo info = new DropInfo();
            if (parts[0].StartsWith(";") || string.IsNullOrWhiteSpace(parts[0])) return null;

            if (!int.TryParse(parts[0].Substring(2), out info.Chance)) return null;

            if (parts[1].Contains("Gold") || parts[1].Contains("gold)")) return null;

            info.Name = parts[1].ToString();




            return info;
        }

        //public static string ToLine(List<DropInfo> list)
        //{
        //    string parsedInfo;

        //    foreach (var info in list)
        //    {

        //    }


        //    return parsedInfo;
        //}
    }
}
