using System.Collections.Generic;
namespace L2.ViewModels
{
    public class StudentReportVM : IReportModel
    {
        public class TheTestAnswerVM : Models.TheTestResult
        {
            public string TestName { get; set; }
            public string TestDate { get; set; }
            public double TotalScore { get; set; }
        }

        public int Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public int TotalPages { get; set; }
        public List<TheTestAnswerVM> TestResults { get; set; }
    }    
}
