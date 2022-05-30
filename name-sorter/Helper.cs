using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class Helper
    {
        public const string OK = "OK";

        public static string SortNameAndSave(string filePath, out List<string> list)
        {
            list = new List<string>();
            try
            {
                //incase if the string path is null or empty
                if (string.IsNullOrEmpty(filePath))
                    throw new Exception("Please select a file.");
                //incase if the file is not exists / moved
                if (!System.IO.File.Exists(filePath))
                    throw new Exception("Selected file does not exists!");
                //read line and sort the content by last chunk
                list = System.IO.File.ReadAllLines(filePath).OrderBy(r => r.Split(' ').Last()).ThenBy(r => r.Split(' ').First()).ToList();
                //if the file empty return message
                if (list.Count == 0)
                    throw new Exception("File was empty.");
                //write the file
                using (StreamWriter outputFile = new StreamWriter("sorted-files.txt"))
                    foreach (string line in list)
                        outputFile.WriteLine(line);
            }
            catch (Exception exc)
            {
                return exc.InnerException != null ? exc.InnerException.Message : exc.Message;
            }
            return "OK";
        }
    }
}
