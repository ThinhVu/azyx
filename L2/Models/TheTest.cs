using L1;
using L1.Attributes;
using System;

namespace L2.Models
{
    [L1.Attributes.DbTable("TheTestTbl")]
    public class TheTest : BaseRecord
    {
        [DbField("SubjectId", System.Data.SqlDbType.Int)]
        public int SubjectId { get; set; }

        [DbField("QuestionSheetId", System.Data.SqlDbType.Int)]
        public int QuestionSheetId { get; set; }

        [DbField("Alias", System.Data.SqlDbType.NVarChar)]
        public string Alias { get; set; }

        [DbField("Name", System.Data.SqlDbType.NVarChar)]
        public string Name { get; set; }

        [DbField("CreatedDate", System.Data.SqlDbType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [DbField("AdditionInfo", System.Data.SqlDbType.NVarChar)]
        public string AdditionInfo { get; set; }

        /// <summary>
        /// 0: Started-Occuring
        /// 1: Finished
        /// ... for furture use
        /// </summary>
        [DbField("Status", System.Data.SqlDbType.Int)]
        public int Status { get; set; }
    }
}
