using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	[Table("Products")]
	public class Product
	{
		[Key]
		public int ProductId { get; set; }  

		[Required]
		[MaxLength(100)]
		public string ProductName { get; set; }

		public decimal DiscountPercentage { get; set; }
		public bool IsActive { get; set; }
	}
}
