using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSS.QBuilder.Entities.Models;

namespace TSS.QBuilder.Repository.Configuration
{
    public class ControlTypeConfiguration : IEntityTypeConfiguration<ControlType>
    {
        public void Configure(EntityTypeBuilder<ControlType> builder)
        {
            builder.HasData(
                new ControlType
                {
                    Id = new Guid("F5C9F52A-F7BD-4C65-A144-01CD4CAA3426"),
                    ControlName = "Control Type 1"
                },
                new ControlType
                {
                    Id = new Guid("F74B3DF6-A04D-4351-8D5B-2D757688D7D0"),
                    ControlName = "Control Type 2"
                },
                new ControlType
                {
                    Id = new Guid("32530F63-9047-4C4D-81C3-1E1A0ED78BCA"),
                    ControlName = "Control Type 3"
                }
             );
        }
    }
}