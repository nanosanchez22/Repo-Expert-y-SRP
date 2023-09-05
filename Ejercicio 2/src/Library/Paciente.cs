using System;
using System.Text;

namespace Library
{
    public class Paciente{
        public string PacienteName{ get; }
        public string PacienteId{ get; }
        public string PacienteAge{ get; }
        public string PacientePhone{ get; }
        
        public Paciente(string pacienteName, string pacienteId, string pacienteAge, string pacientePhone){


            if (string.IsNullOrEmpty(pacienteName))
                    throw new ArgumentException("Paciente name is required", nameof(pacienteName));

                if (string.IsNullOrEmpty(pacienteId))
                    throw new ArgumentException("Paciente ID is required", nameof(pacienteId));

                if (string.IsNullOrEmpty(pacienteAge))
                    throw new ArgumentException("Paciente age is required", nameof(pacienteAge));

                if (string.IsNullOrEmpty(pacientePhone))
                    throw new ArgumentException("Paciente phone is required", nameof(pacientePhone));

                PacienteName = pacienteName;
                PacienteId = pacienteId;
                PacienteAge = pacienteAge;
                PacientePhone = pacientePhone;
        }
    }   
}
