using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer
{
    public static class Helper
    {
        public static List<string> ObtainFiles(this DirectoryInfo dir)
        {
            return dir.GetFiles("*.*", SearchOption.AllDirectories)
                .Where(f => !f.Extension.Contains("exe")).Select(f => f.FullName)?.ToList();
        }

        public static List<string> ReadInstructions()
        {
            int counter = 0;
            string line;
            List<string> instructions = new List<string>();

            var filePath = $@"c:\ImageViewer\instructions.txt";

            StreamReader file = new StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                instructions.Add(line);
                counter++;
            }

            file.Close();

            return instructions;
        }
    }
}
