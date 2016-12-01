using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorFinder.Models
{
    public class Doctor
    {
        public string Name { get; set; }

        public int DoctorID { get; set; }

        public string Sex { get; set; }

        public int SpecializationCode { get;  set; }

        public int HospitalID { get;  set; }

        public string LocationLattitude {get;  set;}

        public string LocationLongitude {get; set;}
    }
}