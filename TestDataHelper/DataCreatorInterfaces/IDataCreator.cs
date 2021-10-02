namespace TestDataHelper.DataCreatorInterfaces
{
    public interface IDataCreator<out T>
    {
        T CreateDataPoint();
    }
}