using System.Collections.Generic;

namespace L2.ViewModels
{
    public class TheTestReportVM : L2.Models.TheTest, IReportModel
    {
        public class TheTestAnswerVM : L2.Models.TheTestResult
        {
            public string StudentName { get; set; }
        }

        public string SubjectName { get; set; }        
        public List<TheTestAnswerVM> Answers { get; set; }
        public int TotalPages { get; set; }
    }    
}
