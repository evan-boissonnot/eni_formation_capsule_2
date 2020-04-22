using Jeu.Administration.Web.UI.Controllers;
using Jeu.Core.Businesses;
using Jeu.Core.DTOs;
using Jeu.Core.Interfaces;
using Jeu.Core.Web.ViewModels;
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
        public void Test_Create_Run_With_OneItem_Full()
        {
            Mock<IDroideBusiness> mockBusiness = new Mock<IDroideBusiness>();

            mockBusiness.Setup(item => item.AddOne(It.IsAny<Droide>())).Returns(new Droide()
            {
                Id = 1
            });

            DroideController controller = new DroideController(mockBusiness.Object);
            IActionResult viewResult = controller.Create(new Droide());

            Assert.IsType<ViewResult>(viewResult);
            var model = ((ViewResult)viewResult).Model;
            //Assert.IsType<DroideViewModel>(model);
        }

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
            Assert.IsType<ViewResult>(viewResult);

            var model = ((ViewResult)viewResult).Model;
            Assert.IsType<DroideListViewModel>(model);

            DroideListViewModel modelResult = model as DroideListViewModel;
            Assert.NotNull(modelResult.Item);
            Assert.NotEmpty(modelResult.Item);
        }
    }
}
