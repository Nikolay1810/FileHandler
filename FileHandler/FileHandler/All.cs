using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class All : Handler
    {
        public All() : base()
        {
            nameAction = "All";
        }

        public override void FindingAttachedFiles(string startFolderPath)
        {
            files = new FileClass(startFolderPath);
            filesPathList.AddRange(files.GetFiles());
            files.WriteFile(filesPathList);
        }
    }
}
