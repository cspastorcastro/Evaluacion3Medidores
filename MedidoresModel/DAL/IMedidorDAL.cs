using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();
        List<Medidor> Filtrar(int idTipo);
        List<Lectura> ObtenerLecturas(string idMedidor);
        void Agregar(Medidor medidor);
        void Eliminar(string id);
    }
}
