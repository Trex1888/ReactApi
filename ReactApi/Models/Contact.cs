﻿using System.ComponentModel.DataAnnotations;

namespace ReactApi.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
    }
}