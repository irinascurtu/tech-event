﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechEvent.Domain.Entities
{
    public partial class TalkType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
    }
}
