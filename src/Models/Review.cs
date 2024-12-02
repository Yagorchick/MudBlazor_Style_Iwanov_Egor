﻿using System;
using System.Collections.Generic;

namespace BlazorServer_NET6_Iwanov_Egor.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int? CourseId { get; set; }

    public int? UserId { get; set; }

    public int? Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Course? Course { get; set; }

    public virtual User? User { get; set; }
}
