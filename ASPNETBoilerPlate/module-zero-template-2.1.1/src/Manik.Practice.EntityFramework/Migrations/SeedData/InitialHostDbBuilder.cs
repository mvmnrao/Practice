using Manik.Practice.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Manik.Practice.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly PracticeDbContext _context;

        public InitialHostDbBuilder(PracticeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
