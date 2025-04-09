using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWebSite.Controllers;
using System.Collections.Generic;

namespace TestWebSite.Controllers.Tests
{
    [TestClass()]
    public class ValuesControllerTests
    {
        [TestMethod()]
        public void Get_ShouldReturnDefaultValues()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            CollectionAssert.AreEqual(new List<string> { "value1", "value2" }, new List<string>(result));
        }

        [TestMethod()]
        public void Get_WithId_ShouldReturnValue()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            int testId = 5;

            // Act
            string result = controller.Get(testId);

            // Assert
            Assert.AreEqual("value", result);
        }
    }
}
