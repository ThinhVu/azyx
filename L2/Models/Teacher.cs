using L1.Attributes;
namespace L2.Models
{
    [DbTable("TeacherTbl")]
    public class Teacher : L1.BaseRecord
    {
        [DbField("Username", System.Data.SqlDbType.NVarChar)]
        public string Username { get; set; }
        [DbField("Password", System.Data.SqlDbType.NVarChar)]
        public string Password { get; set; }
    }
}
