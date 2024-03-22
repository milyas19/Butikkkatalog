using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DBContextConfig
{
    public class OpeningHoursConfig : IEntityTypeConfiguration<OpeningHours>
    {
        public void Configure(EntityTypeBuilder<OpeningHours> builder)
        {
            builder.ToTable(nameof(OpeningHours));
        }
    }
}
