using Jeu.Administration.Web.UI.Controllers;
using Jeu.Core.Businesses;
using Jeu.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Jeu.Tests.Web.UI
{
    public class DroideCrontrollerUnitTest
    {
        [Fact]
        public void Test_Index_With_GetList_Not_Empty()
        {
            Mock<IDroideBusiness> mockBusiness = new Mock<IDroideBusiness>();

            mockBusiness.Setup(item => item.GetList()).Returns(new List<Droide>()
            { 
                new Droide()
            });

            DroideController controller = new DroideController(mockBusiness.Object);

            IActionResult viewResult = controller.Index();
        }
    }
}
