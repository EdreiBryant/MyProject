using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_PartsReview_Website.Shared.Domain;

namespace PC_PartsReview_Website.Server.Configurations.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData
            (
                new Review
                {
                    Id = 1,
                    ReviewTitle = "RTX 3080 Review",
                    ReviewDescription = "This GPU Rocks...",

                    RatingId = 1,
                    PcPartId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },

                new Review
                {
                    Id = 2,
                    ReviewTitle = "RTX 3070 Review",
                    ReviewDescription = "This GPU performs...",

                    RatingId = 2,
                    PcPartId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
        }
    }
}
