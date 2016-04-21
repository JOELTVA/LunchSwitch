namespace LunchSwitch
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lunchswitch.user")]
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            lunchboxes = new HashSet<lunchbox>();
            ratings = new HashSet<rating>();
            meetups = new HashSet<meetup>();
        }

        [StringLength(255)]
        public string userId { get; set; }

        [StringLength(255)]
        public string city { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string fullName { get; set; }

        [StringLength(255)]
        public string mobileNr { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lunchbox> lunchboxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rating> ratings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<meetup> meetups { get; set; }
    }
}
