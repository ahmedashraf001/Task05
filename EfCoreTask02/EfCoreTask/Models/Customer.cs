using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	[Table("Customers")]
	public class Customer
	{
		[Key]
 		public int CustomerId { get; set; }  

		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }  

		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }  

 	}
}
