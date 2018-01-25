using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Manik.Practice.EntityFramework;

namespace Manik.Practice.Migrator
{
    [DependsOn(typeof(PracticeDataModule))]
    public class PracticeMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<PracticeDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}