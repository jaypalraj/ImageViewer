using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer
{
    public class DirectoryOperator
    {
        public static Dictionary<string, List<string>> GetAnalysis(string dirPath)
        {
            var dirInfo = new DirectoryInfo(dirPath);

            if (!dirInfo.Exists) return null;

            var dirList = dirInfo.GetDirectories();

            var dics = new Dictionary<string, List<string>>();

            foreach (var dir in dirList)
            {
                var files = Helper.ObtainFiles(dir);
                if(files.Count() > 0)
                    dics.Add(dir.FullName, files);
            }

            return dics;
        }

        public static Dictionary<string, List<string>> CreateFilesList(Random randomFillGaps, Dictionary<string, List<string>> dics)
        {
            var mostfiles = dics.OrderByDescending(d => d.Value.Count()).FirstOrDefault().Value.Count();

            var filesList = new Dictionary<string, List<string>>();

            foreach (var d in dics)
            {
                filesList.Add(d.Key, d.Value);

                var diff = mostfiles - d.Value.Count();

                for (var i = 0; i < diff; i++)
                {
                    filesList[d.Key].Add(d.Value.ElementAt(randomFillGaps.Next(d.Value.Count())));
                }
            }

            return filesList;
        }



        public static string ChooseOne(Random random, Random randFile, Random trueOrFalse, Dictionary<string, List<string>> dics, List<string> listPriority = null)
        {
            var choosenDicsItem = dics.ElementAt(random.Next(dics.Count()));

            if (listPriority != null && listPriority.Any() && trueOrFalse.Next(100) <= 50 ? true : false)
            {
                return listPriority.ElementAt(randFile.Next(listPriority.Count()));
            }

            return choosenDicsItem.Value.ElementAt(randFile.Next(choosenDicsItem.Value.Count()));

        }
    }
}
