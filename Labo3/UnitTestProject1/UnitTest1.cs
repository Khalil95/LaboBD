using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using ClassLibrary1;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void CanGetCostumers()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Costumers.ToList().Count);
            }
        }

        private CompanyContext GetContext()
        {
            return new CompanyContext();
        }
    }
}
