using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KWIC_asignment1
{
    public static class Input
    {
        public static string[] Read()   //reading txt file from  (c:\input.txt)directory and make an array of string
        {
            return File.ReadAllLines(@"c:\input.txt", Encoding.UTF8);
            
        }
    }
}
