using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint3.Task3.V28.Lib;

namespace Tyuiu.PoznyakIA.Sprint3.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "f35hyt t4j 3gkg45";
            char item = 'r';


            string res = ds.ReplaceNumOnChar(str, item);

            string wait = "frrhyt trj rgkgrr";

            Assert.AreEqual(wait, res);
        }
    }
}
