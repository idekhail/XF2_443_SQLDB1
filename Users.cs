using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace XF2_443_SQLDB1
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }        
    }
}
