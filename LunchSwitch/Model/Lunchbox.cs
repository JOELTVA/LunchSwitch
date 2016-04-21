namespace LunchSwitch
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lunchswitch.lunchbox")]
    public partial class lunchbox
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long lunchBoxId { get; set; }

        [StringLength(255)]
        public string content { get; set; }

        [StringLength(255)]
        public string foodCategory { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string picture { get; set; }

        public int? quantity { get; set; }

        [StringLength(255)]
        public string userId { get; set; }

        public virtual user user { get; set; }
    }
}
