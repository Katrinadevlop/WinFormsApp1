using WinFormsApp1;
using Xunit.Sdk;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void btnAdd_ClickTest()
        {
            // Arrange
            var form = new Form1();

            // Act
            form.btnAdd_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(null, form.ResultMessage);
        }

        [TestMethod]
        public void btnDelete_ClickTest()
        {
            // Arrange
            var form = new Form1();

            // Act
            form.btnDelete_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(null, form.ResultMessage);
        }


        [TestMethod]
        public void btnEdit_ClickTest()
        {
            // Arrange
            var form = new Form1();

            // Act
            form.btnEdit_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(null, form.ResultMessage);
        }
    }
}