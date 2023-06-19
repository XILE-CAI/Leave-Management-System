using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371",
                    UserId = "04a5aa24-6df5-43f2-969a-77487b583f3a"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "8538AE88-5776-412C-A021-AEB9A18A6C63",
                    UserId = "CDC8CC71-5228-45F8-B077-8015BCC612E0"
                }
            );
        }
    }
}