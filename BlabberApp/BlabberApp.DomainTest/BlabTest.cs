using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class BlabTest
    {
        [TestMethod]
        public void TestSetGetMessage()
        {
            //Arrange
            Blab harness = new Blab();
            string expected = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            harness.Message = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            //Act
            string actual = harness.Message;
            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestSetGetUserID()
        {
            //Arrange
            Blab harness = new Blab();
            string expected = "8f03e1a5-21ce-4a66-9229-0078bb170fa2";
            harness.UserID = "8f03e1a5-21ce-4a66-9229-0078bb170fa2";
            //Act
            string actual = harness.UserID;
            //Assert
            Assert.AreEqual(actual, expected);

        }
    }
}
