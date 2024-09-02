using EfCoreTask.Models;

namespace EfCoreTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDbContext();

            var ins = new instructor { ins_ID = 4, ins_Key = 20 , Name="Ahmed Ashraf" };

            context.Instructors.Add(ins);
            context.SaveChanges();
        }
    }
}
