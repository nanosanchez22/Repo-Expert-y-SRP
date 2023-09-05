using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor doctor1 = new Doctor("Dr. Sanchez", "Cardiologo");
            Paciente paciente1 = new Paciente("Juan", "12345", "30", "555-555-555");

            string appointment1 = AppointmentService.CreateAppointment("app1", "986782342", DateTime.Now, "Lugar 1", doctor1, paciente1);
            Console.WriteLine(appointment1);

            Doctor doctor2 = new Doctor("Dr. Fernandez", "Dermatology");
            Paciente paciente2 = new Paciente("Matias", "54321", "45", "555-555-555");

            string appointment2 = AppointmentService.CreateAppointment("app2", "", DateTime.Now, "Lugar 2", doctor2, paciente2);
            Console.WriteLine(appointment2);

        }
    }
}
