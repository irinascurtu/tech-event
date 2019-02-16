using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechEvent.Domain.Entities
{
    public partial class Workshops
    {
        public int Id { get; set; }
        public int SpeakerId { get; set; }
        public int TalkTypeId { get; set; }
    }
}
