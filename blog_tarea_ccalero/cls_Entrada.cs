using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_tarea_ccalero
{
    public class cls_Entrada : Personas
    {
        private string tipo_entrada ;

        public string Tipo_entrada
        {
            get { return tipo_entrada; }
            set { tipo_entrada = value; }
        }


        private DateTime Fechaacceso;

        public DateTime Fechaacceso1
        {
            get { return Fechaacceso; }
            set { Fechaacceso = value; }
        }

     
        
        
        public cls_Entrada(string tipo)
        {
            if (tipo == "A")
            {
                Tipo_entrada = "Autor";
            }
            else
            {
                Tipo_entrada = "Lector";
            }
            this.Fechaacceso = DateTime.Now;    
        
        }

        
    }
}
