using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	public class instructor
	{

		public int ins_ID { get; set; }
		public int ins_Key { get; set; }

		public string Name { get; set; }
	}
}
