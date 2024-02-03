using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_PartsReview_Website.Shared.Domain;

namespace PC_PartsReview_Website.Server.Configurations.Entities
{
    public class RatingSeedConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(
                new Rating
                {
                    Id = 1,
                    Quality = "5/5",
                    PersonalRating = "Excellent",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },

                new Rating
                {
                    Id = 2,
                    Quality = "4/5",
                    PersonalRating = "Very Good",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }

                );

        }
    }
}
