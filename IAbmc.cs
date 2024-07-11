using Crud.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Interfaces
{
    internal interface IAbmc<T>:IId
    {

        void Modify(T data);
        void Erase(T data);
        Usuario Find(T data);
        T Add(T data);
        void Add(Usuario usuario);
    }
}
