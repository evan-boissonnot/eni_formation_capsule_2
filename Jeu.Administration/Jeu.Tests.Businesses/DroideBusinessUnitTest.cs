using Jeu.Core.Businesses;
using System;
using System.Linq;
using Xunit;

namespace Jeu.Tests.Businesses
{
    public class DroideBusinessUnitTest
    {
        [Fact(DisplayName = "Test du get list sans paramètre")]
        public void Test_GetList_Run_Without_Parameters()
        {
            IDroideBusiness business = new DroideBusiness();

            var list = business.GetList();

            Assert.NotNull(list);
            Assert.True(list.Count() > 0);

            Assert.False(list.Any(item => item.Id <= 0), "Aucun id ne doit être à 0");
        }
    }
}
