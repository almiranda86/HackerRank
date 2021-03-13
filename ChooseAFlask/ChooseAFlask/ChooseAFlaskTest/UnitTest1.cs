using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChooseAFlaskTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> requirements = new List<int>() { 4, 6, 6, 7 };
            int flaskTypes = 3;

            List<List<int>> markings = new List<List<int>>();

            markings.Add(new List<int> { 0, 3 });
            markings.Add(new List<int> { 0, 5 });
            markings.Add(new List<int> { 0, 7 });
            markings.Add(new List<int> { 1, 6 });
            markings.Add(new List<int> { 1, 8 });
            markings.Add(new List<int> { 1, 9 });
            markings.Add(new List<int> { 2, 3 });
            markings.Add(new List<int> { 2, 5 });
            markings.Add(new List<int> { 2, 6 });

            int expected = 0;

            int result = ChooseAFlask.Result.chooseFlask(requirements, flaskTypes, markings);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> requirements = new List<int>() { 4, 6 };
            int flaskTypes = 2;
            List<List<int>> markings = new List<List<int>>();
            markings.Add(new List<int> { 0, 5 });
            markings.Add(new List<int> { 0, 7 });
            markings.Add(new List<int> { 0, 10 });
            markings.Add(new List<int> { 1, 4 });
            markings.Add(new List<int> { 1, 10 });

            int expected = 0;

            int result = ChooseAFlask.Result.chooseFlask(requirements, flaskTypes, markings);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> requirements = new List<int>() { 673, 1257, 958, 973, 669, 454, 1420, 853, 1118, 1005 };
            int flaskTypes = 15;
            List<List<int>> markings = new List<List<int>>();
            markings.Add(new List<int> { 0, 1 });
            markings.Add(new List<int> { 0, 2 });
            markings.Add(new List<int> { 0, 32 });
            markings.Add(new List<int> { 0, 86 });
            markings.Add(new List<int> { 0, 87 });
            markings.Add(new List<int> { 0, 89 });
            markings.Add(new List<int> { 0, 99 });
            markings.Add(new List<int> { 0, 139 });
            markings.Add(new List<int> { 0, 154 });
            markings.Add(new List<int> { 0, 247 });
            markings.Add(new List<int> { 0, 353 });
            markings.Add(new List<int> { 0, 533 });
            markings.Add(new List<int> { 0, 729 });
            markings.Add(new List<int> { 0, 2683 });
            markings.Add(new List<int> { 0, 5715 });
            markings.Add(new List<int> { 0, 8187 });
            markings.Add(new List<int> { 0, 10724 });
            markings.Add(new List<int> { 0, 25119 });
            markings.Add(new List<int> { 0, 130561 });
            markings.Add(new List<int> { 0, 193836 });
            markings.Add(new List<int> { 0, 296340 });
            markings.Add(new List<int> { 0, 299561 });
            markings.Add(new List<int> { 0, 1450991 });
            markings.Add(new List<int> { 1, 1 });
            markings.Add(new List<int> { 1, 7 });
            markings.Add(new List<int> { 1, 30 });
            markings.Add(new List<int> { 1, 186 });
            markings.Add(new List<int> { 1, 965 });
            markings.Add(new List<int> { 1, 13857 });
            markings.Add(new List<int> { 1, 556519 });
            markings.Add(new List<int> { 2, 1 });
            markings.Add(new List<int> { 2, 4 });
            markings.Add(new List<int> { 2, 21 });
            markings.Add(new List<int> { 2, 1008 });
            markings.Add(new List<int> { 2, 14488 });
            markings.Add(new List<int> { 3, 2 });
            markings.Add(new List<int> { 3, 7 });
            markings.Add(new List<int> { 3, 9 });
            markings.Add(new List<int> { 3, 18 });
            markings.Add(new List<int> { 3, 20 });
            markings.Add(new List<int> { 3, 47 });
            markings.Add(new List<int> { 3, 48 });
            markings.Add(new List<int> { 3, 105 });
            markings.Add(new List<int> { 3, 203 });
            markings.Add(new List<int> { 3, 469 });
            markings.Add(new List<int> { 3, 962 });
            markings.Add(new List<int> { 3, 4145 });
            markings.Add(new List<int> { 3, 53019 });
            markings.Add(new List<int> { 3, 115406 });
            markings.Add(new List<int> { 3, 874965 });
            markings.Add(new List<int> { 3, 1059655 });
            markings.Add(new List<int> { 3, 1131207 });
            markings.Add(new List<int> { 4, 1 });
            markings.Add(new List<int> { 4, 1 });
            markings.Add(new List<int> { 4, 1 });
            markings.Add(new List<int> { 4, 2 });
            markings.Add(new List<int> { 4, 6 });
            markings.Add(new List<int> { 4, 7 });
            markings.Add(new List<int> { 4, 9 });
            markings.Add(new List<int> { 4, 16 });
            markings.Add(new List<int> { 4, 48 });
            markings.Add(new List<int> { 4, 100 });
            markings.Add(new List<int> { 4, 674 });
            markings.Add(new List<int> { 4, 1073 });
            markings.Add(new List<int> { 4, 2087 });
            markings.Add(new List<int> { 4, 4411 });
            markings.Add(new List<int> { 4, 6540 });
            markings.Add(new List<int> { 4, 9498 });
            markings.Add(new List<int> { 4, 11177 });
            markings.Add(new List<int> { 4, 105185 });
            markings.Add(new List<int> { 4, 258420 });
            markings.Add(new List<int> { 4, 602779 });
            markings.Add(new List<int> { 5, 1 });
            markings.Add(new List<int> { 5, 7 });
            markings.Add(new List<int> { 5, 44 });
            markings.Add(new List<int> { 5, 155 });
            markings.Add(new List<int> { 5, 293 });
            markings.Add(new List<int> { 5, 428 });
            markings.Add(new List<int> { 5, 3661 });
            markings.Add(new List<int> { 5, 54584 });
            markings.Add(new List<int> { 5, 130213 });
            markings.Add(new List<int> { 5, 1223172 });
            markings.Add(new List<int> { 6, 25 });
            markings.Add(new List<int> { 6, 47 });
            markings.Add(new List<int> { 6, 1127 });
            markings.Add(new List<int> { 6, 26574 });
            markings.Add(new List<int> { 6, 76873 });
            markings.Add(new List<int> { 6, 79755 });
            markings.Add(new List<int> { 7, 3 });
            markings.Add(new List<int> { 7, 4 });
            markings.Add(new List<int> { 7, 14 });
            markings.Add(new List<int> { 7, 1784 });
            markings.Add(new List<int> { 7, 1989 });
            markings.Add(new List<int> { 7, 2176 });
            markings.Add(new List<int> { 7, 6973 });
            markings.Add(new List<int> { 7, 10503 });
            markings.Add(new List<int> { 7, 27059 });
            markings.Add(new List<int> { 7, 151879 });
            markings.Add(new List<int> { 7, 467126 });
            markings.Add(new List<int> { 7, 1688926 });
            markings.Add(new List<int> { 8, 30 });
            markings.Add(new List<int> { 8, 28708 });
            markings.Add(new List<int> { 8, 245108 });

            int expected = 4;

            int result = ChooseAFlask.Result.chooseFlask(requirements, flaskTypes, markings);

            Assert.AreEqual(expected, result);
        }
    }
}
