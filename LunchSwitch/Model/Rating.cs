namespace LunchSwitch
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lunchswitch.rating")]
    public partial class rating
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ratingId { get; set; }

        [StringLength(255)]
        public string comment { get; set; }

        public int? lunchBox { get; set; }

        public int? gradeUser { get; set; }

        [StringLength(255)]
        public string userId { get; set; }

        public virtual user user { get; set; }
    }
}
