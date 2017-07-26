using FileHandler;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace FileHandler.Tests
{
    [TestClass]
    public class FileHandlerTests
    {
        [TestMethod()]
        public void AllTest()
        {
            try
            {
                All all = new All();
                var startPath = "E:\\";

                DirectoryInfo dirInfo = new DirectoryInfo(startPath);
                Assert.IsTrue(dirInfo.Exists);

                all.FindingAttachedFiles(startPath);
                Assert.IsNotNull(all.filesPathList);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void CppTest()
        {
            try
            {
                Cpp cpp = new Cpp();
                var startPath = "E:\\";

                DirectoryInfo dirInfo = new DirectoryInfo(startPath);
                Assert.IsTrue(dirInfo.Exists);

                cpp.FindingAttachedFiles(startPath);
                Assert.IsNotNull(cpp.filesPathList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void Reversed1Test()
        {
            try
            {
                Reversed1 reversed1 = new Reversed1();
                var startPath = "E:\\";

                DirectoryInfo dirInfo = new DirectoryInfo(startPath);
                Assert.IsTrue(dirInfo.Exists);

                reversed1.FindingAttachedFiles(startPath);
                Assert.IsNotNull(reversed1.filesPathList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void Reversed2Test()
        {
            try
            {
                Reversed2 reversed2 = new Reversed2();
                var startPath = "E:\\";

                DirectoryInfo dirInfo = new DirectoryInfo(startPath);
                Assert.IsTrue(dirInfo.Exists);

                reversed2.FindingAttachedFiles(startPath);
                Assert.IsNotNull(reversed2.filesPathList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void FileClassTest()
        {
            try
            {
                var rootPath = "E:\\";
                DirectoryInfo dirInfo = new DirectoryInfo(rootPath);
                Assert.IsTrue(dirInfo.Exists);

                FileClass fileClass = new FileClass(rootPath);
                var list = fileClass.GetFiles();
                Assert.IsNotNull(list);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }
        }
    }
}


