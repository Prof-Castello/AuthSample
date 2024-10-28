using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;

namespace AuthSample.Models
{
    public static class ModelBuilderExtended
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var adminRole = Guid.NewGuid().ToString();
            var tiRole = Guid.NewGuid().ToString();
            var rhRole = Guid.NewGuid().ToString();
            var financeiroRole = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole { Id = adminRole, Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Id = tiRole, Name = "TI", NormalizedName = "TI" },
                    new IdentityRole { Id = rhRole, Name = "RH", NormalizedName = "RH" },
                    new IdentityRole { Id = financeiroRole, Name = "Financeiro", NormalizedName = "FINANCEIRO" }
                    );


            var adminId = Guid.NewGuid().ToString();
            var tiId = Guid.NewGuid().ToString();
            var rhId = Guid.NewGuid().ToString();
            var financeiroId = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = adminId,
                    UserName = "admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "Senha@123"),
                    EmailConfirmed = true
                },
                  new IdentityUser
                  {
                      Id = tiId,
                      UserName = "ti@example.com",
                      NormalizedUserName = "TI@EXAMPLE.COM",
                      Email = "ti@example.com",
                      NormalizedEmail = "TI@EXAMPLE.COM",
                      PasswordHash = hasher.HashPassword(null, "Senha@123"),
                      EmailConfirmed = true
                  }, new IdentityUser
                  {
                      Id = rhId,
                      UserName = "rh@example.com",
                      NormalizedUserName = "RH@EXAMPLE.COM",
                      Email = "rh@example.com",
                      NormalizedEmail = "RH@EXAMPLE.COM",
                      PasswordHash = hasher.HashPassword(null, "Senha@123"),
                      EmailConfirmed = true
                  }, new IdentityUser
                  {
                      Id = financeiroId,
                      UserName = "financeiro@example.com",
                      NormalizedUserName = "FINANCEIRO@EXAMPLE.COM",
                      Email = "financeiro@example.com",
                      NormalizedEmail = "FINANCEIRO@EXAMPLE.COM",
                      PasswordHash = hasher.HashPassword(null, "Senha@123"),
                      EmailConfirmed = true
                  }
                );


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = adminRole, UserId = adminId },
                new IdentityUserRole<string> { RoleId = tiRole, UserId = tiId },
                new IdentityUserRole<string> { RoleId = rhRole, UserId = rhId },
                new IdentityUserRole<string> { RoleId = financeiroRole, UserId = financeiroId }
                );
        }
    }
}
