using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_tarea_ccalero
{
    public class Lector: Personas
    {
        private string comentarios;

        public string Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
        private int numero_art_visitados;

        public int Numero_art_visitados
        {
            get { return numero_art_visitados; }
            set { numero_art_visitados = value; }
        }
        private int id_arto_visitado;

        public int Id_arto_visitado
        {
            get { return id_arto_visitado; }
            set { id_arto_visitado = value; }
        }

        public Lector()
        {
            this.Comentarios = "Este es un buen articulo, me parece de interes social muy excelente";
            this.id_arto_visitado = 4;
            this.numero_art_visitados = 10;
        }
        

    }
}
