using System;
using System.Collections.Generic;

namespace ExamQuestionPaper.Models.ExamPapersDb
{
    public partial class TblUsers
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
