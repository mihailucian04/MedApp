using MedApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApp.API.Repositories
{
    public class DoctorRepository
    {
        private readonly MedAppContext _context;
        private readonly Repository<DoctorModel> _service;

        public DoctorRepository(MedAppContext context, BllUnitOfWork bll)
        {
            _context = context;
            _service = new Repository<DoctorModel>(context, bll);
        }

        public async Task<ICollection<DoctorModel>> GetAllDoctors()
        {
            return (await _service.GetAllAsync());
        }
    }
}
