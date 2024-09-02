using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }  

		[Required]
		public DateTime CreatedAt { get; set; }

		public int OrderNumber { get; set; }

		[Required]
		[MaxLength(50)]
		public string OrderStatus { get; set; }  
	}
}
