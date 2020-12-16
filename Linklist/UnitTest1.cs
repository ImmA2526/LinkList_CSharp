using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
namespace Linklist
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenValue_PresentinList_ReturnTrue()
        {
            LinkedLists linklist = new LinkedLists();
            linklist.Add(56);
            linklist.Add(30);
            linklist.Add(70);
            Node Result = linklist.FindElemnt(30);
            Assert.AreEqual(30,Result.data);
        }
    }
}
