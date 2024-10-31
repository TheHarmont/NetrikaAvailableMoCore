using NAMO.Application.Common;
using NAMO.Domain.Entities.dbEntities;
using NAMO.Tests.Core.Domain.MOFiler.Data;
using Xunit;

namespace NAMO.Tests.Core.Domain.MOFiler
{
    public class MOFilterTests
    {
        [Theory]
        [ClassData(typeof(BirthData))]
        public void FilterByAge_ShouldReturnFilteredList_WhenAgeIs18OrMoreAndByDifferentFormat(string birthdate)
        {
            //Arrange
            var data = new MoListData();
            var noFilteredMOList = data.GetNoFilteredMoList();
            var filteredMOList = data.GetFilteredMoList_ByAge18OrMore();

            //Act
            var result = MOFilter.FilterByAge(noFilteredMOList, birthdate);

            //Assert
            Assert.True(filteredMOList.SequenceEqual(result, new MoListComparer()));
        }

        [Theory]
        [ClassData(typeof(SexData))]
        public void FilterBySex_ShouldReturnFilteredList_WhenMale(string sex)
        {
            //Arrange
            var data = new MoListData();
            var noFilteredMOList = data.GetNoFilteredMoList();
            var filteredMOList = data.GetFilteredMoList_ByMale();

            //Act
            var result = MOFilter.FilterBySex(noFilteredMOList, sex);

            //Assert
            Assert.True(filteredMOList.SequenceEqual(result, new MoListComparer()));
        }

        [Fact]
        public void FilterByDistrict_ShouldReturnFilteredList_WhenDistrictCodeEqualABC()
        {
            //Arrange
            var districtCode = "ABC";
            var data = new MoListData();
            var noFilteredMOList = data.GetNoFilteredMoList();
            var filteredMOList = data.GetFilteredMoList_ByDistrictCodeEqualABC();

            //Act
            var result = MOFilter.FilterByDistrict(noFilteredMOList, districtCode);

            //Assert
            Assert.True(filteredMOList.SequenceEqual(result, new MoListComparer()));
        }
    }
}
