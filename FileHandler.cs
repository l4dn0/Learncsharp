using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task15_1
{
    internal class FileHandler
    {
        string fullpath;


        public FileHandler(string filename)
        {
            fullpath = "../../" + filename;
        }

        public string[] GetAllLines()
        {
            string[] lines = new string[] { };
            StreamReader sr = new StreamReader(fullpath, Encoding.UTF8);
            lines = sr.ReadToEnd().Split('\n');
            if(lines.Last() == "")
            {
                Array.Resize(ref lines, lines.Length - 1);
            }
            sr.Close();
            return lines;
        }

        public void AddLine(string line, int position)
        {
            string[] copy = GetAllLines();
            copy[position] = line;
            StreamWriter sw = new StreamWriter(fullpath, false, Encoding.UTF8);
            foreach (var item in copy)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }

        public void AddLine(string line)
        {
            string[] copy = GetAllLines();
            var z = copy.Append(line);
            StreamWriter sw = new StreamWriter(fullpath, false, Encoding.UTF8);
            foreach (var item in z)
            {
                sw.WriteLine(item);
                //sw.Write(item);
            }
            sw.Close();
        }
    }
}
