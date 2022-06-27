using L1;
using L1.Attributes;
using L1.Compressors;

namespace L2.Models
{
    [DbTable("StudentTbl")]
    public class Student : BaseRecord
    {
        [DbField("ClassId", System.Data.SqlDbType.Int)]
        public int ClassId { get; set; }

        [DbField("Alias", System.Data.SqlDbType.NVarChar)]
        public string Alias { get; set; }
        
        [DbField("Name", System.Data.SqlDbType.NVarChar)]
        public string Name { get; set; }

        [DbField("Email", System.Data.SqlDbType.NVarChar)]
        public string Email { get; set; }

        [DbField("PhoneNumber", System.Data.SqlDbType.NVarChar)]
        public string PhoneNumber { get; set; }        

        [DbField("AdditionInfo", System.Data.SqlDbType.NVarChar)]
        public string AdditionInfo { get; set; }
        // user
        [DbField("Username", System.Data.SqlDbType.NVarChar)]
        public string Username { get; set; }

        [DbField("Password", System.Data.SqlDbType.NVarChar)]
        public string Password { get; set; }
    }
}
