using TestDataHelper.DataCreatorInterfaces;

namespace TestDataHelperTest.DataCreatorInterfaces.InterfaceTestImplementations
{
    public class DataCreatorTestImplementation<T>: IDataCreator<T>
    {
        private readonly T _dataPoint;

        public DataCreatorTestImplementation(T dataPoint)
        {
            _dataPoint = dataPoint;
        }

        public T CreateDataPoint()
        {
            return _dataPoint;
        }
    }
}