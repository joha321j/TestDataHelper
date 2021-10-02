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
            throw new System.NotImplementedException();
        }

        public string CreateDataPointOfSize(long size)
        {
            throw new System.NotImplementedException();
        }
    }
}