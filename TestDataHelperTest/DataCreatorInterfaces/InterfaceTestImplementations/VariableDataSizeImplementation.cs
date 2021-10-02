using TestDataHelper.DataCreatorInterfaces;

namespace TestDataHelperTest.DataCreatorInterfaces.InterfaceTestImplementations
{
    public class VariableDataSizeImplementation<T> : IVariableDataSize<T>
    {
        private readonly T _dataPoint;

        public VariableDataSizeImplementation(T dataPoint)
        {
            _dataPoint = dataPoint;
        }


        public T CreateDataPointOfSize(int size)
        {
            return CreateDataPointOfSize((long) size);
        }

        public T CreateDataPointOfSize(long size)
        {
            return _dataPoint;
        }
    }
}