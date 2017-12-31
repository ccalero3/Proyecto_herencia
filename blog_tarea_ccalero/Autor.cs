using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_tarea_ccalero
{
  //Aplicando herencia de la clase Persona 
    public  class Autor : Personas
    {
        private String tipoarticulo;

        public String Tipoarticulo
        {
            get { return tipoarticulo; }
            set { tipoarticulo = value; }
        }
        private int Num_articuloPublicado;

        public int Num_articuloPublicado1
        {
            get { return Num_articuloPublicado; }
            set { Num_articuloPublicado = value; }
        }
        private int id_articulo;

        public int Id_articulo
        {
            get { return id_articulo; }
            set { id_articulo = value; }
        }

        public Autor(string tipo, int num_publicacion, int idarto)
        {
            this.tipoarticulo = tipo;
            this.Num_articuloPublicado = num_publicacion;
            this.id_articulo = idarto;

        }
         

    }
}
