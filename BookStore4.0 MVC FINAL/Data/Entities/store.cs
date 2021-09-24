namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("store")]
    public partial class store
    {
        [Key]
        public int store_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string store_Name { get; set; }

        [Required]
        [StringLength(255)]
        public string store_Location { get; set; }
    }
}
