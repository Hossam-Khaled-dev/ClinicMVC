using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;

namespace Clinic.DAL
{
    public class DatabaseRepo:IDatabaseRepo
    {
        private readonly ClinicContext _context;
        public DatabaseRepo(ClinicContext context) 
        {
            _context = context;
        }
        public IDbContextTransaction Transaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
