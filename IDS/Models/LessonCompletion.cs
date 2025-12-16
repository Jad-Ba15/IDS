using System;
using System.Collections.Generic;

namespace IDS.Models;

public partial class LessonCompletion
{
    public int Id { get; set; }

    public int LessonId { get; set; }

    public int UserId { get; set; }

    public DateTime? CompletedAt { get; set; }

    public virtual Lesson Lesson { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
