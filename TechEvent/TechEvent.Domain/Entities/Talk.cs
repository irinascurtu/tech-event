using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechEvent.Domain.Entities
{
    public partial class Talk
    {
        public int Id { get; set; }
        public int SpeakerId { get; set; }
        public int TalkTypeId { get; set; }
    }
}
