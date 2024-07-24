using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturaDAL
    {
        void Agregar(Lectura lectura);
        void Eliminar(string id);
        List<Lectura> Filtrar(string idMedidor);
        List<Lectura> ObtenerLecturas();
    }
}
