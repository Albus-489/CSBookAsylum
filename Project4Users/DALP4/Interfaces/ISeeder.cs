using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DALP4.Interfaces
{
    public interface ISeeder<T> where T : class
    {
        void Seed(EntityTypeBuilder<T> builder);
    }
}
