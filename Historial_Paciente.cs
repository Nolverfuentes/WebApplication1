using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Historial_Paciente
    {
        public static string Id_consulta { get; set; }
        public static string Nit_Paciente  { get; set; }
        public static DateTime Fecha_hora_consulta { get; set; }
        public static string Hora_Inicio { get; set; }
        public static string Temperatura { get; set; }
        public static string Presion { get; set; }
        public static string Sintomas { get; set; }

        public static string Diagnostico { get; set; }
        public static string Tratamiento { get; set; }
        public static string Receta { get; set; }

        public static string Proxima_visita { get; set; }

        public static string Costo_Consulta { get; set; }
       


    }
}