using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC_asignment1
{
    class CircularShift
    {
        static public List<string> Shift(List<string> line)
        {
           
                var first = line[0];
                line.RemoveAt(0);
                line.Add(first);

            return line;

            
        }
    }
}
