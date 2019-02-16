using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechEvent.Domain.Entities
{
    public partial class Speaker
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Position { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Skype { get; set; }
        public string GitHub { get; set; }
        public string Twitter { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWebsite { get; set; }
        public string Description { get; set; }
        public string PageSlug { get; set; }
    }
}
