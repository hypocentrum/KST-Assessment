using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace name_sorter_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string inputFileName = "unsorted-names-list.txt";
            string input = @"Orson Milka Iddins
Erna Dorey Battelle
Flori Chaunce Franzel
Odetta Sue Kaspar
Roy Ketti Kopfen
Madel Bordie Mapplebeck
Selle Bellison
Leonerd Adda Mitchell Monaghan
Debra Micheli
Hailey Avie Annakin";

            //if the test file not exists, create it
            if (!System.IO.File.Exists(inputFileName))
            {
                var inputs = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                using (StreamWriter outputFile = new StreamWriter(inputFileName))
                    foreach (string s in inputs)
                        outputFile.WriteLine(s);
            }

            string expectedResult = @"Hailey Avie Annakin
Erna Dorey Battelle
Selle Bellison
Flori Chaunce Franzel
Orson Milka Iddins
Odetta Sue Kaspar
Roy Ketti Kopfen
Madel Bordie Mapplebeck
Debra Micheli
Leonerd Adda Mitchell Monaghan";

            List<string> expectedList = expectedResult.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            List<string> list;
            string res = name_sorter.Helper.SortNameAndSave(inputFileName, out list);
            Assert.NotNull(list);
            Assert.Equal(expectedList, list);
        }
    }
}