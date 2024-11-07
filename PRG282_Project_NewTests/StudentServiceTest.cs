using Xunit;
using PRG282_Project.Business_Logic_Layer;
namespace PRG282_Project_NewTests
{
    public class StudentSericeTest
    {
        [Theory]
        [InlineData("", "S001")]
        [InlineData(null, "S001")]
        public void GenerateNextStudentNumber_ShouldReturnS001_WhenLastStudentNumberIsEmptyOrNull(string lastStudentNumber, string expected)
        {
            // Arrange


            var studentService = new StudentService();

            // Act
            var result = studentService.GenerateNextStudentNumber(lastStudentNumber);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("S001", "S002")]
        [InlineData("S009", "S010")]
        [InlineData("S099", "S100")]
        [InlineData("S999", "S1000")]
        public void GenerateNextStudentNumber_ShouldIncrementNumberCorrectly(string lastStudentNumber, string expected)
        {
            // Arrange
            var studentService = new StudentService();

            // Act
            var result = studentService.GenerateNextStudentNumber(lastStudentNumber);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}