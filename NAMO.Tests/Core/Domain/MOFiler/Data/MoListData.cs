using NAMO.Domain.Entities;
using NAMO.Domain.Entities.dbEntities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Tests.Core.Domain.MOFiler.Data
{
    public class MoListData
    {
        public List<MO> GetNoFilteredMoList()
        {
            return new List<MO>{
                new MO
                {
                    Id = 1,
                    LpuId = 123,
                    LpuFullName = "Hospital A",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-001",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-001"
                },
                new MO
                {
                    Id = 2,
                    LpuId = 456,
                    LpuFullName = "Clinic B",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-002",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-002"
                },
                new MO
                {
                    Id = 3,
                    LpuId = 789,
                    LpuFullName = "Health Center C",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-003",
                    OnlyAttachment = false,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-003"
                },
                new MO
                {
                    Id = 4,
                    LpuId = 101112,
                    LpuFullName = "Polyclinic D",
                    DisplayAny = true,
                    DistrictCode = "JKL",
                    CodeMO = "MO-004",
                    OnlyAttachment = true,
                    OnlyFemale = false,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-004"
                },
                new MO
                {
                    Id = 5,
                    LpuId = 131415,
                    LpuFullName = "Hospital E",
                    DisplayAny = false,
                    DistrictCode = "MNO",
                    CodeMO = "MO-005",
                    OnlyAttachment = false,
                    OnlyFemale = true,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-005"
                },
                new MO
                {
                    Id = 6,
                    LpuId = 161718,
                    LpuFullName = "Medical Center F",
                    DisplayAny = true,
                    DistrictCode = "PQR",
                    CodeMO = "MO-006",
                    OnlyAttachment = true,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-006"
                },
                new MO
                {
                    Id = 7,
                    LpuId = 192021,
                    LpuFullName = "Hospital G",
                    DisplayAny = false,
                    DistrictCode = "STU",
                    CodeMO = "MO-007",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-007"
                },
                new MO
                {
                    Id = 8,
                    LpuId = 222324,
                    LpuFullName = "Clinic H",
                    DisplayAny = true,
                    DistrictCode = "VWX",
                    CodeMO = "MO-008",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-008"
                },
                new MO
                {
                    Id = 9,
                    LpuId = 252627,
                    LpuFullName = "Health Center I",
                    DisplayAny = false,
                    DistrictCode = "YZA",
                    CodeMO = "MO-009",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-009"
                },
                new MO
                {
                    Id = 10,
                    LpuId = 282930,
                    LpuFullName = "Polyclinic J",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-010",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-010"
                },
                new MO
                {
                    Id = 11,
                    LpuId = 313233,
                    LpuFullName = "Hospital K",
                    DisplayAny = false,
                    DistrictCode = "EFG",
                    CodeMO = "MO-011",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-011"
                },
                new MO
                {
                    Id = 12,
                    LpuId = 343536,
                    LpuFullName = "Medical Center L",
                    DisplayAny = true,
                    DistrictCode = "HIJ",
                    CodeMO = "MO-012",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-012"
                },
                new MO
                {
                    Id = 13,
                    LpuId = 373839,
                    LpuFullName = "Clinic M",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-013",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-013"
                },
                new MO
                {
                    Id = 14,
                    LpuId = 404142,
                    LpuFullName = "Health Center N",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-014",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-014"
                },
                new MO
                {
                    Id = 15,
                    LpuId = 434445,
                    LpuFullName = "Polyclinic O",
                    DisplayAny = false,
                    DistrictCode = "PQR",
                    CodeMO = "MO-015",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-015"
                },
                new MO
                {
                    Id = 16,
                    LpuId = 464748,
                    LpuFullName = "Hospital P",
                    DisplayAny = true,
                    DistrictCode = "STU",
                    CodeMO = "MO-016",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-016"
                },
                new MO
                {
                    Id = 17,
                    LpuId = 495051,
                    LpuFullName = "Health Center Q",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-017",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-017"
                },
                new MO
                {
                    Id = 18,
                    LpuId = 525354,
                    LpuFullName = "Clinic R",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-018",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-018"
                },
                new MO
                {
                    Id = 19,
                    LpuId = 555657,
                    LpuFullName = "Medical Center S",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-019",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-019"
                },
                new MO
                {
                    Id = 20,
                    LpuId = 585960,
                    LpuFullName = "Hospital T",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-020",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-020"
                }
            };
        }

        public List<MO> GetFilteredMoList_ByAge18OrMore()
        {
            return new List<MO>{
                new MO
                {
                    Id = 2,
                    LpuId = 456,
                    LpuFullName = "Clinic B",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-002",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-002"
                },
                new MO
                {
                    Id = 5,
                    LpuId = 131415,
                    LpuFullName = "Hospital E",
                    DisplayAny = false,
                    DistrictCode = "MNO",
                    CodeMO = "MO-005",
                    OnlyAttachment = false,
                    OnlyFemale = true,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-005"
                },
                new MO
                {
                    Id = 6,
                    LpuId = 161718,
                    LpuFullName = "Medical Center F",
                    DisplayAny = true,
                    DistrictCode = "PQR",
                    CodeMO = "MO-006",
                    OnlyAttachment = true,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-006"
                },
                new MO
                {
                    Id = 8,
                    LpuId = 222324,
                    LpuFullName = "Clinic H",
                    DisplayAny = true,
                    DistrictCode = "VWX",
                    CodeMO = "MO-008",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-008"
                },
                new MO
                {
                    Id = 10,
                    LpuId = 282930,
                    LpuFullName = "Polyclinic J",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-010",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-010"
                },
                new MO
                {
                    Id = 12,
                    LpuId = 343536,
                    LpuFullName = "Medical Center L",
                    DisplayAny = true,
                    DistrictCode = "HIJ",
                    CodeMO = "MO-012",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-012"
                },
                new MO
                {
                    Id = 14,
                    LpuId = 404142,
                    LpuFullName = "Health Center N",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-014",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-014"
                },
                new MO
                {
                    Id = 16,
                    LpuId = 464748,
                    LpuFullName = "Hospital P",
                    DisplayAny = true,
                    DistrictCode = "STU",
                    CodeMO = "MO-016",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-016"
                },
                new MO
                {
                    Id = 18,
                    LpuId = 525354,
                    LpuFullName = "Clinic R",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-018",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-018"
                },
                new MO
                {
                    Id = 20,
                    LpuId = 585960,
                    LpuFullName = "Hospital T",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-020",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-020"
                }
            };
        }

        public List<MO> GetFilteredMoList_ByMale()
        {
            return new List<MO>{
                new MO
                {
                    Id = 1,
                    LpuId = 123,
                    LpuFullName = "Hospital A",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-001",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-001"
                },
                new MO
                {
                    Id = 4,
                    LpuId = 101112,
                    LpuFullName = "Polyclinic D",
                    DisplayAny = true,
                    DistrictCode = "JKL",
                    CodeMO = "MO-004",
                    OnlyAttachment = true,
                    OnlyFemale = false,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-004"
                },
                new MO
                {
                    Id = 6,
                    LpuId = 161718,
                    LpuFullName = "Medical Center F",
                    DisplayAny = true,
                    DistrictCode = "PQR",
                    CodeMO = "MO-006",
                    OnlyAttachment = true,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-006"
                },
                new MO
                {
                    Id = 8,
                    LpuId = 222324,
                    LpuFullName = "Clinic H",
                    DisplayAny = true,
                    DistrictCode = "VWX",
                    CodeMO = "MO-008",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-008"
                },
                new MO
                {
                    Id = 10,
                    LpuId = 282930,
                    LpuFullName = "Polyclinic J",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-010",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-010"
                },
                new MO
                {
                    Id = 12,
                    LpuId = 343536,
                    LpuFullName = "Medical Center L",
                    DisplayAny = true,
                    DistrictCode = "HIJ",
                    CodeMO = "MO-012",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-012"
                },
                new MO
                {
                    Id = 14,
                    LpuId = 404142,
                    LpuFullName = "Health Center N",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-014",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-014"
                },
                new MO
                {
                    Id = 16,
                    LpuId = 464748,
                    LpuFullName = "Hospital P",
                    DisplayAny = true,
                    DistrictCode = "STU",
                    CodeMO = "MO-016",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-016"
                },
                new MO
                {
                    Id = 18,
                    LpuId = 525354,
                    LpuFullName = "Clinic R",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-018",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-018"
                },
                new MO
                {
                    Id = 20,
                    LpuId = 585960,
                    LpuFullName = "Hospital T",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-020",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-020"
                }
            };
        }

        public List<MO> GetFilteredMoList_ByDistrictCodeEqualABC()
        {
            return new List<MO>{
                new MO
                {
                    Id = 1,
                    LpuId = 123,
                    LpuFullName = "Hospital A",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-001",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-001"
                },
                new MO
                {
                    Id = 2,
                    LpuId = 456,
                    LpuFullName = "Clinic B",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-002",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-002"
                },
                new MO
                {
                    Id = 3,
                    LpuId = 789,
                    LpuFullName = "Health Center C",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-003",
                    OnlyAttachment = false,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-003"
                },
                new MO
                {
                    Id = 10,
                    LpuId = 282930,
                    LpuFullName = "Polyclinic J",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-010",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-010"
                },
                new MO
                {
                    Id = 13,
                    LpuId = 373839,
                    LpuFullName = "Clinic M",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-013",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-013"
                },
                new MO
                {
                    Id = 14,
                    LpuId = 404142,
                    LpuFullName = "Health Center N",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-014",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-014"
                },
                new MO
                {
                    Id = 17,
                    LpuId = 495051,
                    LpuFullName = "Health Center Q",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-017",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-017"
                },
                new MO
                {
                    Id = 18,
                    LpuId = 525354,
                    LpuFullName = "Clinic R",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-018",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-018"
                },
                new MO
                {
                    Id = 19,
                    LpuId = 555657,
                    LpuFullName = "Medical Center S",
                    DisplayAny = false,
                    DistrictCode = "ABC",
                    CodeMO = "MO-019",
                    OnlyAttachment = true,
                    OnlyFemale = true,
                    OnlyChild = true,
                    IsActive = true,
                    OrdId = "ORD-019"
                },
                new MO
                {
                    Id = 20,
                    LpuId = 585960,
                    LpuFullName = "Hospital T",
                    DisplayAny = true,
                    DistrictCode = "ABC",
                    CodeMO = "MO-020",
                    OnlyAttachment = false,
                    OnlyFemale = false,
                    OnlyChild = false,
                    IsActive = true,
                    OrdId = "ORD-020"
                }
            };
        }
    }
}

