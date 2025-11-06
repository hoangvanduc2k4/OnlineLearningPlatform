using System;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class QuizSubmitViewModel
    {
        public long QuizId { get; set; }
        public Dictionary<long, long> Answers { get; set; } = new(); // QuestionId -> OptionId
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
    }
}
