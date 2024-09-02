using EfCoreTask.Models;

namespace EfCoreTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var context = new ApplicationDbContext();

            var Target = context.Customers.Find(603);
			Console.WriteLine($"ID:{Target.CustomerId} , Name:{Target.FirstName}");

			var First = context.Customers.First();
			Console.WriteLine($"ID:{First.CustomerId} , Name:{First.FirstName}");

			var Last = context.Customers.OrderBy(b=>b.CustomerId).Last( );
			Console.WriteLine($"ID:{Last.CustomerId} , Name:{Last.FirstName}");

			/*  foreach (var item in query) {
				  Console.WriteLine($"ID:{item.CustomerId} , Name:{item.FirstName}");
			 }*/

		}
	}
}
