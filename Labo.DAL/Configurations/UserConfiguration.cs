using Labo.DL.Entities;
using Labo.Utils.Password;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo.DAL.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Username)
                .HasMaxLength(100)
                .HasDefaultValue("Khun");

            builder.Property(u => u.Gender)
                .HasConversion<string>();

            builder.Property(u => u.Role)
                .HasConversion<string>();

            builder.HasIndex(u => u.Username).IsUnique();
            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasIndex(u => u.Salt).IsUnique();

            builder.HasData(CreateAdmin());
        }

        private IEnumerable<User> CreateAdmin()
        {
            Guid salt = Guid.NewGuid();
            yield return new User
            {
                Id = new Guid("a6a71a1f-699e-4a01-a3b3-89354a01ef4f"),
                Username = "Checkmate",
                Email = "lykhun@gmail.com",
                Gender = DL.Enums.UserGender.Male,
                Role = DL.Enums.UserRole.Admin,
                BirthDate = new DateTime(1982, 5, 6),
                Elo = 1800,
                IsDeleted = false,
                Salt = salt,
                EncodedPassword = PasswordUtils.HashPassword("1234", salt)
            };

            #if DEBUG
            salt = Guid.NewGuid();
            yield return new User
            {
                Id = new Guid("2649548b-ba8d-4f9b-b1ab-c58bc64a063b"),
                Username = "John",
                Email = "j@yopmail.com",
                Gender = DL.Enums.UserGender.Male,
                Role = DL.Enums.UserRole.Player,
                BirthDate = new DateTime(2000, 5, 6),
                Elo = 1500,
                IsDeleted = false,
                Salt = salt,
                EncodedPassword = PasswordUtils.HashPassword("1234", salt)
            };

            salt = Guid.NewGuid();
            yield return new User
            {
                Id = new Guid("34303638-fe61-4d76-83d3-d4ca8576542a"),
                Username = "Sarah",
                Email = "s@yopmail.com",
                Gender = DL.Enums.UserGender.Female,
                Role = DL.Enums.UserRole.Player,
                BirthDate = new DateTime(2000, 5, 6),
                Elo = 1800,
                IsDeleted = false,
                Salt = salt,
                EncodedPassword = PasswordUtils.HashPassword("1234", salt)
            };

            salt = Guid.NewGuid();
            yield return new User
            {
                Id = Guid.NewGuid(),
                Username = "Brithney",
                Email = "b@yopmail.com",
                Gender = DL.Enums.UserGender.Female,
                Role = DL.Enums.UserRole.Player,
                BirthDate = new DateTime(2005, 5, 6),
                Elo = 1200,
                IsDeleted = false,
                Salt = salt,
                EncodedPassword = PasswordUtils.HashPassword("1234", salt)
            };
            salt = Guid.NewGuid();

            yield return new User
            {
                Id = Guid.NewGuid(),
                Username = "Ringo",
                Email = "r@yopmail.com",
                Gender = DL.Enums.UserGender.Male,
                Role = DL.Enums.UserRole.Player,
                BirthDate = new DateTime(2000, 5, 6),
                Elo = 1800,
                IsDeleted = false,
                Salt = salt,
                EncodedPassword = PasswordUtils.HashPassword("1234", salt)
            };
            salt = Guid.NewGuid();
            yield return new User
            {
                Id = Guid.NewGuid(),
                Username = "Paul",
                Email = "p@yopmail.com",
                Gender = DL.Enums.UserGender.Male,
                Role = DL.Enums.UserRole.Player,
                BirthDate = new DateTime(2000, 5, 6),
                Elo = 1800,
                IsDeleted = false,
                Salt = salt,
                EncodedPassword = PasswordUtils.HashPassword("1234", salt)
            };
            salt = Guid.NewGuid();
            yield return new User
            {
                Id = Guid.NewGuid(),
                Username = "Georges",
                Email = "g@yopmail.com",
                Gender = DL.Enums.UserGender.Male,
                Role = DL.Enums.UserRole.Player,
                BirthDate = new DateTime(2000, 5, 6),
                Elo = 1800,
                IsDeleted = false,
                Salt = salt,
                EncodedPassword = PasswordUtils.HashPassword("1234", salt)
            };
            #endif
        }
    }
}
