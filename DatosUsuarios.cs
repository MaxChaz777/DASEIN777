using Crud.Interfaces;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Crud.Clases;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Data;

namespace Crud.Datos
{
    internal partial class DatosUsuarios : IAccesoDatos<Usuario>
    {
        private static List<Usuario> listaUsuarios;

        private static int LastId;

        private static void Read() 
        {
            try
            {
                string path = "C:\\Users\\A6\\Sistemas\\Algoritmo II\\Crud\\Crud\\Datos\\usuarios.json";

                string json= File.ReadAllText(path);
               
                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }
                }


        private static void Write()
        {
            try

            {
                string path = "C:\\Users\\A6\\Sistemas\\Algoritmo II\\Crud\\Crud\\Datos\\usuarios.json";

                string json = JsonSerializer.Serialize(listaUsuarios);

                File.WriteAllText(path, json);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        public void Clear() 
        {
            listaUsuarios.Clear();
        }

        public void Add(Usuario data)
        {
            Read();

            string pathID = "C:\\Users\\A6\\Sistemas\\Algoritmo II\\Crud\\Crud\\Datos\\usuariosLastID.txt";

            LastId = int.Parse(File.ReadAllText(pathID));

            data.ID =++LastId;

            File.WriteAllText(pathID, LastId.ToString());
            
            listaUsuarios.Add(data);

            Write();
            Clear();
        }

        public void Erase(Usuario data)
        {
            throw new NotImplementedException();
        }

        public Usuario Find(Usuario data)
        {
            throw new NotImplementedException();
        }

        public void Modify(Usuario data)
        {
            throw new NotImplementedException();
        }

    
    }
}
