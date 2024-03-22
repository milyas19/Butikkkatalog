using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.DBContextConfig
{
    public class ChainInfoConfig : IEntityTypeConfiguration<ChainInfo>
    {
        public void Configure(EntityTypeBuilder<ChainInfo> builder)
        {
            builder.ToTable(nameof(ChainInfo));
        }
    }
}
