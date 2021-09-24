namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class category
    {
        [Key]
        public int category_id { get; set; }

        [Required]
        [StringLength(255)]
        public string book_category { get; set; }
    }
}
