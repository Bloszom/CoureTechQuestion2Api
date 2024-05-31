using CoureTechQuestion2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechQuestion2.Data.IRepository
{
    public interface ICountryRepository
    {
        Country GetCountryByCode(string countryCode);
    }
}
