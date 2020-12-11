using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFViewAndSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SPContext())
            {
                if (db.Database.CanConnect())
                {
                    var query = "select 'test' as 'username', 'fredrik' as 'fullname', 'secret' as 'password';";
                    var users = db.Users.FromSqlRaw(query).ToList();

                    var randoms = db.Randoms.FromSqlRaw("exec random 20;").ToList();

                    int fromStore = 1;
                    int toStore = 1;
                    string ISBN = "948543857435843";
                    db.Database.ExecuteSqlInterpolated($"exec MoveBooks {fromStore}, {toStore}, {ISBN}");
                }
            }
        }
    }
}
