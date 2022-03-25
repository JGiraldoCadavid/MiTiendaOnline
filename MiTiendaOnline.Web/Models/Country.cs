﻿using System.ComponentModel.DataAnnotations;

namespace MiTiendaOnline.Web.Models
{
    public class Country
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
