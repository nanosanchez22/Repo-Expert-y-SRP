using System;
using System.Text;

namespace Library
{
    public class Doctor{
        public string DoctorName{ get; }
        public string Speciality{ get; }

        public Doctor(string doctorName, string speciality){

            if (string.IsNullOrEmpty(doctorName))
                throw new ArgumentException("Doctor name is required", nameof(doctorName));

            if (string.IsNullOrEmpty(speciality))
                throw new ArgumentException("Speciality is required", nameof(speciality));

            DoctorName = doctorName;
            Speciality = speciality;




            this.DoctorName = doctorName;
            this.Speciality = speciality;
        }
    }     
}
