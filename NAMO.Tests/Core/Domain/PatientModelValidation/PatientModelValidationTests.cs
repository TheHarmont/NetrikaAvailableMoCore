using NAMO.Domain.Common;
using NAMO.Domain.Entities;
using NAMO.Tests.Core.Domain.PatientModelValidation.Data;
using Xunit;

namespace NAMO.Tests.Core.Domain.PatientModelValidation
{

    public class PatientModelValidationTests
    {
        [Theory]
        [ClassData(typeof(ValidPatientsData))]
        public void IsValid_ShouldReturnTrue_WhenValidData(PatientInfoRequest patient)
        {
            //Arrange

            //Act
            var result = patient.IsValid();

            //Assert
            Assert.True(result);
        }

        [Theory]
        [ClassData(typeof(InvalidPatientsData))]
        public void IsValid_ShouldReturnFalse_WhenInvalidData(PatientInfoRequest patient)
        {
            //Arrange

            //Act
            var result = patient.IsValid();

            //Assert
            Assert.False(result);
        }
    }
}
