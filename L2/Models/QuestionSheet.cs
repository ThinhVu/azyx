using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using L1;
using L1.Attributes;
namespace L2.Models
{
    // To maintain the answer result of student
    // Used question sheet cannot be delete or modify question list
    [DbTable("QuestionSheetTbl")]
    public class QuestionSheet : BaseRecord
    {        
        [DbField("SubjectId", System.Data.SqlDbType.Int)]
        public int SubjectId { get; set; }

        [DbField("Alias", System.Data.SqlDbType.NVarChar)]
        public string Alias { get; set; }

        [DbField("TestTime", System.Data.SqlDbType.Int)]
        public int TestTime { get; set; }

        [DbField("AdditionInfo", System.Data.SqlDbType.NVarChar)]
        public string AdditionInfo { get; set; }

        [DbField("Used", System.Data.SqlDbType.Bit)]
        public bool Used { get; set; } 
    }
}
