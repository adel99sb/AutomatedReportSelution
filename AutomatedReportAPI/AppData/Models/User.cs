﻿using AutomatedReportAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.AppData.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(50)]
        public UserTypes Type { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
