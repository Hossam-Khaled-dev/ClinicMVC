using Clinic.BL;
using Clinic.DAL;
using Microsoft.AspNetCore.Mvc;


namespace Clinic.Controllers
{
    public class DoctorController : Controller
    {
        private IDoctorServices _doctorServices;

        public DoctorController(IDoctorServices doctorManager)
        {
            _doctorServices = doctorManager;
        }
        public ActionResult<IEnumerable<Doctor>> Index()
        {
            IEnumerable<Doctor> objDoctortList = _doctorServices.GetAllDoctors();
            return View(objDoctortList);
           
        }
        public IActionResult DoctorAppointment(int id)
        {
            var _doctor = _doctorServices.GetDoctorById(id);
            var appointments = _doctorServices.GetAllDocAppoint(id);
          
            ViewBag.Doctor = _doctor;
            return View(appointments);

        }
    }
}
