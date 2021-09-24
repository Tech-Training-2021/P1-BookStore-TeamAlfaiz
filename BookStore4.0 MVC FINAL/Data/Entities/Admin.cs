namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int admin_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string admin_Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string admin_password { get; set; }
    }
}
