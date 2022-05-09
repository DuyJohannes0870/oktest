﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FindingJobDLL.Entities
{
    public partial class Review
    {
        public int JobId { get; set; }
        public int ReviewId { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
