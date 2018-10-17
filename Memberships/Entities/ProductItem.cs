using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("ProductItem")]
    public class ProductItem
    {
        [Required]
        [Key, Column(Order = 1)]
        public int ProductID { get; set; }

        [Required]
        [Key, Column(Order = 2)]
        public int ContentID { get; set; }

        [NotMapped]
        public int OldProductID { get; set; }

        [NotMapped]
        public int OldItemID { get; set; }
    }
}