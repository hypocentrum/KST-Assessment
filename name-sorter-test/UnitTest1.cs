using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace name_sorter_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
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
            string res = name_sorter.Helper.SortNameAndSave("unsorted-names-list.txt", out list);
            Assert.NotNull(list);
            Assert.Equal(expectedList, list);
        }
    }
}