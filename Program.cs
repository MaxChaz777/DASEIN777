using Crud.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CreacionDeUsuarios

            Usuario usuario = new Usuario();
            usuario.Nombre = "Daniela";
            usuario.Mail = "Daniela@mail.com";
            usuario.Dni = 35;

            Usuario usuario2 = new Usuario()
            {
                Nombre = "Juan",
                Mail = "juan@mail.com",
                Dni = 32
            };

            Usuario usuario3 = new Usuario()
            {
                Nombre = "Maximiliano",
                Mail = "kaker2018@gmail.com",
                Dni = 33
            };

            Usuario usuario4 = new Usuario()
            {
                Nombre = "Neo",
                Mail = "kneodematrix@gmail.com",
                Dni = 34
            };
            
            Usuario usuario5= new Usuario()
            {
                Nombre = "Trinity",
                Mail = "Trinity@gmail.com",
                Dni = 34
            };
            Usuario usuario10 = new Usuario()
            {
                Nombre = "Lionel Messi",
                Mail = "elmejordelmundo@gmail.com",
                Dni = 20
            };

            Usuario usuario100 = new Usuario()
            {
                Nombre = "Antonela",
                Mail = "Antonela@gmail.com",
                Dni = 20
            };

            #endregion

            #region AddUsuarios

            usuario.Add();

            usuario2.Add();

            usuario3.Add();
            
            usuario4.Add();

            usuario5.Add();

            usuario10.Add();

            usuario100.Add();



            // usuario.Add(usuario2);
            // usuario2.Add(usuario2);

            #endregion

        }
    }
}
