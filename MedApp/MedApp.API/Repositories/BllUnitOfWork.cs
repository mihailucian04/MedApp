using MedApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApp.API.Repositories
{
    public class BllUnitOfWork : IDisposable
    {
        private bool _disposed;
        private readonly MedAppContext _dbContext;

        private DoctorRepository _doctorRepository;

        public BllUnitOfWork(MedAppContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual DoctorRepository DoctorRepository => _doctorRepository ?? (_doctorRepository = new DoctorRepository(_dbContext, this));

        #region Dispose
        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
        #endregion
    }
}
