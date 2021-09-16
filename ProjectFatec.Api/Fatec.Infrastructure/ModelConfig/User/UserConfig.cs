using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserEntity = Fatec.Domain.Entities.User.User;

namespace Fatec.Infrastructure.ModelConfig.User
{
    public class UserConfig : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
