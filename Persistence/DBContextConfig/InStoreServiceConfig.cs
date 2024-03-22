using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace Persistence.DBContextConfig
{
    public class InStoreServiceConfig : IEntityTypeConfiguration<InStoreServices>
    {
        public void Configure(EntityTypeBuilder<InStoreServices> builder)
        {
            builder.ToTable(nameof(InStoreServices));
        }
    }
}
