using System;
using System.Collections.Generic;

namespace IDS.Models;

public partial class QuizResponse
{
    public int Id { get; set; }

    public int AttemptId { get; set; }

    public int QuestionId { get; set; }

    public int? SelectedAnswerId { get; set; }

    public string? TextAnswer { get; set; }

    public bool IsCorrect { get; set; }

    public virtual QuizAttempt Attempt { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;

    public virtual Answer? SelectedAnswer { get; set; }
}
