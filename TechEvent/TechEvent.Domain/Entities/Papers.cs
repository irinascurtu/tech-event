using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechEvent.Domain.Entities
{
    public partial class Papers
    {
        public int Id { get; set; }
        public int EditionId { get; set; }
    }
}
