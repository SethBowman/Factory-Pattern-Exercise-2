using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataBase(string dbType)
        {
            switch(dbType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                case "mysql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return new SQLDataAccess();
            }
        }
    }
}
