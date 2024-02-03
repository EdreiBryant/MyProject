using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_PartsReview_Website.Shared.Domain;

namespace PC_PartsReview_Website.Server.Configurations.Entities
{
    public class PcPartSeedConfiguration : IEntityTypeConfiguration<PcPart>
    {
        public void Configure(EntityTypeBuilder<PcPart> builder)
        {
            builder.HasData
            (
                new PcPart
                {
                    Id = 1,
                    Name = "RTX 3080",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },

                new PcPart
                {
                    Id = 2,
                    Name = "RTX 3070",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
        }
    }
}
