namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            OderDetails = new HashSet<OderDetail>();
        }

        [Key]
        [StringLength(50)]
        public string food__id { get; set; }

        [Required]
        [StringLength(50)]
        public string food__name { get; set; }

        [Required]
        [StringLength(50)]
        public string food__description { get; set; }

        public double food__price { get; set; }

        [Required]
        [StringLength(50)]
        public string food__type { get; set; }

        [StringLength(50)]
        public string food__image__path { get; set; }

        public byte is_delete { get; set; }

        public virtual FoodType FoodType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OderDetail> OderDetails { get; set; }
    }
}
