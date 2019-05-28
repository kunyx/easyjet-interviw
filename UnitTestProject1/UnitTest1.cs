using easyjet_interviw;
using easyjet_interviw.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Repository<Storeable> repo;
        private Storeable item1, item2;
        private void Test_Init()
        {
            repo = new Repository<Storeable>();
            item1 = new Storeable { Id = 1, Item = "1st item" };
            item2 = new Storeable { Id = 2, Item = "2nd item" };
        }

        [TestMethod]
        public void TestMethod_All_equalType()
        {
            Test_Init();
            var expected = repo.All();
            Assert.IsTrue(expected.GetType() == typeof(List<Storeable>));
        }

        [TestMethod]
        public void TestMethod_Save_item1()
        {
            Test_Init();
            repo.Save(item1);
            var expected = repo.All();
            Assert.IsTrue(expected.Contains(item1));
        }

        [TestMethod]
        public void TestMethod_Find_byId()
        {
            Test_Init();
            repo.Save(item1);
            repo.Save(item2);
            var expected = repo.FindById(2);
            Assert.AreEqual(item2, expected);
        }

        [TestMethod]
        public void TestMethod_Delete_item1()
        {
            Test_Init();
            repo.Save(item1);
            repo.Delete(1);
            var expected = repo.All();
            Assert.IsFalse(expected.Contains(item1));
        }
    }
}