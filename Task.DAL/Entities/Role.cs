﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Task.DAL.Entities
{
    public class Role 
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}