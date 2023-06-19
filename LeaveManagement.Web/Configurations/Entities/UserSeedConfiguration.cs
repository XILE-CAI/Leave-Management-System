using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
                var hasher = new PasswordHasher<Employee>();
                builder.HasData(
                    new Employee
                    {
                        Id = "04a5aa24-6df5-43f2-969a-77487b583f3a",
                        Email = "admin@test.com",
                        NormalizedEmail = "ADMIN@TEST.COM",
                        NormalizedUserName = "ADMIN@TEST.COM",
                        UserName = "admin@test.com",
                        FirstName = "System",
                        LastName = "Admin",
                        PasswordHash = hasher.HashPassword(null,"Test@123.com"),
                        EmailConfirmed = true
                    },
                    new Employee
                    {
                        Id = "CDC8CC71-5228-45F8-B077-8015BCC612E0",
                        Email = "User@test.com",
                        NormalizedEmail = "USER@TEST.COM",
                        NormalizedUserName = "USER@TEST.COM",
                        UserName = "User@test.com",
                        FirstName = "System",
                        LastName = "User",
                        PasswordHash = hasher.HashPassword(null, "User@123.com"),
                        EmailConfirmed = true
                    }
                );
            }
    }
}