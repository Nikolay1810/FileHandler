using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class Reversed1: Handler
    {
        public Reversed1() : base()
        {
            nameAction = "Reversed1";
            //filesPathList = new List<string>();
        }

        public override void FindingAttachedFiles(string startFolderPath)
        {
            List<string> pathList = new List<string>();
            files = new FileClass(startFolderPath);
            pathList.AddRange(files.GetFiles());
            string[] substringsPath = { };
            var reservePath = "";
            foreach (var path in pathList)
            {
                substringsPath = path.Split('\\');
                reservePath = "";
                for (int i = substringsPath.Length-1; i >= 0; i--)
                {
                    reservePath += substringsPath[i] + '\\';
                }
                filesPathList.Add(reservePath);
            }
            files.WriteFile(filesPathList);

        }
    }
}
