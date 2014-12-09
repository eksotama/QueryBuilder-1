using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueryBuilder.Tests
{
    [TestClass]
    public class BasicSelectTests
    {
        [TestMethod]
        public void CeateBasicSelectStatement()
        {
            const string expected = "SELECT Id  FROM People";

            var queryBuilder = new SelectQueryBuilder();
            queryBuilder.SelectColumn("Id");
            queryBuilder.SelectFromTable("People");

            var result = queryBuilder.BuildQuery();

            Assert.AreEqual(result, expected);
        }
    }
}
