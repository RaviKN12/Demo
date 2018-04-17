using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class Question1
    {
        static void Main(string[] args)
        {
            Question1 q1 = new Question1();
            Question3 q3 = new Question3();

            q1.doesFileExist("C:\\testfile.txt");
            q1.readDictionaryFile("C:\\testfile.txt");
            q3.FindNthSmallestNum(3);
        }

        public void doesFileExist(string path)
        {

            try
            {
                if (!File.Exists(path))
                { throw new FileNotFoundException(); }
                else if (File.Exists(path))
                {
                    Console.WriteLine("File Exists");
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void readDictionaryFile(string path)
        {
            string contents = File.ReadAllText(path);
            string[] arr = contents.Split(new Char[] { '-', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);


            int arrSize = arr.Length;
            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
