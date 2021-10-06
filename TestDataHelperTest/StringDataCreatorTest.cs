using System;
using System.Diagnostics;
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
            Process process = Process.GetCurrentProcess();
            long memorySize = process.PrivateMemorySize64;
            
            int length = (int) memorySize;
            string data = _dataCreator.CreateDataPointOfSize(length);

            data.Should().HaveLength(length).And.NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void Should_beAbleToRun_when_givenMaxStringSize()
        {
            // Value derived from 2^30 - 33
            // 33 has to be subtracted to avoid OutOfMemoryException
            int maxObject = 1073741791; 
            _dataCreator.CreateDataPointOfSize(maxObject);
        }

        [Fact]
        public void Should_throwException_when_givenNegativeSize()
        {
            int input = -546;

            _dataCreator
                .Invoking(d => d.CreateDataPointOfSize(input))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>()
                .WithMessage("Size cannot be less than zero. (Parameter 'size')");
        }

        [Fact]
        public void Should_throwException_when_givenTooLangeSize()
        {
            int input = int.MaxValue;
            
            _dataCreator
                .Invoking(d => d.CreateDataPointOfSize(input))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>()
                .WithMessage("Size cannot be larger than 1073741791. (Parameter 'size')");
        }
    }
}