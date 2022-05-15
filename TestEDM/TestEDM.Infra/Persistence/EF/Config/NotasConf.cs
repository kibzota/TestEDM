using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestEDM.Domain.Entities;


namespace TestEDM.Infra.Persistence.EF.Config
{
    class NotasConf : IEntityTypeConfiguration<Notas>
    {
        public void Configure(EntityTypeBuilder<Notas> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataAlteracao).HasDefaultValueSql("getdate()");

            builder.Property(x => x.NotasDeDez);
            builder.Property(x => x.NotasDeVinte);
            builder.Property(x => x.NotasDeCinquenta);
            builder.Property(x => x.NotasDeCem);
        }
    }
}
