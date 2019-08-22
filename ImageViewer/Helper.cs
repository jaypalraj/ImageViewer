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
    }
}
