using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_tarea_ccalero
{
   public class Personas
    {
        private int id_persona;

        public int Id_persona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private int telf;

        public int Telf
        {
            get { return telf; }
            set { telf = value; }
        }

        
        private DateTime fechaRegistro;

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public Personas()
        {
            id_persona = 1;
            nombres = "Cristhian";
            apellidos = "Calero Gazo";
            direccion = "Managua -Repartp Francisco Telemaco Talavera";
            telf = 8482044;
            fechaRegistro = DateTime.Parse("2015/12/31");
            status = 1;

        }
            
   }
}
