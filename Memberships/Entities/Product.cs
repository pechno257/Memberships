using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("Product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        public int ProductLinkTextID { get; set; }
        public int ProductLinkTypeID { get; set; }
    }
}