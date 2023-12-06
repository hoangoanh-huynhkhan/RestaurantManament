namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int detail__id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string oder__id { get; set; }

        [Required]
        [StringLength(50)]
        public string food__id { get; set; }

        public int quantity { get; set; }

        public double total { get; set; }

        public byte is__delete { get; set; }

        public virtual Food Food { get; set; }

        public virtual Oder Oder { get; set; }

        public virtual OderDetail OderDetails1 { get; set; }

        public virtual OderDetail OderDetail1 { get; set; }
    }
}
