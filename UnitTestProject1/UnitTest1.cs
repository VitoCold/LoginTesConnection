using System;
using LoginToSql.DA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var connection = new TestConnectionSQL();

            Assert.AreEqual(true, connection.GetConnection());

        }
    }
}
