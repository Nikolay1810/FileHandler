using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class Cpp : Handler
    {
        public Cpp() : base()
        {
            nameAction = "Cpp";
        }

        public override void FindingAttachedFiles(string startFolderPath)
        {
            List<string> pathList = new List<string>();
            List<string> sortedPathList = new List<string>();
            files = new FileClass(startFolderPath);
            pathList.AddRange(files.GetFiles());
            sortedPathList.AddRange(pathList.Where(u => u.Split('.').LastOrDefault() == "cpp").ToList());
            foreach (var filePath in sortedPathList)
            {
                filesPathList.Add(filePath + " /");
            }
            files.WriteFile(filesPathList);

        }
    }
}
