using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Web.Mvc;

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }

        [AllowHtml]
        public string HTML { get; set; }

        [DefaultValue(0)]
        [DisplayName("Wait Days")]
        public int WaitDays { get; set; }

        public string HTMLShort { get {
                return HTML == null || HTML.Length < 50 ? HTML : HTML.Substring(0, 50); } }

        public int ItemTypeID { get; set; }
        public int SectionID { get; set; }
        public int PartID { get; set; }

        [DisplayName("Is Free")]
        public bool IsFree { get; set; }

        [DisplayName("Item Types")]
        public ICollection<ItemType> ItemTypes { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}