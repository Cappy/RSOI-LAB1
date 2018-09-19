using System;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using System.Linq;
using RSOILab1.Controllers;

namespace UnitTests
{
    public class HomeControllerTests
    {

        [Fact]
        public void IndexViewDataMessage()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index("",null) as ViewResult;
            Assert.Null(result?.ViewData["nums"]);
        }


        [Fact]
        public void IndexViewNameEqualIndex()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index("",null) as ViewResult;
            Assert.NotEqual("About", result?.ViewName);
        }

    }
}
