using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorFinder.Models
{
    public class DoctorRepository
    {
        public List<Doctor> FindDoctorsBySpecialization(Doctor doctor)
        {
            List<Doctor> _matchingDoctors = new List<Doctor>();

            Doctor docOne = new Doctor { Name = "Kim Buy", DoctorID = 12, HospitalID = 15, Sex = "FeMale", LocationLattitude = null, LocationLongitude = null, SpecializationCode = 1 };
            Doctor docTwo = new Doctor { Name = "Jim Buy", DoctorID = 13, HospitalID = 16, Sex = "Male", LocationLattitude = null, LocationLongitude = null, SpecializationCode = 2 };
            Doctor docThree = new Doctor { Name = "Kim Jerem", DoctorID = 18, HospitalID = 17, Sex = "Male", LocationLattitude = null, LocationLongitude = null, SpecializationCode = 1 };
            _matchingDoctors.Add(docOne);
            _matchingDoctors.Add(docTwo);
            _matchingDoctors.Add(docThree);

                                 
            return (doctor.SpecializationCode==null) ? null : _matchingDoctors.Where(x=> x.SpecializationCode == doctor.SpecializationCode).ToList();
        }
    }
}