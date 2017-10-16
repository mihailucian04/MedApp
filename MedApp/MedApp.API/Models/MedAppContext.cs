using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApp.API.Models
{
    public class MedAppContext: DbContext
    {
        private IConfigurationRoot _config;
        public MedAppContext(IConfigurationRoot config, DbContextOptions options): base(options)
        {
            _config = config;
        }

        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<PacientModel> Pacients { get; set; }
        public DbSet<PacientDiagnosticsModel> Diagnostics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:MedAppConnectionString"]);
        }
    }
}
