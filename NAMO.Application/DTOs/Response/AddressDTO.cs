using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NAMO.Application.DTOs.Response
{
    public class AddressDTO
    {
        public string? Kladr { get; }
        public string? Region { get; }
        public string? SubRegion { get; }
        public string? City { get; }
        public string? Street { get; }
        public string? House { get; }
        public string? Corpus { get; }
        public string? Flat { get; }

        public AddressDTO(string? kladr, string? region, string? subRegion, string? city, string? street, string? house, string? corpus, string? flat)
        {
            Kladr = kladr;
            Region = region;
            SubRegion = subRegion;
            City = city;
            Street = street;
            House = house;
            Corpus = corpus;
            Flat = flat;
        }
    }
}
