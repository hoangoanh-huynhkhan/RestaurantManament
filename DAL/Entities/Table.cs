namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        [StringLength(50)]
        public string table__id { get; set; }

        [Required]
        [StringLength(50)]
        public string table__name { get; set; }

        [Required]
        [StringLength(50)]
        public string table__local { get; set; }

        public byte is__delete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual TableLocal TableLocal { get; set; }
    }
}
