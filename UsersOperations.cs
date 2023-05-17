using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using SQLite;
namespace XF2_443_SQLDB1
{
    public class UsersOperations
    {
        readonly SQLiteAsyncConnection db;

        public UsersOperations(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Users>().Wait();
        }
       
        
        // Get a specific user by Username.
        public Task<Users> LoginAsync(string username, string password)
        {
            return db.Table<Users>().Where(i => i.Username == username && i.Password == password).FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(Users user)
        {
            if (user.Id != 0)
            {
                // Update an existing User.
                return db.UpdateAsync(user);
            }
            else
            {
                // Save a new User.
                return db.InsertAsync(user);
            }
        }
       





    }
}
