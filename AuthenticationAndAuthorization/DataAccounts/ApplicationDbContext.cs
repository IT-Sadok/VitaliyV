﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DataAccounts
{
    public class ApplicationDbContext : IdentityDbContext<UserEntity, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            Database.Migrate();
        }

        public DbSet<UserEntity> Account => Set<UserEntity>();
    }
}
