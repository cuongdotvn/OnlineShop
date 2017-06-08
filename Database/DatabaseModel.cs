using Database.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Database
{
    public class DatabaseModel
    {
        private OnlineShopDatabaseModel context = null;
        public DatabaseModel()
        {
            context = new OnlineShopDatabaseModel();
        }
        public bool Login(string userName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", userName),

            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @UserName,@Password", sqlParams).SingleOrDefault();
            return res;
        } 
    }
    
}
