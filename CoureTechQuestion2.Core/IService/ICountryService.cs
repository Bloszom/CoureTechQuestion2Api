using CoureTechQuestion2.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechQuestion2.Core.IService
{
    public interface ICountryService
    {
        CountryDto GetCountryDetailsByPhoneNumber(string phoneNumber);
    }
}
