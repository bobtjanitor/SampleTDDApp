using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentData;

namespace SampleApplication.Data
{
    public abstract class RepoBase
    {
        private IDbContext _context;

        public IDbContext Context
        {
            get
            {
                return _context ?? (_context = new DbContext().ConnectionStringName("SampleApplication", new SqlServerProvider()));
            }
            set { _context = value; }
        }
    }
}
