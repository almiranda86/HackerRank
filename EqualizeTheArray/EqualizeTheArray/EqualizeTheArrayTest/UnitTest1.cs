using EqualizeTheArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqualizeTheArrayTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void TestMethod1()
        {
            //Array arr=[3, 3, 2, 1, 3 ].
            //If we delete arr[2] = 2 and arr[3] = 1, all of the elements in the resulting array, arr[3,3,3], will be equal.
            //Deleting these 2 elements is minimal.
            //Our only other options would be to delete 4 elements to get an array of either 1 or 2.

            //int[] arr = { 3, 3, 2, 1, 3 };
            int[] arr = { 1, 2, 3, 1, 2, 3, 3, 3 };
            int expected = 4;

            int response = Equalize.equalizeArray(arr);

            Assert.AreEqual(expected, response);
        }
    }
}
