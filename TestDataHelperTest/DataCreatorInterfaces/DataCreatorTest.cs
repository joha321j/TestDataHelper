using FluentAssertions;
using TestDataHelper.DataCreatorInterfaces;
using TestDataHelperTest.DataCreatorInterfaces.InterfaceTestImplementations;
using Xunit;

namespace TestDataHelperTest.DataCreatorInterfaces
{
    public class DataCreatorTest
    {
        [Fact]
        public void Should_returnType()
        {
            IDataCreator<string> stringCreator = new DataCreatorTestImplementation<string>("a data point");

            stringCreator.CreateDataPoint().Should().BeOfType(typeof(string));
        }
    }
}