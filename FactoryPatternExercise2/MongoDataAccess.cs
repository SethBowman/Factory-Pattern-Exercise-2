using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am loading from a Mongo db..");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving to a Mongo db..");
        }
    }
}
