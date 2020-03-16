using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.DataStore;
using BlabberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class InMemory_Blab_UnitTests
    {
        private InMemory<Blab> _harness;
        public InMemory_Blab_UnitTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes")
                .Options;
            _harness = new InMemory<Blab>(new ApplicationContext(options));
        }

        [TestMethod]
        public void Add_Blab_GetById_Success()
        {
            // Arrange
            string Email = "foo@example.com";
            Blab Expected = new Blab();
            Expected.Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer gravida posuere pretium. Cras maximus nibh sed accumsan elementum. Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            Expected.UserID = Email;
            _harness.Add(Expected);
            // Act
            Blab Actual = (Blab)_harness.GetByUserId(Email);
            // Assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Update_Blab_GetById_Success()
        {
            // Arrange
            string Email = "foo@example.com";
            Blab Expected = (Blab)_harness.GetByUserId(Email);
            Expected.Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer gravida posuere pretium. Cras maximus nibh sed accumsan elementum. Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            //Expected.UserID = Email;
            //_harness.Add(Expected);

            Expected.Message = "Take your place at my side. Join the dark side and we can rule together as Father and Son";
            _harness.Update(Expected);
            // Act
            Blab Actual = (Blab)_harness.GetByUserId(Email);
            // Assert
            Assert.AreEqual(Expected, Actual);
            
        }

        [TestMethod]
        public void Remove_Blab_GetById_Success()
        {
            // Arrange
            string Email = "foo@example.com";
            Blab Expected = (Blab)_harness.GetByUserId(Email);
            // Blab Expected = new Blab();
            // Expected.Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer gravida posuere pretium. Cras maximus nibh sed accumsan elementum. Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            // Expected.UserID = Email;
            // _harness.Add(Expected);

            //Expected.Message = "Take your place at my side. Join the dark side and we can rule together as Father and Son";
            _harness.Remove(Expected);
            // Act
            Blab Actual = (Blab)_harness.GetByUserId(Email);
            // Assert
            Assert.AreNotEqual(Expected, Actual);
        }
    }
}