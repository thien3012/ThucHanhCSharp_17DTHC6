namespace QuanLySanPham.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Invoice")]
    public partial class Invoice
    {
        [Key]
        [StringLength(20)]
        public string InvoiceNo { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        [StringLength(255)]
        public string Note { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}

	public partial class Invoice
	{
		public static List<Invoice> GetAll()
		{
			QLSPModel context = new QLSPModel();
			return context.Invoices.ToList();
		}
		//public static List<Invoice> GetNgayInvoice(DateTime tuNgay, DateTime denNgay)
		//{
		//	QLSPModel context = new QLSPModel();
		//	return context.Invoices.Where(p=>p.DeliveryDate <= tuNgay && p.DeliveryDate >= denNgay).ToList();
		//}
	}	
}
