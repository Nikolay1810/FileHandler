using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandler
{
    public class FileClass
    {
        private string rootPath;
        public List<string> filesPathList;

        public FileClass(string path)
        {
            rootPath = path;
            filesPathList = new List<string>();
        }

        public List<string> GetFiles()
        {
            try
            {
               DirectoryInfo dirInfo = new DirectoryInfo(rootPath);
                if (dirInfo.Exists)
                {
                    List<FileInfo> files = new List<FileInfo>();
                    List<DirectoryInfo> dirInfoList = new List<DirectoryInfo>();

                    dirInfoList.AddRange(dirInfo.GetDirectories());

                    files.AddRange(dirInfo.GetFiles());

                    var result = GetAllFiles(dirInfoList, dirInfo, files);
                    files = result.Result;

                    foreach (var file in files)
                    {
                        filesPathList.Add(file.FullName);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           return filesPathList;
        }

        public async Task<List<FileInfo>> GetAllFiles(List<DirectoryInfo> dirInfoList,DirectoryInfo dirInfo, List<FileInfo> files)
        {
            for (int i = 0; i < dirInfoList.Count; i++)
            {
                
                dirInfo = new DirectoryInfo(dirInfoList[i].FullName);
                files.AddRange(dirInfo.GetFiles());
                if (dirInfo.GetDirectories().Length != 0)
                {
                    dirInfoList.Remove(dirInfoList[i]);
                    dirInfoList.InsertRange(i, dirInfo.GetDirectories());
                    return await GetAllFiles(dirInfoList, dirInfo, files);
                }
                else
                {
                    dirInfoList.Remove(dirInfoList[i]);
                    return await GetAllFiles(dirInfoList, dirInfo, files);
                }
            }
            return files;
        }

        public void WriteFile(List<string> data)
        {
            string nameFile = "results.txt";
            if (data.Count != 0 && data != null)
            {
                try
                {
                    using (StreamWriter writeFile = new StreamWriter(nameFile, true, Encoding.Default))
                    {
                        foreach (var itemData in data)
                        {
                            writeFile.WriteLine(itemData);
                        }
                    }
                }
                catch (Exception ex)
                {
                   Console.WriteLine("При записи в файл возникли следующие ошибки:\n" + ex.Message);
                }
            }
        }
    }
}
