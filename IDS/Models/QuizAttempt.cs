using System;
using System.Collections.Generic;

namespace IDS.Models;

public partial class QuizAttempt
{
    public int Id { get; set; }

    public int QuizId { get; set; }

    public int UserId { get; set; }

    public decimal Score { get; set; }

    public int TotalPoints { get; set; }

    public int EarnedPoints { get; set; }

    public DateTime StartedAt { get; set; }

    public DateTime? SubmittedAt { get; set; }

    public int? TimeTaken { get; set; }

    public virtual Quiz Quiz { get; set; } = null!;

    public virtual ICollection<QuizResponse> QuizResponses { get; set; } = new List<QuizResponse>();

    public virtual User User { get; set; } = null!;
}
