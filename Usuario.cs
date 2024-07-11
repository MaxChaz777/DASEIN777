using Crud.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Clases
{
    internal class Usuario : IAbmc<Usuario>,IUsuarios

    {

        static public List<Usuario> Usuarios = new List<Usuario>();

        static int lanId = 1;

        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Mail { get ; set; }

        public int Id { get; set; }




        #region IAbmc




        public void Add(Usuario usuario)
        {
            if (MailExist(usuario.Mail)) throw new Exception("El mail ya existe");
            if (DniExist(usuario.Dni)) throw new Exception("El DNI ya existe");

            usuario.Id = lanId;
            lanId++;
            Usuarios.Add(usuario);

        }

        public void Erase(Usuario usuario)
        {

            
                foreach (Usuario u in Usuarios) { 
            if(u.Dni == usuario.Dni) 
                    Usuarios.RemoveAt(u.Dni);

            }
                    
                        
            throw new NotImplementedException("El usuario no existe");
        }

        public Usuario Find(Usuario usuario)
        {

            foreach (Usuario u in Usuarios)
            {
                if (u.Id == usuario.Id) return u;

            }

            throw new NotImplementedException(" No se encontró el Id del usuario");

        }

        public void Modify(Usuario usuario)
        {

//Son dos excepciones que funcionan como filtro para determinar si existe un usuario

            Usuario u= Find(usuario);

            if(u==null) throw new NotImplementedException("No se encontró usuario a modificar");

            u.Nombre = usuario.Nombre;


        }

        Usuario IAbmc<Usuario>.Add(Usuario data)
        {
            throw new NotImplementedException();
        }

        #endregion



        #region IUsuario
        public bool DniExist(int dni)
        {


            foreach (Usuario u in Usuarios) {

                if (u.Dni == dni)
                {
                    return true;
                }


            }
        return false;


        }

        public bool MailExist(string mail)
        {


            foreach (Usuario u in Usuarios)
            {

                if (u.Mail == mail)
                {
                    return true;
                }



            }
            return false;


        }


        public Usuario FindbyDni(int dni)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Dni == dni) return u;
            }

            throw new NotImplementedException("No se encontró al usuario con ese DNI");
        }

        public Usuario FindbyMail(string mail)
        {

            foreach (Usuario u in Usuarios)
            {
                if (u.Mail == mail) return u;
            }
            throw new NotImplementedException("No se encontró al usuario con ese Mail");
        }

        public List<Usuario> List()
        {
            return Usuarios;
        }



        #endregion

    }
}
