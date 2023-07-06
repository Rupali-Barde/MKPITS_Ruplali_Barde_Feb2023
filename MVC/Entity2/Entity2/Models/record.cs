namespace Entity2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("record")]
    public partial class record
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string BookName { get; set; }

        public decimal? Price { get; set; }
    }
}
