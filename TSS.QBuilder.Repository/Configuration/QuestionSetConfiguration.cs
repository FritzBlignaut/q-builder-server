using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSS.QBuilder.Entities.Models;

namespace TSS.QBuilder.Repository.Configuration
{
    public class QuestionSetConfiguration : IEntityTypeConfiguration<QuestionSet>
    {
        public void Configure(EntityTypeBuilder<QuestionSet> builder)
        {
            builder.HasData(
                new QuestionSet
                {
                    Id = new Guid("2A14846F-46B3-4F00-8D3D-DD77A9BF6A08"),
                    Name = "Question Set 1",
                    Description = "This is the first question set"
                },
                new QuestionSet
                {
                    Id = new Guid("71A30165-923F-43D2-BCC4-CEB2E5D0AEAC"),
                    Name = "Question Set 2",
                    Description = "This is the second question set"
                },
                new QuestionSet
                {
                    Id = new Guid("C1123783-5004-4FE7-AF36-2A9FFD183641"),
                    Name = "Question Set 3",
                    Description = "This is the third question set"
                }
            );
        }
    }
}
