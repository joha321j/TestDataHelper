using System;
using System.Text;
using TestDataHelper.DataCreatorInterfaces;

namespace TestDataHelper
{
    public class StringDataCreator : IDataCreator<string>, IVariableDataSize<string>
    {
        public string CreateDataPoint()
        {
            // Note: Should this data point be a simple char then?
            return "string.Empty;";
        }

        public string CreateDataPointOfSize(int size)
        {
            try
            {
                return new string('a', size);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException(nameof(size),"Size cannot be less than zero.");
            }
        }
    }
}