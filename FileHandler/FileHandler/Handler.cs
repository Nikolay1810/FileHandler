using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public abstract class Handler : IHandler
    {
        public string startFolder;
        public string nameAction;
        public FileClass files;
        public List<string> filesPathList;

        public Handler()
        {
            filesPathList = new List<string>();
        }

        public virtual void FindingAttachedFiles(string startFolderPath)
        {

        }
        public virtual void Show()
        {
            foreach (var path in filesPathList)
            {
                Console.WriteLine(path);
            }
        }
    }
}
