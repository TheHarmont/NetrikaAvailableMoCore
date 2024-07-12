using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NAMO.Application.DTOs.Response
{
    public class PatientDataDTO
    {
        public string FomsId;

        public string ENP;

        public string Surname;

        public string Sex;

        public string Name;

        public string? Patronymic;

        public DateTime? BirthDate;

        public string? Snils;

        public string? BirthPlace;

        public string? Citizenship;

        public string? DocumentType;

        public string? DocumentSeries;

        public string? DocumentNumber;

        public string? DocumentOrg;

        public DateTime? DocumentDate;

        public AddressDTO? RegAddress;

        public string? Phone;

        public PatientDataDTO(string fomsId, string enp, string surname, string sex, string name, string? patronymic, DateTime? birthDate, string? snils, string? birthPlace, string? citizenship, string? documentType, string? documentSeries, string? documentNumber, string? documentOrg, DateTime? documentDate, AddressDTO? regAddress, string? phone)
        {
            FomsId = fomsId;
            ENP = enp;
            Surname = surname;
            Sex = sex;
            Name = name;
            Patronymic = patronymic;
            BirthDate = birthDate;
            Snils = snils;
            BirthPlace = birthPlace;
            Citizenship = citizenship;
            DocumentType = documentType;
            DocumentSeries = documentSeries;
            DocumentNumber = documentNumber;
            DocumentOrg = documentOrg;
            DocumentDate = documentDate;
            RegAddress = regAddress;
            Phone = phone;
        }
    }
}
