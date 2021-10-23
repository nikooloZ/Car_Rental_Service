using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenterV1.DTO
{
	public class Order : BaseEntity<int>
	{
		[Required]
		public DateTime Date { get; set; }

		[Required]
		public Customer Customer { get; set; }

		public ICollection<OrderDetails> OrderDetails { get; set; }
	}

	public class OrderDetails : BaseEntity<int>
	{
		[Required]
		public Car Car { get; set; }

		public Driver Driver { get; set; }

		[Required]
		[Column(TypeName = "money")]
		public double Price { get; set; }

		[Required]
		public DateTime OrderFrom { get; set; }

		[Required]
		public DateTime OrderTo { get; set; }

		public ICollection<OrderComment> OrderComment { get; set; }

		public OrderCommit OrderCommit { get; set; }
	}

	public class OrderCommit : BaseEntity<int>
	{
		[Key]
		[ForeignKey("OrderDetails")]
		public override int ID { get; set; }

		[Required]
		public DateTime CommitDate { get; set; }

		[Required]
		public OrderDetails OrderDetails { get; set; }
	}

	public class OrderComment : BaseEntity<int>
	{
		[Required]
		public string Comment { get; set; }

		[Required]
		public DateTime Date { get; set; }
	}
}
