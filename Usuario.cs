using Crud.Datos;
using Crud.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Clases
{
    internal class Usuario : IAbmc<Usuario>, IUsuarios



    {

        // Lógica de datos

        private static DatosUsuarios datos = new DatosUsuarios();



        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Mail { get ; set; }

        public int ID { get; set; }




        #region IAbmc




        public void Add()
        {

            datos.Add(this);
   
        }

        public void Erase()
        {
            datos.Erase(this);
        

            }
    
        

        public void Modify()
        {
           datos.Modify(this);

        }

     

        #endregion



        #region IUsuario
        public bool DniExist()
        {


         return false;


        }

        public bool MailExist()
        {


         
            return false;


        }

        public void FindbyDni()
        {
         
        }

        public void FindbyMail()
        {

      
        }

        public Usuario Find()

        {
            throw new NotImplementedException();
        }








        #endregion

    }
}
