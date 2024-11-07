using Xunit;
using System.Security.Cryptography;
using System.Text;
using PRG282_Project.Business_Logic_Layer;

namespace PRG282_Project_NewTests
{
    public class PasswordHasherTests
    {
        private readonly PasswordHasher _passwordHasher;

        public PasswordHasherTests()
        {
            _passwordHasher = new PasswordHasher();
        }

        [Fact]
        public void HashPassword_ShouldProduceDifferentHashes_ForDifferentInputs()
        {
            // Arrange
            string password1 = "password123";
            string password2 = "password456";

            // Act
            string hash1 = _passwordHasher.HashPassword(password1);
            string hash2 = _passwordHasher.HashPassword(password2);

            // Assert
            Assert.NotEqual(hash1, hash2);
        }

        [Fact]
        public void HashPassword_ShouldProduceSameHash_ForSameInput()
        {
            // Arrange
            string password = "samepassword";

            // Act
            string hash1 = _passwordHasher.HashPassword(password);
            string hash2 = _passwordHasher.HashPassword(password);

            // Assert
            Assert.Equal(hash1, hash2);
        }
    }
}
