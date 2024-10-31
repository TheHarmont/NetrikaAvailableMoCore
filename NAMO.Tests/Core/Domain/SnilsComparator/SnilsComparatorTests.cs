using NAMO.Application.Common;
using NAMO.Domain.Entities;
using NAMO.Tests.Core.Domain.PatientModelValidation.Data;
using NAMO.Tests.Core.Domain.SnilsComparator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NAMO.Tests.Core.Domain.SnilsComparator
{
    public  class SnilsComparatorTests
    {
        [Theory]
        [ClassData(typeof(SnilsValidData))]
        public void SnilsEquals_ShouldReturnTrue_WhenValidData(SnilsData snilsData)
        {
            //Arrange

            //Act
            var result = snilsData.SNILS1.SnilsEquals(snilsData.SNILS2);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [ClassData(typeof(SnilsInvalidData))]
        public void SnilsEquals_ShouldReturnFalse_WhenInvalidData(SnilsData snilsData)
        {
            //Arrange

            //Act
            var result = snilsData.SNILS1.SnilsEquals(snilsData.SNILS2);

            //Assert
            Assert.False(result);
        }
    }
}
