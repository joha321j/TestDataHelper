﻿using TestDataHelper.DataCreatorInterfaces;

namespace TestDataHelper
{
    public class StringDataCreator : IDataCreator<string>, IVariableDataSize<string>
    {
        public string CreateDataPoint()
        {
            return string.Empty;
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