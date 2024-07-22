using DbRelationshipMgmt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DbRelationshipMgmt.Data
{
    public class MyAppDbContext:IdentityDbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tutorial> Tutorials { get; set; }

        public DbSet<Article> Articles { get; set; }


        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SubjectTopic> SubjectTopics { get; set; }
    }

  
}
