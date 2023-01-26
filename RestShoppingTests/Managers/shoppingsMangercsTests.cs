using Microsoft.VisualStudio.TestTools.UnitTesting;
using shoppinglist;

namespace RestShopping.Managers.Tests
{
    [TestClass()]
    public class shoppingsMangercsTests
    {

        private static readonly shoppingsMangercs _manager = new();
        [TestMethod()]
        public void GetAllTest()
        {
            var actual = _manager.GetAll();
            
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(typeof(List<shopping>), actual.GetType());


        }

       
    }
}

