using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Server.Data;

public sealed class CustomerDbContext : DbContext
{
  public DbSet<Post> Posts => Set<Post>();
  public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)  {}
  protected override void OnModelCreating(ModelBuilder builder)
  {
    var postsToSeed = new Post[6];
    for (int i = 1; i <= 6; i++)
    {
      postsToSeed[i - 1] = new Post()
      {
        PostId = i,
        Title = $"Post {i}",
        Content = $"This is a post {i} and it has some very interesting content.",
      };
    }
    builder.Entity<Post>().HasData(postsToSeed);
  }
}