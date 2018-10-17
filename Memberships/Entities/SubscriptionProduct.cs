using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("SubscriptionProduct")]
    public class SubscriptionProduct
    {
        [Required]
        [Key, Column(Order = 1)]
        public int SubcriptionID { get; set; }

        [Required]
        [Key, Column(Order = 2)]
        public int ProductID { get; set; }

        [NotMapped]
        public int OldSubscriptionID { get; set; }

        [NotMapped]
        public int OldProductID { get; set; }
    }
}