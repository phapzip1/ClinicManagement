using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ClinicManagement.DbContexts
{
    public class ClinicDbContextFactory
    {
        private readonly string _connectionString;

        public ClinicDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ClinicDbContext CreateDbContext()
        {
            DbContextOptions option = new DbContextOptionsBuilder().UseSqlServer(_connectionString).Options;
            return new ClinicDbContext(option);
        }
    }
}
