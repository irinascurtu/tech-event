using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechEvent.Domain.Entities
{
    public partial class Editions
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Tagline { get; set; }
    }
}
