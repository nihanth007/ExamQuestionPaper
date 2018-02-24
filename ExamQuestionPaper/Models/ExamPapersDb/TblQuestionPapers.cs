using System;
using System.Collections.Generic;

namespace ExamQuestionPaper.Models.ExamPapersDb
{
    public partial class TblQuestionPapers
    {
        public int Id { get; set; }
        public int QuestionPaperId { get; set; }
        public int ChunkId { get; set; }
        public string ChunkHash { get; set; }
    }
}
