namespace HomeWork4.DataAccess
{
    using HomeWork4.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PostsContext : DbContext
    {
        public PostsContext() : base("name=PostsContext")
        {
            Database.SetInitializer(new PostsInitializer());
        }
        public DbSet<Post> Posts { get; set; }
    }
}