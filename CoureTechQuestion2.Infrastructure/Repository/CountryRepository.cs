using CoureTechQuestion2.Data.Entities;
using CoureTechQuestion2.Data.IRepository;
using CoureTechQuestion2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechQuestion2.Infrastructure.Repository
{
    public class CountryRepository : ICountryRepository
    {

        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Country GetCountryByCode(string countryCode)
        {
            return _context.Countries
                .Include(c => c.CountryDetails)
                .FirstOrDefault(c => c.CountryCode == countryCode);
        }
    }

}

