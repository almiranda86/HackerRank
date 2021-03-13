using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransactionStatementForUsersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //1
            //debit

            //1 13200
            //2 16745
            //3 18859
            //4 10360

            //[
            //  [1,13200],
            //  [2,16745],
            //  [3,18859],
            //  [4,10360]
            //]

            TransactionStatementForUsers.TransactionStatementForUsers transactionStatementForUsers = new TransactionStatementForUsers.TransactionStatementForUsers();
            var response = transactionStatementForUsers.totalTransactions(1, "debit");
            var x = 0;
        }

        [TestMethod]
        public void TestMethod2()
        {
            //2
            //credit

            TransactionStatementForUsers.TransactionStatementForUsers transactionStatementForUsers = new TransactionStatementForUsers.TransactionStatementForUsers();
            var response = transactionStatementForUsers.totalTransactions(2, "credit");
            var x = 0;
        }
    }
}
