using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
namespace Linklist
{
    [TestClass]
    public class UnitTest1
    {
        public LinkedLists linklist =new LinkedLists();
       
        /// <summary>
        /// Givens the value presentin list return true.
        /// </summary>
        [TestMethod]
        public void GivenValue_PresentinList_ReturnTrue()
        {
            linklist.Add(56);
            linklist.Add(30);
            linklist.Add(70);
            Node Result = linklist.FindElemnt(30);
            Assert.AreEqual(30,Result.data);
        }

        /// <summary>
        /// Adds the 40 value between30-->40-->70 return added.
        /// </summary>
        [TestMethod]
        public  void AddValue_Between3070_ReturnAdded()
        {
            linklist.Add(56);
            linklist.Add(30);
            linklist.Add(70);
            linklist.InsertPositon(3,40);
            Node Result = linklist.FindElemnt(40);
            Assert.AreEqual(40, Result.data);
        }

        /// <summary>
        /// 40 Givens the vlaue prsent then delete retutn count.
        /// </summary>
        [TestMethod]
        public void GivenVlauePrsent_ThenDelete_RetutnCount()
        {
            linklist.Add(70);
            linklist.Add(40);
            linklist.Add(56);
            linklist.Add(30);
            linklist.DeleteNode(40);
            int Result = linklist.Count(); 
            Assert.AreEqual(3, Result);
        }
    }
}
