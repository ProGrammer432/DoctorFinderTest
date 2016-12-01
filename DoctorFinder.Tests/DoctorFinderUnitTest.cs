using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoctorFinder.Models;
using System.Collections.Generic;

namespace DoctorFinder.Tests
{
    [TestClass]
    public class DoctorFinder
    {
        [TestMethod]
        public void FindDoctorsBySpecialization_OnSelect()
        {
            DoctorRepository _docRepo = new DoctorRepository();
            Doctor _selectedDoctor = new Doctor { Name = "Kim Buy", DoctorID = 12, HospitalID = 15, Sex = "FeMale", LocationLattitude = null, LocationLongitude = null, SpecializationCode = 1 };

           List<Doctor> findedDoctors =  _docRepo.FindDoctorsBySpecialization(_selectedDoctor);

           Assert.IsTrue(findedDoctors.Count >= 0);
          
        }
    }
}
