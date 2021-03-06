﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("UserSubscription")]
    public class UserSubscription
    {
        [Required ]
        [Key, Column(Order = 1)]
        public int SubscriptionID { get; set; }

        [MaxLength(128)]
        [Required]
        [Key, Column(Order = 2)]
        public string UserID { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}