using System;
using TestDataHelper.DataCreatorInterfaces;

namespace TestDataHelper
{
    public class StringDataCreator : IDataCreator<string>, IVariableDataSize<string>
    {
        private const int MinimumValue = 0;
        
        // C# does not allow objects to have a size above 2GB
        // Value derived from 2^30 - 33
        // 33 has to be subtracted to avoid OutOfMemoryException
        private const int MaximumValue = 1073741791;
        
        public string CreateDataPoint()
        {
            // Note: Should this data point be a simple char then?
            return "string.Empty;";
        }

        public string CreateDataPointOfSize(int size)
        {
            VerifyInput(size);

            return new string('a', size);
        }

        private void VerifyInput(int size)
        {
            string message = String.Empty;
            bool invalidInput = false;

            if (size < MinimumValue)
            {
                message = "Size cannot be less than zero.";
                invalidInput = true;
            }
            else if (size > MaximumValue)
            {
                message = $"Size cannot be larger than {MaximumValue}.";
                invalidInput = true;
            }

            if (invalidInput)
            {
                throw new ArgumentOutOfRangeException(nameof(size), message);
            }
        }
    }
}