using Database.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace ShopDemo.DAO
{
    public static class ServiceLogin
    {           

        public static bool Login(string userName, string password)
        {
            ShopDbContext db = new ShopDbContext();
            var result = db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
            if (result != null)
            {               
                return true;
            }
            return false;          
        }
    }
}
