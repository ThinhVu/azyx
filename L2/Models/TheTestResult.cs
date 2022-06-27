using L1;
using L1.Attributes;

namespace L2.Models
{
    [DbTable("TheTestResultTbl")]
    public class TheTestResult : BaseRecord
    {
        [DbField("StudentId", System.Data.SqlDbType.Int)]
        public int StudentId { get; set; }
        
        [DbField("TheTestId", System.Data.SqlDbType.Int)]
        public int TheTestId { get; set; }

        // actually the answer sheet contain all information about Correct, Incorrect, NotDone
        // but to show this field for report may take alot of time
        // so this field maybe use in the future
        [DbField("AnswerSheet", System.Data.SqlDbType.NVarChar)]
        public string AnswerSheet { get; set; }

        [DbField("NotDone", System.Data.SqlDbType.Int)]
        public int NotDone { get; set; }

        [DbField("Correct", System.Data.SqlDbType.Int)]
        public int Correct { get; set; }

        [DbField("Incorrect", System.Data.SqlDbType.Int)]
        public int Incorrect { get; set; }

        [DbField("TimeSpent", System.Data.SqlDbType.Int)]
        public int TimeSpent { get; set; }

        [DbField("Submitted", System.Data.SqlDbType.Bit)]
        public bool Submitted { get; set; }
    }
}
