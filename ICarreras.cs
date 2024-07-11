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

        Carrera FindBySigla(string sigla);
        List<Carrera> List();
        bool NombreExists(string nombre); 
        bool SiglaExists(string sigla);
    }
}
