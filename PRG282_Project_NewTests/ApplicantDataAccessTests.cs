using System;
using System.IO;
using System.Linq;
using Xunit;
using PRG282_Project.Data_Layer;

namespace PRG282_Project_NewTests
{
    public class ApplicantDataAccessTests
    {
        private readonly string testFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Applicant.txt");

        public ApplicantDataAccessTests()
        {
            
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }


        [Fact]
        public void GetNextApplicantId_WhenFileContainsApplicants_ShouldReturnNextId()
        {
            // Arrange
            var dataAccess = new ApplicantDataAccess();
            File.WriteAllLines(testFilePath, new[]
            {
            "1,0123456789123 ,Jason,Taylor,BCOMP,taylor@gmail.com,C:\\Users\\taylo\\Pictures\\Screenshots\\Screenshot (2).png\r\n"

        });

            // Act
            int nextId = dataAccess.GetNextApplicantId();

            // Assert
            Assert.Equal(2, nextId);
        }

        
    }
}
