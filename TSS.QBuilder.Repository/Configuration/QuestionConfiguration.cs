using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSS.QBuilder.Entities.Models;

namespace TSS.QBuilder.Repository.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(
                new Question
                {
                    Id = Guid.NewGuid(),
                    QuestionText = "Question 1",
                    QuestionSubText = "This is the first question",
                    ControlTypeId = new Guid("F5C9F52A-F7BD-4C65-A144-01CD4CAA3426"),
                    QuestionSetId = new Guid("2A14846F-46B3-4F00-8D3D-DD77A9BF6A08")
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    QuestionText = "Question 2",
                    QuestionSubText = "This is the second question",
                    ControlTypeId = new Guid("F74B3DF6-A04D-4351-8D5B-2D757688D7D0"),
                    QuestionSetId = new Guid("71A30165-923F-43D2-BCC4-CEB2E5D0AEAC")
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    QuestionText = "Question 3",
                    QuestionSubText = "This is the third question",
                    ControlTypeId = new Guid("32530F63-9047-4C4D-81C3-1E1A0ED78BCA"),
                    QuestionSetId = new Guid("C1123783-5004-4FE7-AF36-2A9FFD183641")
                }
            );
        }
    }
}
