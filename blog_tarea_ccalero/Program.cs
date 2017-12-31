using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_tarea_ccalero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Usuario us1 = new Usuario();
            us1.Nom_usuario = "ccalero";
            us1.Pasword ="CCA";
            Console.WriteLine("Selecione opcion deseada, 1= Lector, 2= Autor");
            int opc = Console.Read();
            //Console.WriteLine(opc);
            if (opc==49)
            {
                Console.WriteLine("Esta ingresando como lector");
                Lector l = new Lector();
            }
            else if (opc==50)
            {
                Console.WriteLine("Esta ingresando como Autor");

            }

            */
            
            Console.WriteLine("***************************************************************");
            Console.WriteLine("*       Tarea para entregar el 05 de enero 2018               *");
            Console.WriteLine("*       Aplicacion de Herencia en ejercio de blog             *");
            Console.WriteLine("***********************************************************CCG*");
            Console.WriteLine("");
            
            //Para demostrar la herencia de la clase persona a las sub clases autor y lector repetimos el codigo al instancias
            //cada clase autor y lector. 
            
            cls_Entrada e = new cls_Entrada("L");
            Console.WriteLine("Has ingresado con el nombre de =====> " + e.Nombres);
            Console.WriteLine("Fecha de acceso                =====> " + e.Fechaacceso1);
            Console.WriteLine("*       Tus datos seran grabados al historial de entrada         *");
            Console.WriteLine("");
            Console.ReadKey();
                
            if (e.Tipo_entrada == "Autor")
            {
                Console.WriteLine("*       Tu Seccion como Autor a Iniciado               *");
                
                Console.WriteLine("");
                Autor a = new Autor("Politico", 10, 1);
                Console.WriteLine("====================Herencia Clase Persona=====================*");
                Console.WriteLine("Id_Persona =====> " + a.Id_persona);
                Console.WriteLine("Nombres    =====> " + a.Nombres);
                Console.WriteLine("Apellidos  =====> " + a.Apellidos);
                Console.WriteLine("Direccion  =====> " + a.Direccion);
                Console.WriteLine("Fecha ingreso ==> " + a.FechaRegistro);
                Console.WriteLine("Status 1=activo,0=inactivo ==> " + a.Status);
                Console.WriteLine("====================Atributos de la Clase Autor===============*");
                Console.WriteLine("Tipo articulo                   ==> " + a.Tipoarticulo);
                Console.WriteLine("Numeros de Articulos Publicados ==> " + a.Num_articuloPublicado1);
                Console.WriteLine("Id de articulo Publicado        ==> " + a.Id_articulo);
            }
            else
            {
                Console.WriteLine("*       Has iniciado como lector               *");
                Console.WriteLine("");
                Lector l = new Lector();
                Console.WriteLine("====================Herencia Clase Persona=====================*");
                Console.WriteLine("Id_Persona =====> " + l.Id_persona);
                Console.WriteLine("Nombres    =====> " + l.Nombres);
                Console.WriteLine("Apellidos  =====> " + l.Apellidos);
                Console.WriteLine("Direccion  =====> " + l.Direccion);
                Console.WriteLine("Fecha ingreso ==> " + l.FechaRegistro);
                Console.WriteLine("Status 1=activo,0=inactivo ==> " + l.Status);
                Console.WriteLine("====================Atributos de la Clase Lector===============*");
                Console.WriteLine("Comentario del lector  ==> " + l.Comentarios);
                Console.WriteLine("El articulo a sido visitado ==> " + l.Numero_art_visitados+ " Veces");
                Console.WriteLine("El id del articulo es        ==> " + l.Id_arto_visitado);
                
            }
            Console.ReadKey();
         
        
        }

          
    }

}
