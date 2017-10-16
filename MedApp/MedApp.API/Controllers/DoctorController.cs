using MedApp.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApp.API.Controllers
{
    public class DoctorController
    {
        private BllUnitOfWork _bll;
        public DoctorController(BllUnitOfWork bll)
        {
            _bll = bll;
        }

        [HttpGet("doctor/getAllDoctors")]
        public async Task<IActionResult> GetAllDoctors()
        {
            var data = await _bll.DoctorRepository.GetAllDoctors();

            return new ObjectResult(data);
        }
    }
}
