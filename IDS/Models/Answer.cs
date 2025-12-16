using System;
using System.Collections.Generic;

namespace IDS.Models;

public partial class Answer
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public string AnswerText { get; set; } = null!;

    public bool? IsCorrect { get; set; }

    public int OrderIndex { get; set; }

    public virtual Question Question { get; set; } = null!;

    public virtual ICollection<QuizResponse> QuizResponses { get; set; } = new List<QuizResponse>();
}
