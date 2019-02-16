using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechEvent.Domain.Entities
{
    public partial class SponsorType
    {
        public SponsorType()
        {
            Sponsors = new HashSet<Sponsor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("SponsorType")]
        public virtual ICollection<Sponsor> Sponsors { get; set; }
    }
}
