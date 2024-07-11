using Crud.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Interfaces
{
    internal interface IUsuarios
    {



        string Nombre { get; set; }
        int Dni { get; set; }
        String Mail { get; set; }




        bool DniExist(int dni);
        bool MailExist(string mail);
 
        Usuario FindbyMail(string mail);
        Usuario FindbyDni(int dni);
        List<Usuario> List();




    }
}
