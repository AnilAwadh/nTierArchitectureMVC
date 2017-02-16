using CP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");
            HasKey(x => x.UserId);
            Property(x => x.Email)
                .HasMaxLength(100)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_USUARIO_EMAIL")
                {
                    IsUnique = true
                }))
                .IsRequired();
            Ignore(x => x.Password);
            Property(x => x.UserType).IsRequired();

            Property(x => x.EncryptedPassword)
                .HasColumnName("Senha")
                .IsRequired()
                .HasMaxLength(32)
                .IsFixedLength();


        }
    }
}
