﻿using System.ComponentModel.DataAnnotations;

namespace PriceListApp.Common.Contracts.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }

    public class ExtendedBaseEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}