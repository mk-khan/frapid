﻿using System.ComponentModel.DataAnnotations;

namespace Frapid.Authorization.ViewModels
{
    public class AccessPolicyInfo
    {
        [Required]
        public string EntityName { get; set; }
        [Required]
        public int AccessTypeId { get; set; }
        [Required]
        public bool AllowAccess { get; set; }
    }
}