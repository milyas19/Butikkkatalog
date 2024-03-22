using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DBContextConfig
{
    public class OpeningHoursSpecialConfig : IEntityTypeConfiguration<OpeningHoursSpecial>
    {
        public void Configure(EntityTypeBuilder<OpeningHoursSpecial> builder)
        {
            builder.ToTable(nameof(OpeningHoursSpecial));
        }
    }
}
