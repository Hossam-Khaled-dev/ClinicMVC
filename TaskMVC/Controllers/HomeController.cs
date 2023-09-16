using Clinic.BL;
using Clinic.DAL;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Controllers
{
    public class HomeController : Controller
    {
        private IAppointmentServices _appointmentServices;
        private IDoctorServices _doctorServices;

        public HomeController(IAppointmentServices appointmentServices, IDoctorServices doctorServices)
        {
            _appointmentServices = appointmentServices;
            _doctorServices = doctorServices;
        }

        public IActionResult Index()
        {
            var appointments = _appointmentServices.GetAllActors();
            return View(appointments);
        }
        public IActionResult Create()
        {
            var doctors = _doctorServices.GetAllDoctors().ToList();
            ViewBag.Doctors=doctors;
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(CreateAppointmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =await _appointmentServices.AddAppointmentAndPatient(model);
                if (result == false)
                {
                    ModelState.AddModelError("", "An appointment already exists at this date and time.");
                    return View(model);
                }if(result == true)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}