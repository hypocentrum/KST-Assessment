namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            //if there is input then proceed
            if (args != null && args.Length > 0)
            {
                List<string> list = new List<string>();
                //sort content and save to file
                string result = name_sorter.Helper.SortNameAndSave(args[0], out list);
                if (result == "OK")
                {
                    //print content
                    foreach (string line in list)
                        Console.WriteLine(line);
                }
                else
                    Console.WriteLine(result);
            }
            else
                Console.WriteLine("No input were detected.");
            Console.Write("Press anykey to exit.");
            Console.ReadLine();
        }
    }
}