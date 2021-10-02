using FluentAssertions;
using TestDataHelper;
using TestDataHelper.DataCreatorInterfaces;
using Xunit;

namespace TestDataHelperTest
{
    public class StringDataCreatorTest
    {
        private readonly StringDataCreator _dataCreator;

        public StringDataCreatorTest()
        {
            _dataCreator = new StringDataCreator();
        }

        [Fact]
        public void Should_implementDataCreatorInterface()
        {
            _dataCreator.Should().BeAssignableTo(typeof(IDataCreator<>));
        }

        [Fact]
        public void Should_implementVariableDataSizeInterface()
        {
            _dataCreator.Should().BeAssignableTo(typeof(IVariableDataSize<>));
        }
        
        [Fact]
        public void Should_returnNonEmptyString()
        {
            string data = _dataCreator.CreateDataPoint();

            data.Should().BeOfType(typeof(string)).And.NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void Should_returnVeryLongString_when_askingForLongString()
        {
            int length = 123456789;
            string data = _dataCreator.CreateDataPointOfSize(length);

            data.Should().HaveLength(length).And.NotBeNullOrWhiteSpace();
        }
    }
}