using L1;
using L1.Attributes;

namespace L2.Models
{
    [DbTable("ClassTbl")]
    public class Class : BaseRecord
    {
        [DbField("Alias", System.Data.SqlDbType.NVarChar)]
        public string Alias { get; set; }

        [DbField("Name", System.Data.SqlDbType.NVarChar)]
        public string Name { get; set; }

        [DbField("AdditionInfo", System.Data.SqlDbType.NVarChar)]
        public string AdditionInfo { get; set; }
    }
}
