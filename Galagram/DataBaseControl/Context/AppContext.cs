using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using System.Data.Entity;

namespace DataBaseControl.Context
{
    class AppContext : DbContext
    {
        public AppContext()
            :base("AppDbConnection")
        { }

        DbSet<Photo> Photos { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Like> Likes { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<User> Users { get; set; }
    }
}
