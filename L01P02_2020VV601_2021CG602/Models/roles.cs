﻿using System.ComponentModel.DataAnnotations;

namespace L01P02_2020VV601_2021CG602.Models
{
    public class roles
    {
        [Key]
        public int rolId { get; set; }
        public string? rol { get; set; }
    }
}
