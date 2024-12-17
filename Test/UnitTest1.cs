using WinFormsApp1;
using Xunit.Sdk;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void btnAdd_Click_SetsResultMessage()
        {
            // Arrange
            var form = new Form1();

            // Act
            form.btnAdd_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Кнопка нажата!", form.ResultMessage);
        }

        [TestMethod]
        public 
    }
}