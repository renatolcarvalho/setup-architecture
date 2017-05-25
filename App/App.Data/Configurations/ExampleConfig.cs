using System.Data.Entity.ModelConfiguration;

namespace App.Data.Configurations
{
    public class ExampleConfig : EntityTypeConfiguration<Business.Model.Example>
    {
        public ExampleConfig()
        {
            HasKey(p => p.ExampleId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(200);

            ToTable("Examples");
        }
    }
}
