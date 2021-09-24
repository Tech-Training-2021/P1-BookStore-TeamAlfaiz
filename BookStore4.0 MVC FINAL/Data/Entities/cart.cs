namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cart")]
    public partial class cart
    {
        public int id { get; set; }

        public int? customer_Id { get; set; }

        public int? book_Id { get; set; }

        public int? book_Quantity { get; set; }
    }
}
