namespace TestDataHelper.DataCreatorInterfaces
{
    public interface IVariableDataSize<out T>
    {
        T CreateDataPointOfSize(int size);
    }
}