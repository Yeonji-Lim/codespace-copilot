// add a namespace for WheaterForecastController
using WebApi.Controllers;
namespace WebApiTests;

[TestClass]
public class WeatherForecastControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a test method that tests the GetRange method of WeatherForecastController
    [TestMethod]
    public void GetRangeTest()
    {
        // arrange
        var controller = new WeatherForecastController(null);

        // act
        var result = controller.GetRange(new DateRange { Length = 3 });

        // assert
        Assert.AreEqual(3, result.Count());
    }

}