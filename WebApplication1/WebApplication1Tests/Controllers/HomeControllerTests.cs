using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using WebApplication1.Services;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void UglyFunctionTest()
        {

            // Act
            bool result = Helper.UglyFunction();

            // Assert
            Assert.IsTrue(result, "Expected UglyFunction to return true, but it returned false.");
            Assert.IsFalse(result, "Expected UglyFunction to return true, but it returned false.");
        }
    }
}