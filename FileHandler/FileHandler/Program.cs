using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стартовую папку(через пробел):");
            var str = Console.ReadLine();
            var path = str.Split(' ').FirstOrDefault();
            var action = str.Split(' ').LastOrDefault();
            switch (action)
            {
                case "all":
                    All actionAll = new All();
                    actionAll.FindingAttachedFiles(path);
                    actionAll.Show();
                    break;
                case "cpp":
                    Cpp actionCpp = new Cpp();
                    actionCpp.FindingAttachedFiles(path);
                    actionCpp.Show();
                    break;
                case "reversed1":
                    Reversed1 actionReversed1 = new Reversed1();
                    actionReversed1.FindingAttachedFiles(path);
                    actionReversed1.Show();
                    break;
                case "reversed2":
                    Reversed2 actionReversed2 = new Reversed2();
                    actionReversed2.FindingAttachedFiles(path);
                    actionReversed2.Show();
                    break;
            }
        }
    }
}
