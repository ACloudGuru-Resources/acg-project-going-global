using System.Threading.Tasks;
using ACGProjectGoGlobal.Web.Controllers;
using Shouldly;
using Xunit;

namespace ACGProjectGoGlobal.Web.Tests.Controllers
{
    public class HomeController_Tests: ACGProjectGoGlobalWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
