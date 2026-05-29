using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Citas
    {
        public int id_cita {  get; set; }
        public DateOnly fecha_cita { get; set; }
        public TimeOnly hora_cita { get; set; }
        public string motivo_consulta { get; set; }
        public string estado_consulta { get; set; }
        public int id_paciente { get; set; }
    }
}
