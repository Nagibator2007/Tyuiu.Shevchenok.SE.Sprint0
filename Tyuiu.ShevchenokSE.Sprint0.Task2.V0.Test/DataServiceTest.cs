using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShevchenokSE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShevchenokSE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Sergey";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Hello, Sergey", res);
        }
    }
}

