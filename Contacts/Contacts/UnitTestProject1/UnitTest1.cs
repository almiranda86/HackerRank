using Contacts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int queriesRows = 4;
            string[][] queries = new string[queriesRows][];

            for (int queriesRowItr = 0; queriesRowItr < queriesRows; queriesRowItr++)
            {
                if(queriesRowItr == 0)
                {
                    queries[queriesRowItr] = "add hack".Split(' ');
                }

                if (queriesRowItr == 1)
                {
                    queries[queriesRowItr] = "add hackerrank".Split(' ');
                }

                if (queriesRowItr == 2)
                {
                    queries[queriesRowItr] = "find hac".Split(' ');
                }

                if (queriesRowItr == 3)
                {
                    queries[queriesRowItr] = "find hak".Split(' ');
                }
            }

            int[] result = Solution.contacts(queries);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int queriesRows = 7;
            string[][] queries = new string[queriesRows][];

            for (int queriesRowItr = 0; queriesRowItr < queriesRows; queriesRowItr++)
            {
                if (queriesRowItr == 0)
                {
                    queries[queriesRowItr] = "add ed".Split(' ');
                }

                if (queriesRowItr == 1)
                {
                    queries[queriesRowItr] = "add eddie".Split(' ');
                }

                if (queriesRowItr == 2)
                {
                    queries[queriesRowItr] = "add edward".Split(' ');
                }

                if (queriesRowItr == 3)
                {
                    queries[queriesRowItr] = "find ed".Split(' ');
                }

                if (queriesRowItr == 4)
                {
                    queries[queriesRowItr] = "add edwina".Split(' ');
                }


                if (queriesRowItr == 5)
                {
                    queries[queriesRowItr] = "find edw".Split(' ');
                }


                if (queriesRowItr == 6)
                {
                    queries[queriesRowItr] = "find a".Split(' ');
                }
            }

            int[] result = Solution.contacts(queries);

        }
    }
}
