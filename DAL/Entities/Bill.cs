namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [Key]
        [StringLength(50)]
        public string bill_id { get; set; }

        [Required]
        [StringLength(50)]
        public string oder__id { get; set; }

        [Required]
        [StringLength(50)]
        public string table__id { get; set; }

        [Required]
        [StringLength(50)]
        public string employer__id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date__create { get; set; }

        public int payment__type { get; set; }

        [StringLength(50)]
        public string bill__description { get; set; }

        public double bill__total { get; set; }

        public byte is__delete { get; set; }

        public virtual Employer Employer { get; set; }

        public virtual Oder Oder { get; set; }

        public virtual Table Table { get; set; }
    }
}
