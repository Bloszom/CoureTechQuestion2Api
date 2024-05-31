using CoureTechQuestion2.Core.DTOs;
using CoureTechQuestion2.Core.IService;
using CoureTechQuestion2.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechQuestion2.Core.Service
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public CountryDto GetCountryDetailsByPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length < 3)
            {
                return null;
            }

            var countryCode = phoneNumber.Substring(0, 3);
            var country = _countryRepository.GetCountryByCode(countryCode);

            if (country == null)
            {
                return null;
            }

            return new CountryDto
            {
                CountryCode = country.CountryCode,
                Name = country.Name,
                CountryIso = country.CountryIso,
                CountryDetails = country.CountryDetails.Select(cd => new CountryDetailDto
                {
                    Operator = cd.Operator,
                    OperatorCode = cd.OperatorCode
                }).ToList()
            };
        }
    }
}
