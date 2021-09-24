namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class customer_Order_History
    {
        [Key]
        public int order_Id { get; set; }

        public int? customer_Id { get; set; }

        public int? book_Id { get; set; }

        public int? total_Price { get; set; }

        public DateTime? order_Time { get; set; }

        public int? total_Quantity { get; set; }
    }
}
