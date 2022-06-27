using L1;
using L1.Attributes;
using L1.Compressors;

namespace L2.Models
{
    // Câu hỏi
    [DbTable("QuestionTbl")]
    public class Question : BaseRecord
    {
        [DbField("QuestionSheetId", System.Data.SqlDbType.Int)]
        public int QuestionSheetId { get; set; }

        [Compressor(typeof(GzipBase64Compressor))]
        [DbField("Content", System.Data.SqlDbType.NVarChar)]
        public string Content { get; set; }

        [Compressor(typeof(GzipBase64Compressor))]
        [DbField("A", System.Data.SqlDbType.NVarChar)]
        public string A { get; set; }

        [Compressor(typeof(GzipBase64Compressor))]
        [DbField("B", System.Data.SqlDbType.NVarChar)]
        public string B { get; set; }

        [Compressor(typeof(GzipBase64Compressor))]
        [DbField("C", System.Data.SqlDbType.NVarChar)]
        public string C { get; set; }

        [Compressor(typeof(GzipBase64Compressor))]
        [DbField("D", System.Data.SqlDbType.NVarChar)]
        public string D { get; set; }

        [Compressor(typeof(GzipBase64Compressor))]
        [DbField("Guide", System.Data.SqlDbType.NVarChar)]
        public string Guide { get; set; }

        [DbField("ShuffleAnswer", System.Data.SqlDbType.Bit)]
        public bool ShuffleAnswer { get; set; }

        [DbField("CorrectAnswer", System.Data.SqlDbType.Int)]
        public int CorrectAnswer { get; set; }
    }
}
