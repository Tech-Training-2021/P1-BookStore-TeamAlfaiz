namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bookDetail
    {
        [Key]
        public int book_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string book_Name { get; set; }

        [Required]
        [StringLength(255)]
        public string book_Author { get; set; }

        public int book_Price { get; set; }

        public int book_Category_id { get; set; }

        public int book_Quantity { get; set; }

        public int store_Id { get; set; }
    }
}
