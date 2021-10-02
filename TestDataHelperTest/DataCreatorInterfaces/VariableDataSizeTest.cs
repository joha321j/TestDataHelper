using FluentAssertions;
using TestDataHelper.DataCreatorInterfaces;
using TestDataHelperTest.DataCreatorInterfaces.InterfaceTestImplementations;
using Xunit;

namespace TestDataHelperTest.DataCreatorInterfaces
{
    public class VariableDataSizeTest
    {
        [Fact]
        public void Should_returnType()
        {
            IVariableDataSize<string> stringCreator = new VariableDataSizeImplementation<string>("a data point");

            stringCreator.CreateDataPointOfSize(10).Should().BeOfType(typeof(string));
        }
    }
}