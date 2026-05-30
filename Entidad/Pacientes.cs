using System;

namespace Entidad
{
    public class Pacientes
    {
        public int id_paciente { get; set; }
        public string nombre_paciente { get; set; }
        public string apellido_paciente { get; set; }
        public string telefono_paciente { get; set; }
        public string correo_paciente { get; set; }
        public DateTime fecha_nacimiento_paciente { get; set; } 
        public string notas_medicas_paciente { get; set; }


    }
}
