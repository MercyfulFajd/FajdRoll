using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;


namespace TestZone
{
    [TestClass]
    public class PageTest
    {
        [TestMethod]
        public void TestPage1()
        {

            Page pag = new Page(1);
            Assert.AreEqual(1, pag.PageNum, "Testing the Page's number");

        }
    }
}


