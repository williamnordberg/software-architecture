using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC_asignment1
{
    public  class CircularShifft
    {
        public static List<string> circularShifft(string[] linelist)   //do circularly shift in the result of all lines  and return a list consist of result(not in order)
        {
            var list2 = new List<string>();
            foreach (string line in linelist)
            {

                var list = new List<string>();
                list = line.Split(' ').ToList();
                for (int i = 0; i < list.Count(); i++)
                {
                    var str1 = string.Join(" ", list.ToArray());
                    list2.Add(str1);
                    Shifting.shift(list);                   //call shiffting to circual shift of a line
                }
            }
            return list2;
    }   }
}
