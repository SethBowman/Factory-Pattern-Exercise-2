namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What db do you want to use? ('sql', 'mongo', or 'list')");
            var dbType = Console.ReadLine();

            var dataAccess = DataAccessFactory.GetDataBase(dbType);

            List<Product> products = dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
