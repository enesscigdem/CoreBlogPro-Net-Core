using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("59F80761-77FC-464C-86B4-20CF115B5563"),
                RoleId = Guid.Parse("6E670956-2739-47D7-9C40-1A3C730AFE6B"),
            },
            new AppUserRole
            {
                UserId = Guid.Parse("54CE0E57-C841-4CA7-A057-6D35DCD39D21"),
                RoleId = Guid.Parse("FD807B4D-A9DE-421D-8398-0F3934CF09D9"),
            });
        }
    }
}

