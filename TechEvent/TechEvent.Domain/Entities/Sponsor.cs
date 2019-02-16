using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechEvent.Domain.Entities
{
    public partial class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Description { get; set; }
        public string PageSlug { get; set; }
        public int SponsorTypeId { get; set; }
        public bool Active { get; set; }

        [ForeignKey("SponsorTypeId")]
        [InverseProperty("Sponsors")]
        public virtual SponsorType SponsorType { get; set; }
    }
}
