using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.HomeWork3
{
    public class WorkFiles
    {
        static public string StringRevers(string str)
        {
            StringBuilder sb = new StringBuilder();
            var array = str.Reverse();
            foreach (var item in array)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}
