using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
namespace TestZone
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void TestBook1()
        {
            Book bok = new Book();
            Assert.AreEqual("Hajnal", bok.Title, "Testing the Book's title");

        }
    }
}
