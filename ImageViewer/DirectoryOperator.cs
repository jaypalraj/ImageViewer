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
        public static Dictionary<string,List<string>> GetAnalysis(string dirPath)
        {
            var dirInfo = new DirectoryInfo(dirPath);

            if (!dirInfo.Exists) return null;

            var dirList = dirInfo.GetDirectories();

            var dics = new Dictionary<string, List<string>>();

            foreach(var dir in dirList)
            {
                dics.Add(dir.FullName, Helper.ObtainFiles(dir));
            }

            return dics;
        }

        public static Dictionary<string,List<string>> CreateFilesList(Dictionary<string,List<string>> dics)
        {
            var mostfiles = dics.OrderByDescending(d => d.Value.Count()).FirstOrDefault().Value.Count();

            var filesList = new Dictionary<string, List<string>>();

            foreach (var d in dics)
            {
                filesList.Add(d.Key, d.Value);

                var diff = mostfiles - d.Value.Count();

                var rand = new Random();
                for (var i = 0; i < diff; i++)
                {
                    filesList[d.Key].Add(d.Value.ElementAt(rand.Next(d.Value.Count())));
                }
            }

            return filesList;
        }



        public static string ChooseOne(Random random, Random trueOrFalse, Dictionary<string, List<string>> dics, List<string> listPriority = null)
        {
            var choosenDicsItem = dics.ElementAt(random.Next(dics.Count()));

            var randFile = new Random();

            if (listPriority != null && listPriority.Any() && trueOrFalse.Next(100) <= 50 ? true : false)
            {
                return listPriority.ElementAt(randFile.Next(listPriority.Count()));
            }

            return choosenDicsItem.Value.ElementAt(randFile.Next(choosenDicsItem.Value.Count()));
            
        }
    }
}
