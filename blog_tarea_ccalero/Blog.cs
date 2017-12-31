using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_tarea_ccalero
{
    //Agregamos la palabra reservada PUBLIC para cambiar el ambito de la clase de privada a publica
    public class Blog
    {

        // Declaracion de Atributos y encapsulamiento 
        private DateTime fechaCreacion;
        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private string contenido;

        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }
        private string[] etiquetas;

        public string[] Etiquetas
        {
            get { return etiquetas; }
            set { etiquetas = value; }
        }
        private int likes;

        public int Likes
        {
            get { return likes; }
            set { likes = value; }
        }
        private bool liked;

        public bool Liked
        {
            get { return liked; }
            set { liked = value; }
        }
        private string[] comentarios;

        public string[] Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
        private int numeroVisitas;

        public int NumeroVisitas
        {
            get { return numeroVisitas; }
            set { numeroVisitas = value; }
        }

        public Blog(string _titulo, string _contenido, string[] _etiquetas)
        {
            this.titulo = _titulo;
            this.contenido = _contenido;
            this.etiquetas = _etiquetas;
        }


    
    
    }
}
