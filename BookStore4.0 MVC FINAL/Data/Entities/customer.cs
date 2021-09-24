namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [Key]
        public int customer_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string customer_Name { get; set; }

        [StringLength(255)]
        public string customer_Email { get; set; }

        public int? customer_Age { get; set; }

        [Required]
        [StringLength(255)]
        public string customer_Phone { get; set; }

        [StringLength(255)]
        public string customer_Address { get; set; }

        [Required]
        [StringLength(255)]
        public string customer_Password { get; set; }

        [StringLength(255)]
        public string customer_Gender { get; set; }
    }
}
