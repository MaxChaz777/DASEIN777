using Crud.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Interfaces

{
    internal interface ICarreras
    {
        string Nombre { get; set; }
        string Sigla { get; set; }
        string Titulo { get; set; }
        int Duracion { get; set; }

       bool FindBySigla();
        bool NombreExists(); 
        bool SiglaExists();
    }
}
