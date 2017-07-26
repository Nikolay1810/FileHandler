using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class Reversed2: Handler
    {
        public Reversed2() : base()
        {
            nameAction = "Reversed2";
        }

        public override void FindingAttachedFiles(string startFolderPath)
        {
            List<string> pathList = new List<string>();
            files = new FileClass(startFolderPath);
            pathList.AddRange(files.GetFiles());
            string reservePath;
            int length = 0;
            foreach (var path in pathList)
            {
                reservePath = "";
                length = path.Length;
                for (int i = length-1; i >= 0; i--)
                {
                    reservePath += path[i];
                }
                
                filesPathList.Add(reservePath.ToString());
            }
            files.WriteFile(filesPathList);
        }
    }
}
