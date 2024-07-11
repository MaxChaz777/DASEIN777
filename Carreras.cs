using Crud.Interfaces;
using Crud.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Crud.Clases
{
    internal class Carrera : ICarreras,  IAbmc<Carrera>
    {
        private static List<Carrera> Carreras = new List<Carrera>();

        private static int carreraId = 1;


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }




        #region icarreras
        public Carrera FindBySigla(string sigla)
        {
            return Carreras.Find(c => c.Sigla == sigla);
        }

        public List<Carrera> List()
        {
            return Carreras;
        }


        public bool NombreExists(string nombre)
        {

            foreach (Carrera u in Carreras)
            {

                if (u.Nombre == nombre)
                {
                    return true;
                }



            }
            return false;
        }

        public bool SiglaExists(string sigla)
        {
            foreach (Carrera u in Carreras)
            {

                if (u.Sigla == sigla)
                {
                    return true;
                }
            }
            return false;
        }
            #endregion iacarreras


            #region IAbmc


        public void Modify(Carrera carrera)
        {
            Carrera u = carrera;

            if (u == null) throw new NotImplementedException("No se encontró carrera a modificar");

            u.Nombre = u.Nombre;


        }

        public Carrera Add(Carrera carrera)
        {
            if (NombreExists(carrera.Nombre))
            {
                throw new Exception("El nombre de la carrera ya existe.");
            }

            if (SiglaExists(carrera.Sigla))
            {
                throw new Exception("La sigla de la carrera ya existe.");
            }

            carrera.Id = carreraId;
            carreraId++;
            Carreras.Add(carrera);
            return carrera;
        }

        public void Erase(Carrera carrera)
        {
            int index = Carreras.FindIndex(c => c.Id == carrera.Id);
            if (index == -1)
            {
                throw new Exception("La carrera con ese ID no existe.");
            }

            Carreras.RemoveAt(index);
        }


       
        public Usuario Find(Carrera carrera)
        {
            // Verificar si existe la carrera
            if (carrera == null || carrera.Id == 0)
            {
                throw new ArgumentException("No existe la carrera");
            }

            // Buscar Usuarios asociados con la Carrera especificada


            Usuario usuario = Usuario.Usuarios.FirstOrDefault(u => u.Id == carrera.Id);

            // Devolver el Usuario encontrado o null si no se encuentra
            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                throw new ArgumentException("No se encuentra el usuario");
            }
        }

        public void Add(Usuario usuario)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}